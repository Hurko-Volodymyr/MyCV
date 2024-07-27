using MyCV.Abstractions.Repositories;
using MyCV.Abstractions.Services;
using MyCV.Data.Entities;
using MyCV.Models;
using MyCV.Pages;
using System.Text.Json;

namespace MyCV.Services
{
    public class ResumeService : IResumeService
    {

        private readonly IResumeRepository _resumeRepository;

        public ResumeService(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        public async Task<ResumeModel?> TryGetResumeAsync(string id)
        {
            var resumeEntity = await _resumeRepository.TryGetResumeAsync(id);
            if (resumeEntity != null)
            {
                return MapEntityToModel(resumeEntity);
            }
            else
            {
                throw new Exception();
            }
        }
        public async Task<List<ResumeModel>> GetAllResumesAsync()
        {
            var resumeEntities = await _resumeRepository.GetAllResumesAsync();
            var resumeList = new List<ResumeModel>();
            foreach (var resumeEntity in resumeEntities)
            {
                resumeList.Add(MapEntityToModel(resumeEntity));
            }
            return resumeList;
        }

        private static ResumeModel MapEntityToModel(ResumeEntity entity)
        {
            return new ResumeModel
            {
                FullName = entity.FullName,
                Contact = entity.Contact,
                Summary = entity.Summary,
                Skills = entity.Skills,
                Education = entity.Education.Select(e => new EducationModel
                {
                    Name = e.Name,
                    Degree = e.Degree,
                    Description = e.Description,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate
                }).ToList(),
                WorkExperiences = entity.WorkExperiences.Select(w => new WorkExperienceModel
                {
                    Company = w.Company,
                    Position = w.Position,
                    StartDate = w.StartDate,
                    EndDate = w.EndDate,
                    Description = w.Description
                }).ToList()
            };
        }
    }
}
