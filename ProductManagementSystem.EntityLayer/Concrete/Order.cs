using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.EntityLayer.Concrete
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public ICollection<Product> Products { get; set; } = new List<Product>();

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal TaxRate { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        //newly added
        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}
