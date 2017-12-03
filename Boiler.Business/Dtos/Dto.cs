using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boiler.Business.Dtos {
    public class Dto : DtoBase {
        public string Name { get; set; }
    }

    public class DtoCreate : DtoCreateBase {
        [Required]
        public string Name { get; set; }
    }

    public class DtoUpdate : DtoUpdateBase {
        [Required]
        public string Name { get; set; }
    }
}