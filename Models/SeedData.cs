using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using CarDealerApp.Data;


namespace CarDealerApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarDealerAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CarDealerAppContext>>()))
            {
                if (context == null || context.Car == null)
                {
                    throw new ArgumentNullException("CarDealerAppContext");
                }
                // Look for any cars
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        Make = "Toyota",
                        Model = "Corolla",
                        Year = 2020,
                        Price = 20000m,
                        ImageUrl = ""
                    },
                    new Car
                    {
                        Make = "Nissan",
                        Model = "Altima",
                        Year = 2018,
                        Price = 18000m,
                        ImageUrl = ""
                    },
                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Camaro",
                        Year = 2022,
                        Price = 40000m,
                        ImageUrl = ""
                    },
                    new Car
                    {
                        Make = "BMW",
                        Model = "3 Series",
                        Year = 2020,
                        Price = 35000m,
                        ImageUrl = ""
                    },
                    new Car
                    {
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2019,
                        Price = 35000m,
                        ImageUrl = ""
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
