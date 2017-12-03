using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Boiler.Business.Dtos;
using Boiler.Business.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Boiler.Api.Controllers {
    public class DtoController : WriteController<Dto, DtoCreate, DtoUpdate> {
        /// <inheritdoc />
        public DtoController(IGetService<Dto> getService,
                             ICreateService<Dto, DtoCreate> createService,
                             IUpdateService<Dto, DtoUpdate> updateService,
                             IPatchService<Dto, DtoUpdate> patchService,
                             IDeleteService<Dto> deleteService) : base(getService, createService, updateService, patchService, deleteService) { }

        /// <summary>
        ///     Gets all the objects
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(typeof(Dto[]), (int)HttpStatusCode.OK)]
        public override IActionResult GetAll() {
            return base.GetAll();
        }

        /// <summary>
        ///     Gets a single object with id <paramref name="id" />
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(typeof(Dto), (int)HttpStatusCode.OK)]
        public override IActionResult Get(long id) {
            return base.Get(id);
        }

        /// <summary>
        ///     Creates a new object
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [ProducesResponseType(typeof(Dto), (int)HttpStatusCode.OK)]
        public override IActionResult Post([FromBody] DtoCreate dto) {
            return base.Post(dto);
        }

        /// <summary>
        ///     Updates an existing object with id <paramref name="id" />
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [ProducesResponseType(typeof(Dto), (int)HttpStatusCode.OK)]
        public override IActionResult Put(int id, [FromBody] DtoUpdate dto) {
            return base.Put(id, dto);
        }

        /// <summary>
        ///     Patches the object with id <paramref name="id" />
        /// </summary>
        /// <param name="id"></param>
        /// <param name="patch"></param>
        /// <returns></returns>
        [ProducesResponseType(typeof(Dto), (int)HttpStatusCode.OK)]
        public override IActionResult Patch(int id, [FromBody] JsonPatchDocument<DtoUpdate> patch) {
            return base.Patch(id, patch);
        }

        /// <summary>
        ///     Deletes the object with id <paramref name="id" />
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override IActionResult Delete(int id) {
            return base.Delete(id);
        }
    }
}