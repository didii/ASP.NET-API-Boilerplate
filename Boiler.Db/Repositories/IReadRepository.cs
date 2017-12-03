using System.Collections.Generic;
using Boiler.Db.Entities;

namespace Boiler.Db.Repositories {
    public interface IReadRepository<TEntity> where TEntity : class, IDbItem {
        TEntity Get(long id);
        IEnumerable<TEntity> GetAll();
    }
}
