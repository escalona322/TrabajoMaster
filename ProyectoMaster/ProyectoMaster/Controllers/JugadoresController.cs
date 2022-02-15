using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Controllers
{
    public class JugadoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
