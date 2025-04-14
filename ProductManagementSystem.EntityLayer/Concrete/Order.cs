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
        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();      

        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public string OrderStatus { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
