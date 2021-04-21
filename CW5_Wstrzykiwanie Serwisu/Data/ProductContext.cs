using CW5_Wstrzykiwanie_Serwisu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW5_Wstrzykiwanie_Serwisu.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}