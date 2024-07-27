namespace MyCV.Models
{
    public class EducationModel
    {
        public string Name { get; set; }
        public string Degree { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}