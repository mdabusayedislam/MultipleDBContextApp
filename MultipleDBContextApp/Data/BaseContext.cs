using Microsoft.EntityFrameworkCore;
using MultipleDBContextApp.Models;

namespace MultipleDBContextApp.Data
{
    public class BaseContext:DbContext
    {
        public BaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
