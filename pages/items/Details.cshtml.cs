using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;
using Ecommerce.Models;

namespace Ecommerce.pages.items
{
    public class DetailsModel : PageModel
    {
        private readonly Ecommerce.Data.EcommerceContext _context;

        public DetailsModel(Ecommerce.Data.EcommerceContext context)
        {
            _context = context;
        }

        public General_item_layout General_item_layout { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var general_item_layout = await _context.General_item_layout.FirstOrDefaultAsync(m => m.Id == id);
            if (general_item_layout == null)
            {
                return NotFound();
            }
            else
            {
                General_item_layout = general_item_layout;
            }
            return Page();
        }
    }
}
