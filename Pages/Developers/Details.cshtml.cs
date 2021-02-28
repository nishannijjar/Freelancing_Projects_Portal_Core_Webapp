using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Freelancing_Projects_Portal_Core_Webapp.BussinessLayer;
using Freelancing_Projects_Portal_Core_Webapp.Models;

namespace Freelancing_Projects_Portal_Core_Webapp.Pages.Developers
{
    public class DetailsModel : PageModel
    {
        private readonly Freelancing_Projects_Portal_Core_Webapp.Models.Freelancing_Projects_Portal_Context _context;

        public DetailsModel(Freelancing_Projects_Portal_Core_Webapp.Models.Freelancing_Projects_Portal_Context context)
        {
            _context = context;
        }

        public Developer Developer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Developer = await _context.Developer.FirstOrDefaultAsync(m => m.Id == id);

            if (Developer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
