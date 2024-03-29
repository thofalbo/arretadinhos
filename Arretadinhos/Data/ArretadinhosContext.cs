﻿namespace Arretadinhos.Models
{
    public class ArretadinhosContext : DbContext
    {
        public ArretadinhosContext (DbContextOptions<ArretadinhosContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
