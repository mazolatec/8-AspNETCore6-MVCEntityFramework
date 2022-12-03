using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MzWebApp.Models;

namespace MzWebApp.Data
{
    public class MzWebAppContext : DbContext
    {
        public MzWebAppContext (DbContextOptions<MzWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecords { get; set; } = default!;
        public DbSet<Seller> Sellers { get; set; } = default!;

    }
}
