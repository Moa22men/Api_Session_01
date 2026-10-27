using DominLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Presention.Data.Contexts
{

    public class StoreDbContext : DbContext
    {

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options);

        public DbSet<Product> Products { get; set; }

        public DbSet<ProudctBrand> ProductBrand { get; set; }

        public DbSet<ProudctType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration/*<Product>*/(new ProductConfigurations());
            //modelBuilder.ApplyConfigurations FromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);
        }
    
    }
}
