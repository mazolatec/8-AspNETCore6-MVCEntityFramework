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

        public DbSet<MzWebApp.Models.Department> Department { get; set; } = default!;
    }
}
