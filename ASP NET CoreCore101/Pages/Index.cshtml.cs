﻿using ASP_NET_Core101.Website.Models;
using ASP_NET_Core101.Website.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_Core101.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product> Products { get; private set; }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
