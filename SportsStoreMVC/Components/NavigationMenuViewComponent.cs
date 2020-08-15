using Microsoft.AspNetCore.Mvc;
using SportsStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            var productsByCategory = repository.Products
                                               .Select(x => x.Category)
                                               .Distinct()
                                               .OrderBy(x => x);        
            
            return View(productsByCategory);            
        }

    }
}
