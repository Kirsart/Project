using System;

namespace WhatToBuyAPI.Models
{
    /// <summary>
    /// Тип продукта
    /// </summary>
    public class ProductType
    {
        public Guid ProductTypeId { get; set; }

        public string Name { get; set; }

        public Guid ParentId { get; set; }
    }
}
