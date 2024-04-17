using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDelayFinder.Data;
using DelayFinderAPI.Entities;

namespace AirportDelayFinder.Pages.AirlineCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDelayFinder.Data.ApplicationDbContext _context;

        public DetailsModel(AirportDelayFinder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Airline Airline { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airline = await _context.Airline.FirstOrDefaultAsync(m => m.AirlineID == id);
            if (airline == null)
            {
                return NotFound();
            }
            else
            {
                Airline = airline;
            }
            return Page();
        }
    }
}
