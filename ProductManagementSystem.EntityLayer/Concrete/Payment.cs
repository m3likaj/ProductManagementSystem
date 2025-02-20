using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.EntityLayer.Concrete
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public int InvoiceID { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int PaymentStatus  { get; set; }

        [Required]
        public int PaymentFormat { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
