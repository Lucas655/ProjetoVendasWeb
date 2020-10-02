using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendasWebMvc.Models;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Data
{
    public class VendasWebMvcContext : DbContext
    {
        public VendasWebMvcContext (DbContextOptions<VendasWebMvcContext> options)
            : base(options)
        {
        }
        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
        
    }
}
