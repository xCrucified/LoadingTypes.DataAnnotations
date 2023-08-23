using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Entities
{
    public class Shops
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        [ForeignKey("Cities")]
        public int CityId { get; set; }
        public int? ParkingArea { get; set; }

        public Cities Cities { get; set; }

        public ICollection<Workers> Workers { get; set; }
    }
}
