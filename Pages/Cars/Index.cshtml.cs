using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarDealerApp.Data;
using CarDealerApp.Models;

namespace CarDealerApp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly CarDealerApp.Data.CarDealerAppContext _context;

        public IndexModel(CarDealerApp.Data.CarDealerAppContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
