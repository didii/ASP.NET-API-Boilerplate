using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boiler.Db.EntityTypes;
using Boiler.Db.Extensions;

namespace Boiler.Db.EntityTypeConfigurations {
    internal class ImageConfiguration : EntityTypeConfiguration<Image> {
        public ImageConfiguration() : base() {
            this.ConfigureAll();
            Property(i => i.ByteArray).HasColumnName("ByteArray").IsRequired().IsMaxLength();
            HasMany(i => i.Comments).WithOptional();
        }
    }
}
