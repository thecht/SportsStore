
using Microsoft.AspNetCore.Mvc;
using SportsStoreMVC.Models;
using SportsStoreMVC.Models.ViewModels;
using System;
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

        public ViewResult Index(string category, int productPage = 1)
        {
            var products = repository.Products
                            .Where(p => category == null || p.Category == category)
                            .OrderBy(p => p.ProductID)
                            .Skip((productPage - 1) * PageSize)
                            .Take(PageSize);

            var pageInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                             repository.Products.Count() :
                             repository.Products.Where(e => e.Category == category).Count()           
            };

            var viewModel = new ProductsListViewModel
            {
                Products = products,
                PagingInfo = pageInfo,
                CurrentCategory = category
            };

            return View(viewModel);
        }
    }
}
