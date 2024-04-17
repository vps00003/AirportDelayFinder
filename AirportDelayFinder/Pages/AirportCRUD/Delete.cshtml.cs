﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly AirportDelayFinder.Data.ApplicationDbContext _context;

        public DeleteModel(AirportDelayFinder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airport = await _context.Airport.FindAsync(id);
            if (airport != null)
            {
                Airport = airport;
                _context.Airport.Remove(Airport);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
