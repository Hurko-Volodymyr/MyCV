using MyCV.Data.Entities;

namespace MyCV.Abstractions.Repositories
{
    public interface IEducationRepository
    {
        Task<EducationEntity?> TryGetEducationsByIdAsync(string Id);
        Task<List<EducationEntity>> GetEducationsByResumeIdAsync(string resumeId);
    }
}
