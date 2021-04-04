using Microsoft.EntityFrameworkCore;
using WhatToBuyLibrary.Models;

namespace WhatToBuyAPI.Data
{
    public class WhatToBuyAPIContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public DbSet<ProductList> ProductList { get; set; }

        public DbSet<ProductItem> ProductItem { get; set; }

        public DbSet<ProductType> ProductType { get; set; }


        public WhatToBuyAPIContext()
        {
            Database.EnsureCreated();
        }

        public WhatToBuyAPIContext(DbContextOptions<WhatToBuyAPIContext> options)
            : base(options)
        {
        }
    }
}
