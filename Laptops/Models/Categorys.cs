using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laptops.Models
{
    public class Categorys
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Category Name ")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "Category Description")]
        public string CategoryDesc { get; set; }

        public virtual ICollection<Products> product { get; set; }
    }
}