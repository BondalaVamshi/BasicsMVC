using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ModelDataToController.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
    public class ProductModelDBContext : DbContext
    {
        public DbSet<ProductModel> ProductModels { get; set; }
    }
}