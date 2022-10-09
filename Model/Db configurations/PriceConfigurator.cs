using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper.Model.Db_configurations
{
    public class PriceConfigurator : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.RawReg);
            builder.Property(x=>x.RawTroph);
            builder.Property(x=>x.СookReg);
            builder.Property(x=>x.CookTroph);
        }
    }
}
