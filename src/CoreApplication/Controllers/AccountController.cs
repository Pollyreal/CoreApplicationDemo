using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreApplication.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Unauthorized(string returnUrl = null)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, "PollNg", ClaimValueTypes.String));
            claims.Add(new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String));
            var userIdentity = new ClaimsIdentity("管理员");
            userIdentity.AddClaims(claims);
            var userPrincipal = new ClaimsPrincipal(userIdentity);
            await HttpContext.Authentication.SignInAsync("MyCookieMiddlewareInstance", userPrincipal,
                new Microsoft.AspNetCore.Http.Authentication.AuthenticationProperties
                {
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20),
                    IsPersistent = false,
                    AllowRefresh = false
                });

            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
