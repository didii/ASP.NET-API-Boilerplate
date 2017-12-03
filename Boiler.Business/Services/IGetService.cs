using System.Collections.Generic;
using Boiler.Business.Dtos;

namespace Boiler.Business.Services {
    public interface IGetService<out TModel> where TModel : DtoBase {
        TModel Get(long id);
        IEnumerable<TModel> GetAll();
    }
}