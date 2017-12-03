using AutoMapper;
using Boiler.Business.Dtos;
using Boiler.Business.Services;
using Boiler.Db;
using Boiler.Db.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Boiler.Business {
    public static class StartupExtensions {
        public static void AddBusinessServices(this IServiceCollection services, IConfiguration configuration) {
            services.AddTransient<IMapper>(provider => new MapperConfiguration(cfg => cfg.AddProfile<AutomapperProfile>()).CreateMapper());

            // TODO: define model-entity relation here
            services.AddBusinessService<Dto, DtoCreate, DtoUpdate, Entity>();

            services.AddTransient(typeof(IModelValidator<>), typeof(ModelValidator<>));
            services.AddDbServices(configuration);
        }

        private static void AddBusinessService<TModel, TCreateModel, TUpdateModel, TEntity>(this IServiceCollection services)
            where TModel : DtoBase
            where TCreateModel : DtoCreateBase
            where TUpdateModel : DtoUpdateBase
            where TEntity : class, IDbItem {
            services.AddTransient<IGetService<TModel>, GetService<TModel, TEntity>>();
            services.AddTransient<ICreateService<TModel,TCreateModel>, CreateService<TModel, TCreateModel, TEntity>>();
            services.AddTransient<IUpdateService<TModel, TUpdateModel>, UpdateService<TModel, TUpdateModel, TEntity>>();
            services.AddTransient<IPatchService<TModel, TUpdateModel>, PatchService<TModel, TUpdateModel, TEntity>>();
            services.AddTransient<IDeleteService<TModel>, DeleteService<TModel, TEntity>>();
        }
    }
}