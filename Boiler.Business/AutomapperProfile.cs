﻿using AutoMapper;
using Boiler.Business.Dtos;
using Boiler.Db.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;

namespace Boiler.Business {
    internal class AutomapperProfile : Profile {
        public AutomapperProfile() {
            CreateMap(typeof(JsonPatchDocument<>), typeof(JsonPatchDocument<>));
            CreateMap(typeof(Operation<>), typeof(Operation<>));

            CreateMap<Entity, Dto>();
            CreateMap<DtoCreate, Dto>();
            CreateMap<DtoUpdate, Dto>();
            CreateMap<Dto, Entity>().ForMember(e => e.Id, opt => opt.Ignore());
        }
    }
}
