using Microsoft.AspNetCore.Mvc;

namespace PetCareServicesApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}