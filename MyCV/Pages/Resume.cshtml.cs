using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCV.Data.Entities;
using MyCV.Services;

namespace MyCV.Pages
{
    public class ResumeModel : PageModel
    {
        private readonly IResumeService _resumeService;

        public ResumeModel(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        public ResumeEntity Resume { get; set; }

        public void OnGet()
        {
            Resume = _resumeService.GetResume();
        }
    }
}
