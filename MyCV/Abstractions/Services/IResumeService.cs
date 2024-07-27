using MyCV.Models;

namespace MyCV.Abstractions.Services
{
    public interface IResumeService
    {
        Task<ResumeModel?> TryGetResumeAsync(string id);
        Task<List<ResumeModel>> GetAllResumesAsync();
    }
}
