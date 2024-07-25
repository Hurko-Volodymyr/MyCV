using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCV.Models;

namespace MyCV.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ResumeModel> Resumes { get; set; }
        public DbSet<EducationModel> Educations { get; set; }
        public DbSet<WorkExperienceModel> Experiences { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ResumeModel>()
                .HasMany(r => r.Education)
                .WithOne()
                .HasForeignKey("ResumeId");

            modelBuilder.Entity<ResumeModel>()
                .HasMany(r => r.WorkExperiences)
                .WithOne()
                .HasForeignKey("ResumeId");
        }
    }
}
