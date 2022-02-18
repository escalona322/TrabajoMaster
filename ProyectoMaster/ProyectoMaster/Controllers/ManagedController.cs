using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ProyectoMaster.Models;
using ProyectoMaster.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProyectoMaster.Controllers
{
   
    public class ManagedController : Controller
    {
        private RepositoryTorneos repo;
        public ManagedController(RepositoryTorneos repo)
        {
            this.repo = repo;
        }
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(string email, string password)
        {
            Jugador jug =
                this.repo.ExisteJugador(email, password);
            if (jug != null)
            {
                ClaimsIdentity identity =
                new ClaimsIdentity
                (CookieAuthenticationDefaults.AuthenticationScheme
                , ClaimTypes.Name, ClaimTypes.Role);
                Claim claimName = new Claim(ClaimTypes.Name, jug.Email);
                identity.AddClaim(claimName);
                Claim claimId = new Claim
                    (ClaimTypes.NameIdentifier, jug.IdJugador.ToString());
                Claim claimRole = new Claim
                    (ClaimTypes.Role, jug.Rol);
                Claim claimRegion = new Claim
                    ("Region", jug.Region);            
                identity.AddClaim(claimId);
                identity.AddClaim(claimRole);
                identity.AddClaim(claimRegion);
                ClaimsPrincipal userPrincipal =
                new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync
                (CookieAuthenticationDefaults.AuthenticationScheme
                , userPrincipal);
                string controller = HttpContext.Request.Cookies["controller"];
                string action = HttpContext.Request.Cookies["action"];

                return RedirectToAction(action, controller);

            }
            else
            {
                ViewData["MENSAJE"] = "Usuario/Password incorrectos";
            }
            return View();

        }
        public IActionResult ErrorAcceso()
        {
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync
            (CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
