using shikService.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using shikService.Infrastructure.Ef.Configurations;

namespace shikService.Infrastructure.Ef
{
    public class shikServiceDbContext : DbContext
    {
        public shikServiceDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<userEntity> userEntitys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new userEntityConfiguration());
            //modelBuilder.ApplyConfiguration(new userDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new actionEntityConfiguration());
        }
    }
}
