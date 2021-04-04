using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WhatToBuyAPI.Models
{
    /// <summary>
    /// Тип продукта
    /// </summary>
    public class ProductType
    {
        public Guid ProductTypeId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ProductType> ProductTypes { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ProductType()
        {
            this.ProductTypes = new List<ProductType>();
        }
    }
}
