using System;
using System.Data.Entity;

namespace Boiler.Db.Contexts {
    public interface IDbContext : IDisposable {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}
