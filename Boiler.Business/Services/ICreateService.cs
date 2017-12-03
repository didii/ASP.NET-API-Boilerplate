using Boiler.Business.Dtos;

namespace Boiler.Business.Services {
    public interface ICreateService<TModel, TCreateModel> where TModel: DtoBase where TCreateModel : DtoCreateBase {
        TModel Create(TCreateModel createModel);
    }
}