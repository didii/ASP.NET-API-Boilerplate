using Boiler.Business.Dtos;

namespace Boiler.Business {
    public interface IModelValidator<TModel> where TModel : DtoBase {
        bool ValidateCreate { get; }
        bool ValidateUpdate { get; }
        bool ValidateDelete { get; }
        ValidationInfo ValidateForCreate(TModel model);
        ValidationInfo ValidateForUpdate(TModel prevModel, TModel newModel);
        ValidationInfo ValidateForDelete(TModel model);
    }
}
