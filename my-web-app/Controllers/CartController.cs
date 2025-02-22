using Microsoft.AspNetCore.Mvc;
using my_web_app.Models;
using System.Collections.Generic;
using System.Linq;

namespace my_web_app.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cartItems = _context.CartItems.ToList();
            return View(cartItems);
        }

        [HttpPost]
        public IActionResult AddToCart(int serviceId, int quantity)
        {
            var cartItem = new CartItem
            {
                ServiceId = serviceId,
                Quantity = quantity,
                UserId = User.Identity.Name // Assuming User.Identity.Name contains the user ID
            };

            _context.CartItems.Add(cartItem);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int id)
        {
            var cartItem = _context.CartItems.Find(id);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}