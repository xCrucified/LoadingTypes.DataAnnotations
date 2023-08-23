using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        [ForeignKey("Categories")]
        public int? CategoryId { get; set; }
        public int Quantity { get; set; }
        [Column("Avaible")]
        public Boolean IsInStock { get; set; } = false;

        public Categories Categories { get; set; }
    }
}
