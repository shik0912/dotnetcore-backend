using shikService.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace shikService.Infrastructure.Ef.Configurations
{
    public class userEntityConfiguration : IEntityTypeConfiguration<userEntity>
    {
        public void Configure(EntityTypeBuilder<userEntity> builder)
        {
            builder.HasKey(o => o.Id);
            builder.OwnsOne(
                o => o.Detail,
                dung =>
                {
                    dung.Property(o => o.Name);
                    dung.Property(o => o.Address);
                });
        }
    }
}