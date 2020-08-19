using Microsoft.AspNetCore.Mvc;
using SportsStoreMVC.Models;

namespace SportsStoreMVC.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout()
        {
            return View(new Order());
        }
    }
}
