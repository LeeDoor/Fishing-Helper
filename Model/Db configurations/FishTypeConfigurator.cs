using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper.Model.Db_configurations
{
    public class FishTypeConfigurator : IEntityTypeConfiguration<FishType>
    {
        public void Configure(EntityTypeBuilder<FishType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => (int)x.Bait);
        }
    }
}
