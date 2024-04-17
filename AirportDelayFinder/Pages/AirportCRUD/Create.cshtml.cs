using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AirportDelayFinder.Data;
using DelayFinderAPI.Entities;

namespace AirportDelayFinder.Pages.AirportCRUD
{
    public class CreateModel : PageModel
    {
        private readonly AirportDelayFinder.Data.ApplicationDbContext _context;

        public CreateModel(AirportDelayFinder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Airport Airport { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Airport.Add(Airport);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
