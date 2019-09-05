using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shikService.Infrastructure.Model;

namespace shikService.Infrastructure.Ef.Configurations
{
    public class actionEntityConfiguration : IEntityTypeConfiguration<actionEntity>
    {
        public void Configure(EntityTypeBuilder<actionEntity> builder)
        {
            //builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedOnAdd();
        }
    }
}
