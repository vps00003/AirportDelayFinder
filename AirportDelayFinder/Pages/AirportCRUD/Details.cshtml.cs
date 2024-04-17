using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDelayFinder.Data;
using DelayFinderAPI.Entities;

namespace AirportDelayFinder.Pages.AirportCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDelayFinder.Data.ApplicationDbContext _context;

        public DetailsModel(AirportDelayFinder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Airport Airport { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airport = await _context.Airport.FirstOrDefaultAsync(m => m.AirportID == id);
            if (airport == null)
            {
                return NotFound();
            }
            else
            {
                Airport = airport;
            }
            return Page();
        }
    }
}
