using Microsoft.EntityFrameworkCore;
using MyCV.Data.Entities;

namespace MyCV.Data
{
    public static class DataSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            if (context.Resumes.Any())
            {
                return;
            }

            var resume = new ResumeEntity
            {
                ResumeId = Guid.NewGuid().ToString(),
                FullName = "Volodymyr Hurko",
                Contact = "pzkpmfv@gmail.com",
                Summary = "A motivated software developer looking for better position",
                Skills = new List<string> { "C#", "ASP.NET Core", "Entity Framework Core", "SQL", "MVC", "OOP", "SOLID", "Postgresql", "Docker", "TypeScript-React basics", "Git", "HTML / CSS basics", "Unit Testing", "Playwright", "English: B1(EPAM - Examinator)" },
                Education = new List<EducationEntity>
                {
                    new EducationEntity
                    {
                        EducationId = Guid.NewGuid().ToString(),
                        Name = "V. N. Karazin Kharkiv National University",
                        Degree = "Bachelor of Science in History  and archeology",
                        Description = "Focused on the study of ancient and medieval civilizations in Europe",
                        StartDate = new DateTime(2017, 9, 1, 0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2021, 7, 18, 0, 0, 0, DateTimeKind.Utc),
                    },

                    new EducationEntity
                    {
                        EducationId = Guid.NewGuid().ToString(),
                        Name = "Kharkiv National Automobile & Highway University",
                        Degree = "Master’s diploma with honours of Science in Automated management of technological processes",
                        Description = "Gained expertise in the automation of technological processes, focusing on the integration of new technologies in industrial applications. Completed a thesis on the optimization of production workflows",
                        StartDate = new DateTime(2021, 9, 1, 0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2023, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                    },

                    new EducationEntity
                    {
                        EducationId = Guid.NewGuid().ToString(),
                        Name = "Kharkiv National Automobile & Highway University",
                        Degree = "PhD in Mechanical Engineering",
                        Description = "Working at the automation of technological processes, focusing on the integration of new technologies in industrial applications",
                        StartDate = new DateTime(2023, 9, 1, 0, 0, 0, DateTimeKind.Utc),
                    },

                    new EducationEntity
                    {
                        EducationId = Guid.NewGuid().ToString(),
                        Name = "A-Level IT School",
                        Degree = ".NET/C# Developer",
                        Description = "Studied various aspects of software engineering using .NET/C#, including advanced topics in software design patterns, architecture, and best practices. The course was interrupted due to war but provided solid foundational knowledge",
                        StartDate = new DateTime(2021, 10, 21, 0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2023, 05, 18, 0, 0, 0, DateTimeKind.Utc),
                    },

                    new EducationEntity
                    {
                        EducationId = Guid.NewGuid().ToString(),
                        Name = "QA Testlab",
                        Degree = "QA sertificate",
                        Description = "Completed an intensive course on Quality Assurance, learning with different educational projects and simulations",
                        StartDate = new DateTime(2022, 8, 1, 0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2022, 9, 1, 0, 0, 0, DateTimeKind.Utc),
                    },

                    new EducationEntity
                    {
                        EducationId = Guid.NewGuid().ToString(),
                        Name = "EPAM",
                        Degree = "Automated QA (C#)",
                        Description = "Specialized in automated testing using C#, focusing on developing robust and efficient test scripts. Worked on real-world projects, enhancing both technical and problem-solving skills",
                        StartDate = new DateTime(2022, 5, 1, 0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2022, 8, 1, 0, 0, 0, DateTimeKind.Utc),
                    },

                    new EducationEntity
                    {
                        EducationId = Guid.NewGuid().ToString(),
                        Name = "GeeksForLess",
                        Degree = ".NET/C# Developer",
                        Description = "Completed a developer training program, mastering advanced .NET/C# development techniques. Engaged in team-based projects to build scalable and maintainable applications",
                        StartDate = new DateTime(2023, 12, 1, 0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2023, 02, 13, 0, 0, 0, DateTimeKind.Utc),
                    },
                },

                WorkExperiences = new List<WorkExperienceEntity>
            {
                new WorkExperienceEntity
                {
                    WorkId = Guid.NewGuid().ToString(),
                    Company = "Kharkiv National Automobile & Highway University, Computer Science department",
                    Position = "Lecture assistant",
                    StartDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2023, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                    Description = "Assisted professors in preparing and delivering lectures, graded assignments, and provided support to students in understanding course material. Developed teaching materials and conducted study sessions."
                },

                new WorkExperienceEntity
                {
                    WorkId = Guid.NewGuid().ToString(),
                    Company = "Managed Code",
                    Position = "Trainee Software Developer",
                    StartDate = new DateTime(2023, 6, 1, 0, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2023, 9, 1, 0, 0, 0,  DateTimeKind.Utc),
                    Description = "Participated in a trainee program where I developed my skills in software development, specifically in C# and .NET. Worked on real-world projects under the guidance of senior developers, contributing to both testing and back-end tasks."
                },

                new WorkExperienceEntity
                {
                    WorkId = Guid.NewGuid().ToString(),
                    Company = "GeeksForLess",
                    Position = "Trainee Software Developer",
                    StartDate = new DateTime(2024, 3, 1, 0, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2024, 5, 1, 0, 0, 0,  DateTimeKind.Utc),
                    Description = "Gained hands-on experience in software development within a collaborative environment. Worked on various stages of the software development lifecycle, including coding, testing, and debugging applications."
                },

                new WorkExperienceEntity
                {
                    WorkId = Guid.NewGuid().ToString(),
                    Company = "GoITeens",
                    Position = "Roblox teacher",
                    StartDate = new DateTime(2024, 6, 22, 0, 0, 0,  DateTimeKind.Utc),
                    Description = "Teaching students how to develop games on the Roblox platform. Executing lectures, providing hands-on training, and mentoring young developers in game design and programming."
                }
                }
            };  

            context.Resumes.Add(resume);
            context.SaveChanges();
        }
    }
}
