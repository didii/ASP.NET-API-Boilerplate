using Boiler.Business.Dtos;

namespace Boiler.Business.Services {
    public interface IDeleteService<TModel> where TModel : DtoBase {
        TModel Delete(long id);
    }
}
