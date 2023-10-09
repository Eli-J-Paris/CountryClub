using CountryClubAPI.DataAccess;
using CountryClubAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryClubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly CountryClubContext _context;

        public BookingsController(CountryClubContext context)
        {
            _context = context;
        }

      

        [HttpGet]
        public IActionResult Allbookings()
        {
            var members = _context.Bookings;

            return new JsonResult(members);
        }

        [HttpGet("{id}")]
        public IActionResult ReturnOneBookings(int id)
        {
            var member = _context.Bookings.Find(id);
            return new JsonResult(member);
        }

        [HttpPost]
        public IActionResult CreateBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
            return new JsonResult(booking);
        }
    }
}
