using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cruddemo.Models;

namespace cruddemo.Data
{
    public class cruddemoContext : DbContext
    {
        public cruddemoContext (DbContextOptions<cruddemoContext> options)
            : base(options)
        {
        }

        public DbSet<cruddemo.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<cruddemo.Models.Producto> Producto { get; set; }

        public DbSet<cruddemo.Models.Factura> Factura { get; set; }
    }
}
