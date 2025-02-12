using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.EntityLayer.Concrete
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(150)]
        [Required]
        public string Address { get; set; }

        [StringLength(10)]
        [Required]
        public string PhoneNumber { get; set; }

    }
}
