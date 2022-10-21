using Microsoft.EntityFrameworkCore;
using WebMysql_cw1.Models;

namespace WebMysql_cw1.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options) 
        {
                
        }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("books");
            });
        }

    }
}
