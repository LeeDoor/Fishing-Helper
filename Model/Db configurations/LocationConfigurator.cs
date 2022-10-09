using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper.Model.Db_configurations
{
    internal class LocationConfigurator : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(n=>n.Id);
            builder.Property(n=>n.X);
            builder.Property(n=>n.Y);
            builder.Property(n=>n.Width);
            builder.Property(n=>n.Height);
        }
    }
}
