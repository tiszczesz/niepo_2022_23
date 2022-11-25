using Microsoft.EntityFrameworkCore;
using Ogloszenia2MVC.Models;

namespace Ogloszenia2MVC.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        { }
        public DbSet<Announcement> AllOgloszenia { get; set; }
        public DbSet<User> AllUzytkownicy { get; set; }
        public DbSet<Category> Kategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Announcement>(entity => { entity.ToTable("ogloszenie"); });
            modelBuilder.Entity<User>(entity => { entity.ToTable("uzytkownik"); });
            modelBuilder.Entity<Category>(entity => { entity.ToTable("kategorie"); });
            modelBuilder.Entity<Announcement>()
                .HasOne(o => o.User)
                .WithMany(u => u.Ogloszenias);
        }
    }
}
