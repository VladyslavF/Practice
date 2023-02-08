using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebApplication1.Models;
using WebApplication1.Models.Shop;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class AccessController : Controller
    {
        protected ShopDbContext shopDbContext;
        public AccessController(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated) {
                //return RedirectToAction("Index", "Home");
                return RedirectToAction("Profile", "Access");
                    }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User modelLogin)
        {
            var db = new ShopFull();
            db.Users = shopDbContext.Users.ToList();
            foreach (var user in db.Users)
            {
                if (modelLogin.Email == user.Email) 
                {
                    if (modelLogin.Password == user.Password)
                    {
                        List<Claim> claims = new List<Claim>() { 
                            new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                            new Claim("OtherProperties", "Other Role")
                        };

                        ClaimsIdentity claimsIdentity= new ClaimsIdentity(claims,
                            CookieAuthenticationDefaults.AuthenticationScheme);
                        AuthenticationProperties properties = new AuthenticationProperties()
                        {
                            AllowRefresh = true,
                            IsPersistent = modelLogin.KeepLoggedIn
                        };
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity), properties);

                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ViewData["ValidateMessage"] = "User not found";
            return View();
        }

        public IActionResult Register()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

    }
}
