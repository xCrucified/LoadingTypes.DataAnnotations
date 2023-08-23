using LoadingTypes.DataAnnotations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadingTypes.DataAnnotations.Data.Configurations
{
    public class CityConfig : IEntityTypeConfiguration<Cities>
    {
            public void Configure(EntityTypeBuilder<Cities> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).HasMaxLength(100).HasColumnName("City").IsRequired();
                builder.HasOne(x => x.Countries).WithMany(x => x.Cities).HasForeignKey(x => x.CountryId);
            }
        }
    
}
