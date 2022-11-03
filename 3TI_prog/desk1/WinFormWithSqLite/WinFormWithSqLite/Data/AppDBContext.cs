using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormWithSqLite.Models;

namespace WinFormWithSqLite.Data
{
    public class AppDBContext : DbContext
    {
        private readonly string connString = 
            ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString;

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(connString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category{CategoryId = 1,Name = "Nabiał"},
                new Category{CategoryId = 2,Name = "Słodycze"},
                new Category{CategoryId = 3,Name = "AGD"},
                new Category{CategoryId = 4,Name = "Napoje"}
            );
            modelBuilder.Entity<Product>().HasData(
                new Product{ProductId = 1,CategoryId = 1,Name = "Ser tłusty"},
                new Product{ProductId = 2,CategoryId = 1,Name = "Ser chudy"},
                new Product{ProductId = 3,CategoryId = 1,Name = "Ser żółty"},
                new Product{ProductId = 4,CategoryId = 2,Name = "krówki polskie"},
                new Product{ProductId = 5,CategoryId = 2,Name = "Czekolada mleczna"},
                new Product{ProductId = 6,CategoryId = 2,Name = "Landrynki małe"},
                new Product{ProductId = 7,CategoryId = 3,Name = "Proszek do ...."},
                new Product{ProductId = 8,CategoryId = 3,Name = "Płyn do płukania"},
                new Product{ProductId = 9,CategoryId = 3,Name = "Papier toaletowy"},
                new Product{ProductId = 10,CategoryId = 4,Name = "Coca-Cola"},
                new Product{ProductId = 11,CategoryId = 4,Name = "Pepsi-Cola"},
                new Product{ProductId = 12,CategoryId = 4,Name = "Mirinda"},
                new Product{ProductId = 13,CategoryId = 4,Name = "Oranżada polska"},
                new Product{ProductId = 14,CategoryId = 4,Name = "Napój gazowany"}
                );
        }
    }
}
