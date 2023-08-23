using LoadingTypes.DataAnnotations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadingTypes.DataAnnotations.Data.Configurations
{
    public class ShopConfig : IEntityTypeConfiguration<Shops>
        {
            public void Configure(EntityTypeBuilder<Shops> builder)
            {
                builder.HasKey(x => x.Id);
                builder.HasOne(x => x.Cities).WithMany(x => x.Shops).HasForeignKey(x => x.CityId);
                builder.HasMany(x => x.Products).WithMany(x => x.Shops);
            }
        }
    
}
