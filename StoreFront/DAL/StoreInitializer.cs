using StoreFront.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoreFront.DAL
{
    public class StoreInitializer : DropCreateDatabaseIfModelChanges<StoreDbContext>
    {
        protected override void Seed(StoreDbContext context)
        {
            var products = new List<Product>
            {
     
            };
          

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}