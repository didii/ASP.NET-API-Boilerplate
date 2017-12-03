using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boiler.Db.EntityTypes;
using Boiler.Db.Extensions;

namespace Boiler.Db.EntityTypeConfigurations {
    internal class QuantityConfiguration : EntityTypeConfiguration<Quantity> {
        public QuantityConfiguration() {
            this.ConfigureAll();

            Property(q => q.Name).HasColumnName("Name").IsRequired().HasMaxLength(ConfigurationValues.NameStringLength);
            Property(q => q.ShortName).HasColumnName("ShortName").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(q => q.Multiplier).HasColumnName("Multiplier").IsRequired();
            HasRequired(q => q.QuantityType).WithRequiredDependent();
        }
    }
}
