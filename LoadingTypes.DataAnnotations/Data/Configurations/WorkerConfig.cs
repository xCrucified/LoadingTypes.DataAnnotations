using LoadingTypes.DataAnnotations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Data.Configurations
{
    public class WorkerConfig : IEntityTypeConfiguration<Workers>
        {
            public void Configure(EntityTypeBuilder<Workers> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.PhoneNumber).HasColumnName("Phone");
                builder.HasOne(x => x.Positions).WithMany(x => x.Workers).HasForeignKey(x => x.PositionId);
                builder.HasOne(x => x.Shops).WithMany(x => x.Workers).HasForeignKey(x => x.ShopId);
            }
        }
    
}
