using System;
using System.ComponentModel.DataAnnotations;

namespace WhatToBuyLibrary.Models
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        public Guid ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid ProductTypeID { get; set; }
        public virtual ProductType ProductType { get; set; }

    }

}
