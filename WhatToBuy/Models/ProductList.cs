using System;
using System.Collections.Generic;

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

        public virtual List<ProductItem> ProductItems { get; set; }

    }
}
