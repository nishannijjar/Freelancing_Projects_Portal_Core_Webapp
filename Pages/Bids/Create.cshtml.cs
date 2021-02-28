using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Freelancing_Projects_Portal_Core_Webapp.BussinessLayer;
using Freelancing_Projects_Portal_Core_Webapp.Models;

namespace Freelancing_Projects_Portal_Core_Webapp.Pages.Bids
{
    public class CreateModel : PageModel
    {
        private readonly Freelancing_Projects_Portal_Core_Webapp.Models.Freelancing_Projects_Portal_Context _context;

        public CreateModel(Freelancing_Projects_Portal_Core_Webapp.Models.Freelancing_Projects_Portal_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DeveloperId"] = new SelectList(_context.Set<Developer>(), "Id", "Name");
        ViewData["ProjectId"] = new SelectList(_context.Set<Project>(), "Id", "ProjectTitle");
            return Page();
        }

        [BindProperty]
        public Bid Bid { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bid.Add(Bid);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
