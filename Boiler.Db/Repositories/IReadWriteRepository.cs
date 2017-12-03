using Boiler.Db.Entities;

namespace Boiler.Db.Repositories {
    public interface IReadWriteRepository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity>
        where TEntity : class, IDbItem { }
}