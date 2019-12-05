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
    public class DetailsModel : PageModel
    {
        private readonly ShopAppNew.Data.ProductsContext _context;

        public DetailsModel(ShopAppNew.Data.ProductsContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Movies.FirstOrDefaultAsync(m => m.id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
