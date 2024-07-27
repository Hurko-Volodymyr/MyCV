namespace MyCV.Data.Entities
{
    public class ResumeEntity
    {
        public string ResumeId { get; set; }
        public string FullName { get; set; }
        public string Contact { get; set; }
        public string Summary { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public List<EducationEntity> Education { get; set; } = new List<EducationEntity> { };
        public List<WorkExperienceEntity> WorkExperiences { get; set; } = new List<WorkExperienceEntity>();
    }
}
