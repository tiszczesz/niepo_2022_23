using Microsoft.EntityFrameworkCore;

namespace OgloszeniaMVCMysql.Models
{
    public class MyAppContext :DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options):base(options)
        {     }
        public DbSet<Ogloszenia> AllOgloszenia { get; set; }
        public DbSet<Uzytkownicy> AllUzytkownicy { get; set; }
        public DbSet<Kategorie> Kategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogloszenia>(entity => { entity.ToTable("ogloszenie"); });
            modelBuilder.Entity<Uzytkownicy>(entity => { entity.ToTable("uzytkownik"); });
            modelBuilder.Entity<Kategorie>(entity => { entity.ToTable("kategorie"); });
        }
    }
}
