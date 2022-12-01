using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebMVC_Samoloty.Models;

namespace WebMVC_Samoloty.Data
{
    public partial class _3ti_prog_ark3odlotyContext : DbContext
    {
        public _3ti_prog_ark3odlotyContext()
        {
        }

        public _3ti_prog_ark3odlotyContext(DbContextOptions<_3ti_prog_ark3odlotyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Odloty> Odloties { get; set; } = null!;
        public virtual DbSet<Pozycja> Pozycjas { get; set; } = null!;
        public virtual DbSet<Przyloty> Przyloties { get; set; } = null!;
        public virtual DbSet<Samoloty> Samoloties { get; set; } = null!;
        public virtual DbSet<Typy> Typies { get; set; } = null!;
        public virtual DbSet<Uslugi> Uslugis { get; set; } = null!;
        public virtual DbSet<Zdjecium> Zdjecia { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=3ti_prog_ark3odloty;user=root", ServerVersion.Parse("10.4.22-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Odloty>(entity =>
            {
                entity.ToTable("odloty");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Czas)
                    .HasColumnType("time")
                    .HasColumnName("czas");

                entity.Property(e => e.Dzien).HasColumnName("dzien");

                entity.Property(e => e.Kierunek)
                    .HasMaxLength(10)
                    .HasColumnName("kierunek");

                entity.Property(e => e.NrRejsu)
                    .HasMaxLength(8)
                    .HasColumnName("nr_rejsu");

                entity.Property(e => e.SamolotyId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("samoloty_id");

                entity.Property(e => e.StatusLotu)
                    .HasColumnType("text")
                    .HasColumnName("status_lotu");
            });

            modelBuilder.Entity<Pozycja>(entity =>
            {
                entity.ToTable("pozycja");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Nazwa)
                    .HasColumnType("text")
                    .HasColumnName("nazwa");
            });

            modelBuilder.Entity<Przyloty>(entity =>
            {
                entity.ToTable("przyloty");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Czas)
                    .HasColumnType("time")
                    .HasColumnName("czas");

                entity.Property(e => e.Dzien).HasColumnName("dzien");

                entity.Property(e => e.Kierunek)
                    .HasMaxLength(10)
                    .HasColumnName("kierunek");

                entity.Property(e => e.NrRejsu)
                    .HasMaxLength(8)
                    .HasColumnName("nr_rejsu");

                entity.Property(e => e.SamolotyId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("samoloty_id");

                entity.Property(e => e.StatusLotu)
                    .HasColumnType("text")
                    .HasColumnName("status_lotu");
            });

            modelBuilder.Entity<Samoloty>(entity =>
            {
                entity.ToTable("samoloty");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Linie)
                    .HasMaxLength(10)
                    .HasColumnName("linie");

                entity.Property(e => e.Typ)
                    .HasMaxLength(20)
                    .HasColumnName("typ");
            });

            modelBuilder.Entity<Typy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("typy");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Kategoria)
                    .HasColumnType("text")
                    .HasColumnName("kategoria");
            });

            modelBuilder.Entity<Uslugi>(entity =>
            {
                entity.ToTable("uslugi");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.KadraId, "uslugi_FKIndex1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Cena).HasColumnName("cena");

                entity.Property(e => e.KadraId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("kadra_id");

                entity.Property(e => e.Nazwa)
                    .HasColumnType("text")
                    .HasColumnName("nazwa");

                entity.Property(e => e.Rodzaj)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rodzaj");
            });

            modelBuilder.Entity<Zdjecium>(entity =>
            {
                entity.ToTable("zdjecia");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.NazwaPliku)
                    .HasColumnType("text")
                    .HasColumnName("nazwaPliku");

                entity.Property(e => e.Podpis)
                    .HasColumnType("text")
                    .HasColumnName("podpis");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
