﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductShop.Models
{
    public class Product
    {
        public Product()
        {
            this.CategoryProducts = new HashSet<CategoryProduct>();
        }

        public int ProductId { get; set; }

        [MinLength(3)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? BuyerId { get; set; }
        public virtual User Buyer { get; set; }

        public int SellerId { get; set; }
        public virtual User Seller { get; set; }

        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}
