using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boiler.Db.Entities {
    public class Entity : IDbItem {
        /// <inheritdoc />
        public long Id { get; set; }

        public string Name { get; set; }

    }
}
