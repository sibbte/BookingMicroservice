using BookingMicroservice.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingMicroservice.Validators
{
    public class BookingValidator : AbstractValidator<Booking>
    {
        public BookingValidator()
        {
            RuleFor(x => x.StartDate.ToString()).NotEmpty().WithMessage("Start date cant be empty.");
            RuleFor(x => x.EndDate.ToString()).NotEmpty().WithMessage("End date cant be empty.");
            RuleFor(x => x.Notes).NotEmpty().WithMessage("The notes for the booking must be added.");
            RuleFor(x => x.Cats).NotEmpty().WithMessage("At least one cat must bee added to create a booking");
            RuleFor(x => x.Room).NotEmpty().WithMessage("The Room must be sepecified to create the booking");
            RuleFor(x => x.Customer).NotEmpty().WithMessage("The customer must be added to create a booking");
            RuleFor(x => x.BookingMade.ToString()).NotEmpty().WithMessage("Booking made on date cant be empty.");
        }
    }
}
