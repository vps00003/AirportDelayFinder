using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDelayFinder.Data;
using DelayFinderAPI.Entities;

namespace AirportDelayFinder.Pages.FlightCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDelayFinder.Data.ApplicationDbContext _context;

        public DetailsModel(AirportDelayFinder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Flight Flight { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flight.FirstOrDefaultAsync(m => m.FlightID == id);
            if (flight == null)
            {
                return NotFound();
            }
            else
            {
                Flight = flight;
            }
            return Page();
        }
    }
}
