using LoadingTypes.DataAnnotations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoadingTypes.DataAnnotations.Data.Configurations
{
    public class PositionConfig : IEntityTypeConfiguration<Positions>
    {
            public void Configure(EntityTypeBuilder<Positions> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).HasColumnName("Position");
            }
        }
    
}
