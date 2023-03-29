using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Arretadinhos.Models;

namespace Arretadinhos.Data
{
    public class ArretadinhosContext : DbContext
    {
        public ArretadinhosContext (DbContextOptions<ArretadinhosContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        //  = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
