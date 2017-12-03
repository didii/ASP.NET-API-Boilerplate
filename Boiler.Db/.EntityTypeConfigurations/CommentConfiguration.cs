using System.Data.Entity.ModelConfiguration;
using Boiler.Db.EntityTypes;
using Boiler.Db.Extensions;

namespace Boiler.Db.EntityTypeConfigurations {
    internal class CommentConfiguration : EntityTypeConfiguration<Comment> {
        public CommentConfiguration() {
            this.ConfigureAll();

            Property(c => c.Message)
                .HasColumnName("Message")
                .IsRequired()
                .HasMaxLength(ConfigurationValues.DescriptionStringLength);
            HasOptional(c => c.Reply).WithOptionalPrincipal();
        }
    }
}
