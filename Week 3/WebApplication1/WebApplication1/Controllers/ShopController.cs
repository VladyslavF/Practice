using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models.Shop;

namespace WebApplication1.Controllers
{
    public class ShopController : Controller
    {
        protected ShopDbContext shopDbContext;
        public ShopController(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public IActionResult Index()
        {
            var model = new ShopFull();
            model.categories = shopDbContext.Categories.ToList();
            model.products = shopDbContext.Products.ToList();
            model.sizes = shopDbContext.Sizes.ToList();
            model.colors = shopDbContext.Colors.ToList();
            model.Product_sizes = shopDbContext.Product_Sizes.ToList();
            model.MenuItems = shopDbContext.MenuItems.ToList();
            model.MenuLinks = shopDbContext.Links.ToList();
            return View(model);
        }
        public IActionResult Item()
        {
            var model = new ShopFull();
            model.MenuItems = shopDbContext.MenuItems.ToList();
            model.MenuLinks = shopDbContext.Links.ToList();
            return View(model);
        }
        public IActionResult Cart()
        {
            var model = new ShopFull();
            model.MenuItems = shopDbContext.MenuItems.ToList();
            model.MenuLinks = shopDbContext.Links.ToList();
            return View(model);
        }
    }
}
