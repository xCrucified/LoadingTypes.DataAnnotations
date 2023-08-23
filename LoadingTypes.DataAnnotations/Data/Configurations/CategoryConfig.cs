using LoadingTypes.DataAnnotations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadingTypes.DataAnnotations.Data.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Categories>
    {
            public void Configure(EntityTypeBuilder<Categories> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).HasMaxLength(50).IsRequired().HasColumnName("Category");
            }
        }
    
}
