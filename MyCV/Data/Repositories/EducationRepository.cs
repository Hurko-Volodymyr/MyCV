using Microsoft.EntityFrameworkCore;
using MyCV.Abstractions.Repositories;
using MyCV.Data.Entities;

namespace MyCV.Data.Repositories
{
    public class EducationRepository : IEducationRepository
    {
        private readonly ApplicationDbContext _context;

        public EducationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<EducationEntity?> TryGetEducationsByIdAsync(string Id)
        {
            return await _context.Educations
                .Where(e => e.EducationId == Id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<EducationEntity>> GetEducationsByResumeIdAsync(string resumeId)
        {
            return await _context.Educations
                .Where(e => e.ResumeId == resumeId)
                .ToListAsync();
        }
    }
}