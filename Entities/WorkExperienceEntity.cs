﻿namespace MyCV.Entities
{
    public class WorkExperienceEntity
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Skills { get; set; }
        public string Description { get; set; }
    }
}
