using Microsoft.AspNetCore.Mvc;
using my_web_app.Models;
using System.Collections.Generic;

namespace my_web_app.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public IActionResult Index()
        {
            // Logic to retrieve available services for booking
            List<Service> services = new List<Service>(); // Replace with actual data retrieval
            return View(services);
        }

        // POST: Booking/BookService
        [HttpPost]
        public IActionResult BookService(int serviceId)
        {
            // Logic to process the booking for the selected service
            // This could involve saving the booking to the database
            // and returning a confirmation view or redirecting to another action
            return RedirectToAction("Index");
        }
    }
}