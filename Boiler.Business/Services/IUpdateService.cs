using Boiler.Business.Dtos;

namespace Boiler.Business.Services {
    public interface IUpdateService<TModel, TUpdateModel> where TModel : DtoBase where TUpdateModel : DtoUpdateBase {
        TModel Update(long id, TUpdateModel newModel);
    }
}
