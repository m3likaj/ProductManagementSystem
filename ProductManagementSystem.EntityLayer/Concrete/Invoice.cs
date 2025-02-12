using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.EntityLayer.Concrete
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        [Required]
        public List<Order> Orders { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }
    }
}
