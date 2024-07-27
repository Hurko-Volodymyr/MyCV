namespace MyCV.Data.Entities
{
    public class WorkExperienceEntity
    {
        public string WorkId { get; set; }
        public string ResumeId { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}
