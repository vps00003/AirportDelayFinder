using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AirportDelayFinder.Data;
using DelayFinderAPI.Entities;

namespace AirportDelayFinder.Pages.AirlineCRUD
{
    public class EditModel : PageModel
    {
        private readonly AirportDelayFinder.Data.ApplicationDbContext _context;

        public EditModel(AirportDelayFinder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Airline Airline { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airline =  await _context.Airline.FirstOrDefaultAsync(m => m.AirlineID == id);
            if (airline == null)
            {
                return NotFound();
            }
            Airline = airline;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Airline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AirlineExists(Airline.AirlineID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AirlineExists(string id)
        {
            return _context.Airline.Any(e => e.AirlineID == id);
        }
    }
}
