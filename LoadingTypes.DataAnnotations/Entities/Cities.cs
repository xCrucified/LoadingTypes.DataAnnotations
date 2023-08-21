using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Entities
{
    public class Cities
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Column("City")]
        public string Name { get; set; }
        [ForeignKey("Countries")]
        public int CountryId { get; set; }

        public ICollection<Shops> Shops { get; set; }
    }
}
