using LoadingTypes.DataAnnotations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadingTypes.DataAnnotations.Data.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Products>
    {
            public void Configure(EntityTypeBuilder<Products> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).HasColumnName("Product");
                builder.HasOne(x => x.Categories).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
                builder.Property(x => x.IsInStock).HasColumnName("Avaible");
                builder.HasMany(x => x.Shops).WithMany(x => x.Products);
            }
        }
    
}
