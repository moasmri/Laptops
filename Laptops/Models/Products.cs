using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laptops.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Description")]
        public string ProductDesc { get; set; }
        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }
        [Display(Name = "Price")]
        public int ProductPrice { get; set; }
        [Display(Name = "Relas Deat")]
        public DateTime Relas_Deate { get; set; }
        [Display(Name = "Image")]
        public string Product_Image { get; set; }


        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }

        public Categorys Category { get; set; }
    }
}