using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Entities
{
    public class Countries
    {
        //[Key]
        public int Id { get; set; }
        //[Column("Country")]
        //[Required]
        public string Name { get; set; }
        //navigate
        public ICollection<Cities> Cities { get; set; }
    }
}
