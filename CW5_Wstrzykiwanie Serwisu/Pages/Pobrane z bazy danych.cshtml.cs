using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW5_Wstrzykiwanie_Serwisu.Data;
using CW5_Wstrzykiwanie_Serwisu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW5_Wstrzykiwanie_Serwisu.Pages
{
    public class Pobrane_z_bazy_danychModel : PageModel
    {
        private readonly ProductContext _context;
        public IList<Product> Products { get; set; }

        public Pobrane_z_bazy_danychModel(ProductContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            var ProductsQueary = (from Product in _context.Product select Product).Take(10);
            Products = ProductsQueary.ToList();
        }
    }
}