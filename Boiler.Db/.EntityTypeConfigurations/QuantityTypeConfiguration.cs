using System.Data.Entity.ModelConfiguration;
using Boiler.Db.EntityTypes;
using Boiler.Db.Extensions;

namespace Boiler.Db.EntityTypeConfigurations {
    internal class QuantityTypeConfiguration : EntityTypeConfiguration<QuantityType> {
        public QuantityTypeConfiguration() {
            this.ConfigureAll();

            Property(qt => qt.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(ConfigurationValues.NameStringLength);
        }
    }
}