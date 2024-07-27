using Microsoft.EntityFrameworkCore;
using MyCV.Abstractions.Repositories;
using MyCV.Data.Entities;

namespace MyCV.Data.Repositories
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly ApplicationDbContext _context;

        public ResumeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ResumeEntity?> TryGetResumeAsync(string id)
        {
            return await _context.Resumes
                .AsSplitQuery()
                .Include(r => r.Education)
                .Include(r => r.WorkExperiences)
                .FirstOrDefaultAsync(r => r.ResumeId == id);
        }

        public async Task<List<ResumeEntity>> GetAllResumesAsync()
        {
            return await _context.Resumes
                .AsSplitQuery()
                .Include(r => r.Education)
                .Include(r => r.WorkExperiences)
                .ToListAsync();
        }
    }
}
