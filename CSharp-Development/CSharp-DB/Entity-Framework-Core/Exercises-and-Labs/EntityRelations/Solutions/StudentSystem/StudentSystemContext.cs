using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {
        }

        public StudentSystemContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Homework> HomeworkSubmissions { get; set; }
        public DbSet<Resource> Resources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=StudentSystem;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>(entity =>
            {
                entity.Property(s => s.Name)
                    .HasMaxLength(100);

                entity.Property(s => s.PhoneNumber)
                    .HasColumnType("CHAR(10)")
                    .IsRequired(false);
            });

            builder.Entity<Course>(entity =>
            {
                entity.Property(c => c.Name)
                    .HasMaxLength(80);

                entity.Property(c => c.Description)
                    .IsRequired(false);
            });

            builder.Entity<Resource>(entity =>
            {
                entity.Property(r => r.Name)
                    .HasMaxLength(50);

                entity.Property(r => r.Url)
                    .IsUnicode(false);

                entity.HasOne(r => r.Course)
                    .WithMany(c => c.Resources)
                    .HasForeignKey(r => r.CourseId);
            });

            builder.Entity<Homework>(entity =>
            {
                entity.Property(h => h.Content)
                    .IsUnicode(false);

                entity.HasOne(h => h.Student)
                    .WithMany(s => s.HomeworkSubmissions)
                    .HasForeignKey(h => h.StudentId);

                entity.HasOne(h => h.Course)
                    .WithMany(c => c.HomeworkSubmissions)
                    .HasForeignKey(h => h.CourseId);
            });

            builder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(sc => new {sc.StudentId, sc.CourseId});

                entity.HasOne(sc => sc.Student)
                    .WithMany(s => s.CourseEnrollments)
                    .HasForeignKey(sc => sc.StudentId);

                entity.HasOne(sc => sc.Course)
                    .WithMany(c => c.StudentsEnrolled)
                    .HasForeignKey(sc => sc.CourseId);
            });
        }
    }
}
