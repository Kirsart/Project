using System.ComponentModel;

namespace WhatToBuy.Models
{
    internal enum ProductListStatusEnum
    {
        [Description("Активный")]
        Active,

        [Description("Удален")]
        Removed,

        [Description("Архивный")]
        Archive,

        [Description("Выполнен")]
        Solved
    }
}
