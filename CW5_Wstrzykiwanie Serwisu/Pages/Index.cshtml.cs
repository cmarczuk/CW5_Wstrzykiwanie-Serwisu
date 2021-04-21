using CW5_Wstrzykiwanie_Serwisu.Models;
using CW5_Wstrzykiwanie_Serwisu.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW5_Wstrzykiwanie_Serwisu.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
        {
            ProductService = productService;
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}