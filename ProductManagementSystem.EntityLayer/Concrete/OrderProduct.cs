using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.EntityLayer.Concrete
{
    public class OrderProduct
    {
        public int OrderProductID { get; set; }

        [Required]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

        [Required]
        public int Quantity { get; set; }

        
    }
}
