using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Entities
{
    public class Categories
    {
        //[Key]
        public int Id { get; set; }
        //[MaxLength(60)]
        //[Required]
        //[Column("Category")]
        public string Name { get; set; }

        public ICollection<Products>? Products { get; set; }
    }
}
