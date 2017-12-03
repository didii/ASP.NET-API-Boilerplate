using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boiler.Db.EntityTypes;
using Boiler.Db.Extensions;

namespace Boiler.Db.EntityTypeConfigurations
{
    internal class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration() {
            this.ConfigureIDbItem();
            Property(r => r.Name).HasColumnName("Name").IsRequired();
        }
    }
}
