using System.Data.Entity;

namespace Boiler.Db.Contexts {
    internal class ContextInitializer : CreateDatabaseIfNotExists<Context> {
        /// <inheritdoc />
        protected override void Seed(Context context) {
            base.Seed(context);
        }
    }
}