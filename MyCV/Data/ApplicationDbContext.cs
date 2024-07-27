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
                .HasKey(r => r.ResumeId);

            modelBuilder.Entity<EducationEntity>()
                .HasKey(e => e.EducationId);

            modelBuilder.Entity<EducationEntity>()
                .HasOne(e => e.Resume)
                .WithMany(r => r.Education)
                .HasForeignKey(e => e.ResumeId);

            modelBuilder.Entity<WorkExperienceEntity>()
                .HasKey(w => w.WorkId);

            modelBuilder.Entity<WorkExperienceEntity>()
                .HasOne(w => w.Resume)
                .WithMany(r => r.WorkExperiences)
                .HasForeignKey(w => w.ResumeId);
        }
    }
}
