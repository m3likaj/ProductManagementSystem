using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        [StringLength(300)]
        [Required]
        public string Description { get; set; } //nvarchar 300

        [Required]
        public int CategoryId { get; set; }
        public int? BrandId { get; set; } // nullable
        virtual public Category Category { get; set; }
        virtual public Brand Brand { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
