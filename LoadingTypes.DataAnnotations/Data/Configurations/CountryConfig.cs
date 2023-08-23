using LoadingTypes.DataAnnotations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadingTypes.DataAnnotations.Data.Configurations
{
    public class CountryConfig : IEntityTypeConfiguration<Countries>
    {
            public void Configure(EntityTypeBuilder<Countries> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).HasColumnName("Country").IsRequired();
            }
        }
    
}
