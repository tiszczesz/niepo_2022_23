using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ark2_pomMVC.Data;

public partial class _3tiProgBazaContext : DbContext
{
    public _3tiProgBazaContext()
    {
    }

    public _3tiProgBazaContext(DbContextOptions<_3tiProgBazaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Klienci> Kliencis { get; set; }

    public virtual DbSet<Opinie> Opinies { get; set; }

    public virtual DbSet<Typy> Typies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=3ti_prog_baza;user=root", ServerVersion.Parse("10.4.22-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_polish_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Klienci>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("klienci")
                .UseCollation("utf8_unicode_ci");

            entity.HasIndex(e => e.TypyId, "klienci_typy");

            entity.Property(e => e.Id)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Imie)
                .HasColumnType("text")
                .HasColumnName("imie");
            entity.Property(e => e.Nazwisko)
                .HasColumnType("text")
                .HasColumnName("nazwisko");
            entity.Property(e => e.Punkty)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("punkty");
            entity.Property(e => e.TypyId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("Typy_id");
            entity.Property(e => e.Zdjecie)
                .HasMaxLength(20)
                .HasColumnName("zdjecie");

            entity.HasOne(d => d.Typy).WithMany(p => p.Kliencis)
                .HasForeignKey(d => d.TypyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("klienci_typy");
        });

        modelBuilder.Entity<Opinie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("opinie")
                .UseCollation("utf8_unicode_ci");

            entity.HasIndex(e => e.KlienciId, "opinia_klient");

            entity.Property(e => e.Id)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.KlienciId)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("Klienci_id");
            entity.Property(e => e.Ocena)
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("ocena");
            entity.Property(e => e.Opinia)
                .HasColumnType("text")
                .HasColumnName("opinia");

            entity.HasOne(d => d.Klienci).WithMany(p => p.Opinies)
                .HasForeignKey(d => d.KlienciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("opinia_klient");
        });

        modelBuilder.Entity<Typy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("typy")
                .UseCollation("utf8_unicode_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(10)
                .HasColumnName("nazwa");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
