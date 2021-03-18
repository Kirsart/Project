using System;

namespace WhatToBuyAPI.Models
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        public string Name { get; set; }

        public Guid ParentId { get; set; }

        public string Description { get; set; }

        public Guid ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }

    }
}
