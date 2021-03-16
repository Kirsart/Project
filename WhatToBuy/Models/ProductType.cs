using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToBuy.Models
{
    /// <summary>
    /// Тип продукта
    /// </summary>
    public class ProductType
    {
        [Required]
        public Guid ProductTypeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid ParentId { get; set; }
    }
}
