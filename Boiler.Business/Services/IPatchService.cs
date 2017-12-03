using Boiler.Business.Dtos;
using Microsoft.AspNetCore.JsonPatch;

namespace Boiler.Business.Services {
    public interface IPatchService<TModel, TUpdateModel> where TModel : DtoBase where TUpdateModel : DtoUpdateBase {
        TModel Patch(int id, JsonPatchDocument<TUpdateModel> updateDocument);
    }
}

