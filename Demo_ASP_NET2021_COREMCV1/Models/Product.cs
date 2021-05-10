using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Demo_ASP_NET2021_COREMCV1.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please enter the product name.")]       
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the product price.")]
        [Range(.01, 500000000, ErrorMessage =
               "Price must be a positive number greater than zero.")]
        public decimal Price { get; set; }

        public string Slug => Name.Replace(' ', '-');

    }
}
