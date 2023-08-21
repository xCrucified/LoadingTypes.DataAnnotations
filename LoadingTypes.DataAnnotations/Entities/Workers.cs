using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypes.DataAnnotations.Entities
{
    public class Workers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        [Column("Phone")]
        public string PhoneNumber { get; set; }
        [ForeignKey("Positions")]
        public int PositionId { get; set; }
        [ForeignKey("Shops")]
        public int ShopId { get; set; }
    }
}
