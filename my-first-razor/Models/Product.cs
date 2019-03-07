using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace my_first_razor.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required()]
        public string Name { get; set; }
        [Range(minimum:0,maximum:100)]
        public int Qty { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}