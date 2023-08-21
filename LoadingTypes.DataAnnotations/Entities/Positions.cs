using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Entities
{
    public class Positions
    {
        public int Id { get; set; }
        [Column("Position")]
        public string Name { get; set; }

        public ICollection<Workers> Workers { get; set; }
    }
}
