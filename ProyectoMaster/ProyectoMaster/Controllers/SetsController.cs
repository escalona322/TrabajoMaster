using Microsoft.AspNetCore.Mvc;
using ProyectoMaster.Models;
using ProyectoMaster.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Controllers
{
    public class SetsController : Controller
    {
        private RepositoryTorneos repo;

        public SetsController(RepositoryTorneos repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult EditarSet(int idset, int idtorneo)
        {
            Set setEditar = this.repo.GetSetById(idset);
            List<VistaApuntadosTorneo> apuntados = this.repo.GetVApuntadosByTorneoNoPag(idtorneo);
            ViewData["RONDA"] = setEditar.Ronda;
            ViewData["RESULTADO"] = setEditar.Resultado;
            ViewData["IDTORNEO"] = idtorneo;
            return View(apuntados);
        }
        [HttpPost]
        public IActionResult EditarSet(int idset, int ap1,
            int ap2, int apganador, string resultado,
            string ronda, int idtorneo)
        {
            this.repo.UpdateSet(idset, ap1,
            ap2, apganador, resultado,
            ronda, idtorneo);
            return RedirectToAction("ListaSetsApuntadoAdmin",
                new {idap = apganador }
               );
        }

        public IActionResult NuevoSet(int idtorneo)
        {
            ViewData["IDTORNEO"] = idtorneo;
            List<VistaApuntadosTorneo> apuntados = this.repo.GetVApuntadosByTorneoNoPag(idtorneo);
            return View(apuntados);
        }

        [HttpPost]
        public IActionResult NuevoSet(int ap1, int ap2, 
            int apganador, string resultado, string ronda,
            int idtorneo)
        {
            int idsetMax = this.repo.GetSetMaxId()+1;
            this.repo.InsertSet(idsetMax, ap1, ap2,
            apganador, resultado, ronda,
            idtorneo);
            return RedirectToAction("ListaSetsApuntado",
                 new {idap = apganador}
                );
        }

        public IActionResult ListaSetsApuntado(int idap)
        {
            List<VistaSetFormateado> vistaSets = this.repo.GetSetsFormatByIdApuntado(idap);
            return View(vistaSets);
        }
        public IActionResult ListaSetsApuntadoAdmin(int idap)
        {
            List<VistaSetFormateado> vistaSets = this.repo.GetSetsFormatByIdApuntado(idap);
            return View(vistaSets);
        }
    }
}
