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
    public class IndexModel : PageModel
    {
        private readonly AirportDelayFinder.Data.ApplicationDbContext _context;

        public IndexModel(AirportDelayFinder.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Airline> Airline { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Airline = await _context.Airline.ToListAsync();
        }
    }
}
