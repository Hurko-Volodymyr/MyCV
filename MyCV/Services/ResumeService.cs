using MyCV.Data.Entities;

namespace MyCV.Services
{
    public interface IResumeService
    {
        ResumeEntity GetResume();
    }

    public class ResumeService : IResumeService
    {
        public ResumeEntity GetResume()
        {
            return new ResumeEntity
            {
                FullName = "Ваше Ім'я",
                Contact = "ваш.email@example.com",
                Summary = "Короткий опис вашого професійного досвіду та цілей.",
                Skills = new List<string> { "C#", "ASP.NET Core", "HTML", "CSS", "JavaScript" },
                WorkExperiences = new List<WorkExperienceEntity>
                {
                    new WorkExperienceEntity
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
