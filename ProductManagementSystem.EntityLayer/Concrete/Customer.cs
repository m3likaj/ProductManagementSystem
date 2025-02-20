using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        [Index(nameof(Email), IsUnique = true)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        [Index(nameof(PhoneNumber), IsUnique = true)]
        public string PhoneNumber { get; set; }
        
        [Required]
        [StringLength(150)]
        public string Address { get; set; }

    }
}
