using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boiler.Db.EntityTypes;
using Boiler.Db.Extensions;

namespace Boiler.Db.EntityTypeConfigurations {
    internal class TagCategoryConfiguration : EntityTypeConfiguration<TagCategory> {
        public TagCategoryConfiguration() {
            this.ConfigureAll();

            Property(tc => tc.Name).HasColumnName("NAme").IsRequired();
        }
    }
}