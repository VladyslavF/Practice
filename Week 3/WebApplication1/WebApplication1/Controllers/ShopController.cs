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
            return View(model);
        }
        public IActionResult Item()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}
