using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PC0456\MSSQL2017;Database=HospitalDb;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorPatient>().HasKey(sc => new { sc.DoctorId, sc.PatientId });
            modelBuilder.Entity<DrugPatient>().HasKey(sc => new { sc.DrugId, sc.PatientId });
            modelBuilder.Entity<Patient>()
                .HasOne<Room>(p => p.Room)
                .WithOne(r => r.Patient)
                .HasForeignKey<Room>(r => r.RoomId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder
            .Entity<DocView>()
            .ToView(nameof(DocViews))
            .HasKey(t => t.DoctorId);
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Cases> Cases { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<HealthCareAssistant> HealthCareAssistants { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Drugs> Drugs { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public DbSet<DoctorPatient> DoctorPatients { get; set; }
        public DbSet<DocView> DocViews { get; set; }
    }
}
