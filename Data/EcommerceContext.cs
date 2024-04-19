using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext (DbContextOptions<EcommerceContext> options)
            : base(options)
        {
        }

        public DbSet<Ecommerce.Models.General_item_layout> General_item_layout { get; set; } = default!;
    }
}
