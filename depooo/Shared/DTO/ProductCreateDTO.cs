using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depooo.Shared.DTO
{
    public class ProductCreateDTO
    {
        [Required(ErrorMessage ="Product Name Can not be empty")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Product Price Can not be empty")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Product Description Can not be empty")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Product Quantity Can not be empty")]
        public double Quantity { get; set; }
    }
}
