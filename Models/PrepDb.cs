using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingMicroservice.Models
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<CatContext>());
            }

        }

        public static void SeedData(CatContext context)
        {
            System.Console.WriteLine("Appling Migrations...");

            context.Database.Migrate();

            Booking booking = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = Guid.NewGuid(),
                CatsAmount = 2,
                CCTV = true,
                Customer = Guid.NewGuid(),
                EndDate = DateTime.Now.AddDays(15),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = Guid.NewGuid(),
                UserId = "system"

            };

            Booking booking1 = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = Guid.NewGuid(),
                CatsAmount = 2,
                CCTV = true,
                Customer = Guid.NewGuid(),
                EndDate = DateTime.Now.AddDays(10),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = Guid.NewGuid(),
                UserId = "system"

            };

            Booking booking2 = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = Guid.NewGuid(),
                CatsAmount = 2,
                CCTV = true,
                Customer = Guid.NewGuid(),
                EndDate = DateTime.Now.AddDays(12),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = Guid.NewGuid(),
                UserId = "system"

            };

            Booking booking3 = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = Guid.NewGuid(),
                CatsAmount = 2,
                CCTV = true,
                Customer = Guid.NewGuid(),
                EndDate = DateTime.Now.AddDays(16),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = Guid.NewGuid(),
                UserId = "system"

            };

            Booking booking4 = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = Guid.NewGuid(),
                CatsAmount = 2,
                CCTV = true,
                Customer = Guid.NewGuid(),
                EndDate = DateTime.Now.AddDays(19),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = Guid.NewGuid(),
                UserId = "system"

            };
            if (!context.Bookings.Any())
            {
                System.Console.WriteLine("Seeding Bookings Data...");
                context.Bookings.AddRange(booking, booking1, booking2, booking3, booking4);

                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data Bookings - not seeding");
            }
        }

        }
}
