﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
