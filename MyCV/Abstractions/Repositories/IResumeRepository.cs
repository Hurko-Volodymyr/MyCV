using MyCV.Data.Entities;

namespace MyCV.Abstractions.Repositories
{
    public interface IResumeRepository
    {
        Task<ResumeEntity?> TryGetResumeAsync(string id);
        Task<List<ResumeEntity>> GetAllResumesAsync();
    }
}
