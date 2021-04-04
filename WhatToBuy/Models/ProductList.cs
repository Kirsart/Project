using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WhatToBuyAPI.Models
{
    public class ProductList
    {
        public Guid ProductListId { get; set; }

        public string Name { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime DateBuy { get; set; }

        public ProductListStatusEnum Status { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<ProductItem> ProductItems { get; set; }


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ProductList()
        {
            this.ProductItems = new List<ProductItem>();
        }
    }
}
