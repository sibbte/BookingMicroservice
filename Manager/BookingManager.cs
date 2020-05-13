using BookingMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BookingMicroservice.Manager
{
    public class BookingManager
    {
        private readonly CatContext _context;

        public BookingManager(CatContext context)
        {
            _context = context;
        }

        public Booking Find(Guid id)
        {
            return _context.Bookings.Find(id);
        }
        public void Create(Booking bookings)
        {


            bookings.BookingMade = DateTime.Now;

            _context.Add(bookings);
            _context.SaveChanges();



        }
        public IEnumerable<Booking> GetAllBookings()
        {

            return _context.Bookings.OrderBy(x => x.StartDate).ToList();
        }
        public void Delete(Guid id)
        {
            if (id == null)
            {
                throw new DataException("Booking Id provided doesnt exsist");
            }
            else
            {
                _context.Bookings.Remove(_context.Bookings.Find(id));
                _context.SaveChanges();
            }
        }

        public bool Exsits(Guid id)
        {
            return _context.Bookings.Any(x => x.ID == id);
        }

        public void Update(Booking bookings)
        {
            _context.Bookings.Update(bookings);
            _context.SaveChanges();
        }
    }
}
