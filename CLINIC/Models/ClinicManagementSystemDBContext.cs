using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CLINIC.Models
{
    public partial class ClinicManagementSystemDBContext : DbContext
    {
        public ClinicManagementSystemDBContext()
        {
        }

        public ClinicManagementSystemDBContext(DbContextOptions<ClinicManagementSystemDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<Specialization> Specializations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-OH39326H\\MSSQLSERVER01;Initial Catalog=ClinicManagementSystemDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.SpecializationId).HasColumnName("SpecializationID");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Time).HasMaxLength(10);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__Appointme__Patie__3B75D760");

                entity.HasOne(d => d.Specialization)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.SpecializationId)
                    .HasConstraintName("FK__Appointme__Speci__3C69FB99");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ContactDetails).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Specialization>(entity =>
            {
                entity.Property(e => e.SpecializationId).HasColumnName("SpecializationID");

                entity.Property(e => e.SpecializationName).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
