using Microsoft.EntityFrameworkCore;

namespace Footprint.Infrastructure.Ef
{
    public class shikServiceDbContext : DbContext
    {
        public shikServiceDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
