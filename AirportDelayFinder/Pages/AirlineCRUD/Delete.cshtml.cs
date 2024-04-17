﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly AirportDelayFinder.Data.ApplicationDbContext _context;

        public DeleteModel(AirportDelayFinder.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airline = await _context.Airline.FindAsync(id);
            if (airline != null)
            {
                Airline = airline;
                _context.Airline.Remove(Airline);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
