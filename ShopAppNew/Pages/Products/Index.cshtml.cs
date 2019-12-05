using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShopAppNew.Data;
using ShopAppNew.Models;

namespace ShopAppNew.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly ShopAppNew.Data.ProductsContext _context;

        public IndexModel(ShopAppNew.Data.ProductsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Movies.ToListAsync();
        }
    }
}
