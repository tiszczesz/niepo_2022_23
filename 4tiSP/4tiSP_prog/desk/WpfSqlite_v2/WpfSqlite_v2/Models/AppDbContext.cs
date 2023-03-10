using System.Configuration;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace WpfSqlite_v2.Models; 

public class AppDbContext :DbContext {
    private readonly string myConn;
    public AppDbContext() {
        myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
    }

    public DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite(myConn);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Game>().HasData(
            new Game{Id = 1,Title = "Wiedźmin",Price = 34.89m,Genre = "RPG"},
            new Game{Id = 2,Title = "Wiedźmin 2",Price = 34.89m, Genre = "RPG" },
            new Game{Id = 3,Title = "GTA V",Price = 34.89m,Genre="FPS"},
            new Game{Id = 4,Title = "Diablo III",Price = 34.89m, Genre = "RPG" },
            new Game{Id = 5,Title = "Diablo IV",Price = 34.89m, Genre = "RPG" }
            );
    }
}

public class Game {
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Genre { get; set; }
    public decimal? Price { get; set; }
}