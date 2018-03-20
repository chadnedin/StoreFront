using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StoreFront.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StoreFront.DAL
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext() : base ("StoreDbContext")
        {

        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<User> Users { get; set; }

        

        public DbSet<Address>Addresses { get; set; }

        public DbSet<ProductQty> ProductQtys { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}