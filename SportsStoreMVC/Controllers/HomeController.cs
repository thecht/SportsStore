
using Microsoft.AspNetCore.Mvc;
using SportsStoreMVC.Models;
using System.Linq;

namespace SportsStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public int PageSize = 4;

        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(int productPage = 1)
        {
            var products = repository.Products
                            .OrderBy(p => p.ProductID)
                            .Skip((productPage - 1) * PageSize)
                            .Take(PageSize);

            return View(products);
        }
    }
}
