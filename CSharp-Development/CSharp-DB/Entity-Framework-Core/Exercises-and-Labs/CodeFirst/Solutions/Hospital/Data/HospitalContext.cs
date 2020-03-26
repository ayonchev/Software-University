using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientMedicament> Prescriptions { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Hospital;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Patient>(entity =>
            {
                entity.Property(p => p.PatientId).HasColumnName("PatientID");

                entity.Property(p => p.Email).IsUnicode(false);
            });

            builder.Entity<Diagnose>(entity =>
            {
                entity.ToTable("Diagnoses");

                entity.Property(d => d.DiagnoseId).HasColumnName("DiagnoseID");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(d => d.PatientId);
            });

            builder.Entity<Visitation>(entity =>
            {
                entity.ToTable("Visitations");

                entity.Property(v => v.VisitationId).HasColumnName("VisitationID");

                entity.HasOne(v => v.Patient)
                    .WithMany(p => p.Visitations)
                    .HasForeignKey(v => v.PatientId);

                entity.HasOne(v => v.Doctor)
                    .WithMany(p => p.Visitations)
                    .HasForeignKey(v => v.DoctorId);
            });

            builder.Entity<Medicament>(entity =>
            {
                entity.ToTable("Medicaments");

                entity.Property(m => m.MedicamentId).HasColumnName("MedicamentID");
            });

            builder.Entity<PatientMedicament>(entity =>
            {
                entity.ToTable("PatientMedicament");

                entity.HasKey(t => new { t.PatientId, t.MedicamentId });

                entity.HasOne(pm => pm.Patient)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(pm => pm.PatientId);

                entity.HasOne(pm => pm.Medicament)
                    .WithMany(m => m.Prescriptions)
                    .HasForeignKey(pm => pm.MedicamentId);
            });

            builder.Entity<Doctor>(entity =>
            {
                entity.Property(d => d.DoctorId).HasColumnName("DoctorID");
            });
        }
    }
}
