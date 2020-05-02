using BookingMicroservice.Manager;
using BookingMicroservice.Models;
using BookingMicroservice.Validators;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingMicroservice.Controllers
{
    public class BookingController : ControllerBase
    {
        private readonly BookingManager bookingManager;
        private readonly CatContext _context;
        private readonly BookingValidator validator = new BookingValidator();

        public BookingController(CatContext context)
        {
            _context = context;
            bookingManager = new BookingManager(_context);


        }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Booking> Index()
        {
            System.Console.WriteLine("Index");
            return bookingManager.GetAllBookings();
        }

        // POST: Booking/Create
        [HttpPost]
        [Route("Api/Booking/MakeBooking")]
        public ActionResult Create(Guid cat, Guid customer, Guid users, Guid room, DateTime startDate, DateTime endDate, string notes)
        {




            Booking booking = new Booking()
            {
                Cats = cat,
                Customer = customer,
                Room = room,
                StartDate = startDate,
                EndDate = endDate,
                Notes = notes,
                CCTV = true,
                BookingMade = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                Price = 5,
                UserId = "test"
            };
            ValidationResult result = validator.Validate(booking);
            if (!result.IsValid)
            {
                validator.ValidateAndThrow(booking);
            }

            bookingManager.Create(booking);
            return Ok(booking);



        }
        // POST: Booking/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Booking booking)
        {
            if (ModelState.IsValid)
            {
                bookingManager.Update(booking);
            }
            return Ok(booking);
        }

        // POST: Booking/Delete/5
        [HttpDelete]
        [Route("Api/Booking/Delete")]
        public ActionResult Delete(Guid id)
        {
            bookingManager.Delete(id);
            return Ok();
        }
    }
}
