using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper.Model.Db_configurations
{
    public class FishConfigurator : IEntityTypeConfiguration<Fish>
    {
        public void Configure(EntityTypeBuilder<Fish> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Path);
            builder.Property(x => x.Type);
            builder.HasOne(x => x.Location).WithOne(x => x.Fish).HasForeignKey<Fish>(x => x.LocationId);
            builder.HasOne(x => x.Price).WithMany(x => x.Fishes).HasForeignKey(x => x.PriceId);
            builder.HasOne(x => x.FishType).WithMany(x => x.Variations).HasForeignKey(x => x.FishTypeId);
        }
    }
}
