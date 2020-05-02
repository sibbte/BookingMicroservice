using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingMicroservice.Models
{
    public class Booking
    {
        public Guid ID { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy", ApplyFormatInEditMode = true)]
        public virtual DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy", ApplyFormatInEditMode = true)]
        public virtual DateTime EndDate { set; get; }
        public string Notes { get; set; }
        public virtual Guid Cats { get; set; }
        public virtual Guid Room { get; set; }
        public virtual Guid Customer { get; set; }
        [Display(Name = "Booking Made Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy", ApplyFormatInEditMode = true)]
        public virtual DateTime BookingMade { get; set; }
        [Display(Name = "Checked In")]
        public bool? CheckedIn { get; set; }
        [Display(Name = "Checked Out")]
        public bool? CheckedOut { get; set; }
        public double Price { get; set; }
        public int CatsAmount { get; set; }
        public string UserId { get; set; }
        public bool CCTV { get; set; }
    }
}
