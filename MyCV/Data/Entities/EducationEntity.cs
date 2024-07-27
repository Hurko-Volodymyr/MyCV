namespace MyCV.Data.Entities
{
    public class EducationEntity
    {
        public string EducationId {  get; set; }
        public string ResumeId { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ResumeEntity Resume { get; set; }
    }
}
