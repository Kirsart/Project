using System;

namespace WhatToBuy.Models
{
    internal class Product
    {
        /// <summary>
        /// Идентификатор Продукта
        /// </summary>
        public Guid ProductID { get; set; }

        /// <summary>
        /// Наименование продукта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание продукта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Тип продукта
        /// </summary>
        public Guid ProductTypeID { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
