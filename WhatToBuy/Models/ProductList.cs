using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToBuy.Models
{
    public class ProductList
    {
        [Required]
        public Guid ProductListId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }

        [Required]
        public DateTime DateBuy { get; set; }

        [Required]
        public ProductListStatusEnum Status { get; set; }

        public string Notes { get; set; }
    }
}
