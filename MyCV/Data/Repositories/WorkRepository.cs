using Microsoft.EntityFrameworkCore;
using MyCV.Abstractions.Repositories;
using MyCV.Data.Entities;

namespace MyCV.Data.Repositories
{
    public class WorkRepository : IWorkRepository
    {

        private readonly ApplicationDbContext _context;

        public WorkRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<WorkExperienceEntity?> TryGetWorkExperienceByIdAsync(string Id)
        {
            return await _context.Experiences
                .Where(e => e.WorkId == Id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<WorkExperienceEntity>> GetWorkExperiencesByResumeIdAsync(string resumeId)
        {
            return await _context.Experiences
                .Where(w => w.ResumeId == resumeId)
                .ToListAsync();
        }
    }
}
