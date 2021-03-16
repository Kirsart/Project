using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToBuy.Models
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        [Required]
        public Guid ProductId { get; set; }

        [Required]
        public Guid ProductTypeId { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid ParentId { get; set; }

        public string Description { get; set; }

    }
}
