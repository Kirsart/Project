using Microsoft.EntityFrameworkCore;
using WhatToBuy.Models;

namespace WhatToBuy.Data
{
    public class WhatToBuyContext : DbContext
    {
        public WhatToBuyContext (DbContextOptions<WhatToBuyContext> options)
            : base(options)
        {
        }

        public DbSet<ProductList> ProductLists { get; set; }
    }
}
