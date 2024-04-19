using Microsoft.EntityFrameworkCore;
using PruebaBackend.Models;

namespace PruebaBackend.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
    }

}
