using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Shop;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        protected ShopDbContext shopDbContext;
        public HomeController(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }
        public IActionResult Index()
        {
            var model = new ShopFull();
            model.MenuItems = shopDbContext.MenuItems.ToList();
            model.MenuLinks = shopDbContext.Links.ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}