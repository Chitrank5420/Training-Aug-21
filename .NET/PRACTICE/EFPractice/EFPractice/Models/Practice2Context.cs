using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFPractice.Models
{
    public partial class Practice2Context : DbContext
    {
        public Practice2Context()
        {
        }

        public Practice2Context(DbContextOptions<Practice2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DupCountry> DupCountries { get; set; }
        public virtual DbSet<DupDataCountry> DupDataCountries { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC0456\\MSSQL2017;Database=Practice2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => new { e.RegionId, e.CountryId })
                    .HasName("PK__Countrie__51E9B9AB22D6473A");

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");

                entity.Property(e => e.CountryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Country_ID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DupCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dup_countries");

                entity.Property(e => e.CountryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Country_ID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");
            });

            modelBuilder.Entity<DupDataCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dup_data_countries");

                entity.Property(e => e.CountryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Country_ID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("Region_ID");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
