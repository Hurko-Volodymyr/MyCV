using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCV.Data.Entities;

namespace MyCV.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ResumeEntity> Resumes { get; set; }
        public DbSet<EducationEntity> Educations { get; set; }
        public DbSet<WorkExperienceEntity> Experiences { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ResumeEntity>()
                .HasMany(r => r.Education)
                .WithOne()
                .HasForeignKey("ResumeId");

            modelBuilder.Entity<ResumeEntity>()
                .HasMany(r => r.WorkExperiences)
                .WithOne()
                .HasForeignKey("ResumeId");
        }
    }
}
