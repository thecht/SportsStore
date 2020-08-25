using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStoreMVC.Models;

namespace SportsStoreMVC.Controllers
{
    public class AdminController : Controller
    {
        private IStoreRepository repository;

        public AdminController(IStoreRepository storeRepo)
        {
            repository = storeRepo;
        }

        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}
