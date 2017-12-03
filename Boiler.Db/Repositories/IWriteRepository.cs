using System.Collections.Generic;
using Boiler.Db.Entities;

namespace Boiler.Db.Repositories {
    public interface IWriteRepository<TEntity> where TEntity : class, IDbItem {
        TEntity Add(TEntity entity);
        IEnumerable<TEntity> AddMany(IEnumerable<TEntity> entities);
        TEntity Update(TEntity entity);
        IEnumerable<TEntity> UpdateMany(IEnumerable<TEntity> entities);
        TEntity Delete(long id);
        TEntity Delete(TEntity entity);
        IEnumerable<TEntity> DeleteMany(IEnumerable<long> ids);
        IEnumerable<TEntity> DeleteMany(IEnumerable<TEntity> entities);
        void SaveChanges();
    }
}