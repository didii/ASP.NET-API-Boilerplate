using System;
using System.Collections.Generic;
using AutoMapper;
using Boiler.Business.Dtos;
using Boiler.Db.Entities;
using Boiler.Db.Repositories;

namespace Boiler.Business.Services {
    internal class GetService<TModel, TEntity> : IGetService<TModel> where TModel : DtoBase where TEntity : class, IDbItem {
        private readonly IMapper _mapper;
        private readonly IReadRepository<TEntity> _readRepository;

        public GetService(IMapper mapper, IReadRepository<TEntity> readRepository) {
            _mapper = mapper;
            _readRepository = readRepository;
        }

        /// <inheritdoc />
        public TModel Get(long id) {
            var entity = _readRepository.Get(id);
            if (entity == null)
                throw new NotImplementedException("Entity does not exist");

            var model = _mapper.Map<TModel>(entity);
            return model;
        }

        /// <inheritdoc />
        public IEnumerable<TModel> GetAll() {
            var entities = _readRepository.GetAll();
            var models = _mapper.Map<IEnumerable<TModel>>(entities);
            return models;
        }
    }
}