using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToBuy.Models
{
    /// <summary>
    /// Элемент списка продуктов
    /// </summary>
    public class ProductItem
    {
        [Required]
        public Guid ProductItemId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Number { get; set; }

        public bool Done { get; set; }

        public string Notes { get; set; }

        public decimal Price { get; set; }
    }
}
