using Microsoft.EntityFrameworkCore;

namespace MultipleDBContextApp.Data
{
    public class DbOneContext:BaseContext
    {
        public DbOneContext(DbContextOptions<DbOneContext> options) : base(options)
        {

        }
    }
}
