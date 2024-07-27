using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCV.Abstractions.Services;
using MyCV.Models;

namespace MyCV.Pages
{
    public class ResumePageModel : PageModel
    {
        private readonly IResumeService _resumeService;

        public ResumePageModel(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        public List<ResumeModel> Resumes { get; set; }
        public ResumeModel Resume { get; set; }

        public async Task OnGetAsync()
        {
            Resumes = await _resumeService.GetAllResumesAsync();
            Resume = Resumes.FirstOrDefault();
        }
    }
}
