﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureProject.Data.Entities
{
    public class ProductCountry
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public ProductCountry()
        {
            Products = new HashSet<Product>();
        }
    }
}
