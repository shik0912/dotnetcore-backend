using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shikService.Infrastructure.Model;

namespace shikService.Infrastructure.Ef.Configurations
{
    public class userDetailEntityConfiguration : IEntityTypeConfiguration<userDetailEntity>
    {
        public void Configure(EntityTypeBuilder<userDetailEntity> builder)
        {
            builder.HasKey(o => o.Name);
            builder.Property(o => o.Address);
        }
    }
}
