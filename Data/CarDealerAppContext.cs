using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarDealerApp.Models;

namespace CarDealerApp.Data
{
    public class CarDealerAppContext : DbContext
    {
        public CarDealerAppContext (DbContextOptions<CarDealerAppContext> options)
            : base(options)
        {
        }

        public DbSet<CarDealerApp.Models.Car> Car { get; set; } = default!;
    }
}
