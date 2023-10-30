
using libreria_IESR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace libreria_IESR.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
       
    }
}
