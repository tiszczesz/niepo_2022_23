using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebPortal_v1.Models
{
    public partial class PortalContext_3ti : DbContext
    {
        public PortalContext_3ti()
        {
        }

        public PortalContext_3ti(DbContextOptions<PortalContext_3ti> options)
            : base(options)
        {
        }

        public virtual DbSet<Dane> Danes { get; set; } = null!;
        public virtual DbSet<Uzytkownicy> Uzytkownicies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=3ti_portal;user=root", ServerVersion.Parse("10.4.22-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_polish_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Dane>(entity =>
            {
                entity.ToTable("dane");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Hobby)
                    .HasMaxLength(20)
                    .HasColumnName("hobby");

                entity.Property(e => e.Przyjaciol)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("przyjaciol");

                entity.Property(e => e.RokUrodz)
                    .HasColumnType("year(4)")
                    .HasColumnName("rok_urodz");

                entity.Property(e => e.Zdjecie)
                    .HasMaxLength(100)
                    .HasColumnName("zdjecie");
            });

            modelBuilder.Entity<Uzytkownicy>(entity =>
            {
                entity.ToTable("uzytkownicy");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Haslo)
                    .HasMaxLength(50)
                    .HasColumnName("haslo");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .HasColumnName("login");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
