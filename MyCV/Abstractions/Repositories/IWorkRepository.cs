using MyCV.Data.Entities;

namespace MyCV.Abstractions.Repositories
{
    public interface IWorkRepository
    {
        Task<WorkExperienceEntity?> TryGetWorkExperienceByIdAsync(string Id);
        Task<List<WorkExperienceEntity>> GetWorkExperiencesByResumeIdAsync(string resumeId);
    }
}
