using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToBuyLibrary.Models
{
    /// <summary>
    /// Элемент списка продуктов
    /// </summary>
    public class ProductItem
    {
        public Guid ProductItemId { get; set; }

        public double Number { get; set; }

        public bool Done { get; set; }

        public string Notes { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
