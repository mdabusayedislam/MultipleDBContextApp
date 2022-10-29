using Microsoft.EntityFrameworkCore;

namespace MultipleDBContextApp.Data
{
    public class DbTwoContext:BaseContext
    {
        public DbTwoContext(DbContextOptions<DbTwoContext> options) : base(options)
        {

        }
    }
}
