using System;
using System.Collections.Generic;

namespace WhatToBuy.Models
{
    internal class ProductList
    {
        /// <summary>
        /// Идентификатор списка продуктов
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование списка продуктов
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime DateCreate { get; set; }

        /// <summary>
        /// Дата к котрой необходимо купить все элементы из списка
        /// </summary>
        public DateTime DateBuy { get; set; }

        /// <summary>
        /// Статус списка
        /// </summary>
        public ProductListStatusEnum Status { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Перечень всех элементов из списка
        /// </summary>
        public virtual ICollection<ProductListItem> ProductItems { get; set; }


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ProductList()
        {
            this.ProductItems = new List<ProductListItem>();
        }
    }
}
