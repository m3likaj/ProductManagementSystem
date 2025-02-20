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

        
        public int? BrandId { get; set; } // nullable

        public decimal? TaxRate { get; set; }//nullable
        public virtual Brand Brand { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    }
}
