using MyCV.Models;

namespace MyCV.Services
{
    public interface IResumeService
    {
        ResumeModel GetResume();
    }

    public class ResumeService : IResumeService
    {
        public ResumeModel GetResume()
        {
            return new ResumeModel
            {
                FullName = "Ваше Ім'я",
                Contact = "ваш.email@example.com",
                Summary = "Короткий опис вашого професійного досвіду та цілей.",
                Skills = new List<string> { "C#", "ASP.NET Core", "HTML", "CSS", "JavaScript" },
                WorkExperiences = new List<WorkExperienceModel>
                {
                    new WorkExperienceModel
                    {
                        Company = "Назва Компанії",
                        Position = "Ваша Посада",
                        StartDate = new DateTime(2020, 1, 1),
                        EndDate = null,
                        Description = "Опис ваших обов'язків та досягнень."
                    }
                }
            };
        }
    }
}
