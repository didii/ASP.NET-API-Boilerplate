using System.ComponentModel.DataAnnotations;

namespace Boiler.Db.Entities {
    public interface IDbItem {
        /// <summary>
        /// The internal ID of this item
        /// </summary>
        [Key]
        long Id { get; set; }
    }
}
