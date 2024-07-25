namespace MyCV.Entities
{
    public class ResumeEntity
    {

        public string FullName { get; set; }
        public string Contact { get; set; }
        public string Summary { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public List<EducationModel> Education { get; set; } = new List<EducationModel> { };
        public List<WorkExperienceEntity> WorkExperiences { get; set; } = new List<WorkExperienceEntity>();
    }
}
