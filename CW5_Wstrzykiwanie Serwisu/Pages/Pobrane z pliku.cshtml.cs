using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW5_Wstrzykiwanie_Serwisu.Models;
using CW5_Wstrzykiwanie_Serwisu.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CW5_Wstrzykiwanie_Serwisu.Pages
{
    public class Pobrane_z_plikuModel : PageModel
    {
        private readonly ILogger<Pobrane_z_plikuModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public Pobrane_z_plikuModel(JsonFileProductService productService, ILogger<Pobrane_z_plikuModel> logger)
        {
            ProductService = productService;
            _logger = logger;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}