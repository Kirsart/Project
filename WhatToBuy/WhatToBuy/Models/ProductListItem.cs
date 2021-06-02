using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhatToBuy.Models
{
    internal class ProductListItem
    {
        /// <summary>
        /// Идентификатор элемент списка продуктов
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Количество элемента списка продуктов
        /// </summary>
        public double Number { get; set; }

        /// <summary>
        /// Сосотояние элемента списка продуктов
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Стоимость приобретенного элемента списка продуктов
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        /// <summary>
        /// Идентификатор продукта, соответсвующий элементу списка продуктов
        /// </summary>
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
