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
        
        public IActionResult EditarSet(int idset)
        {
            Set setEditar = this.repo.GetSetById(idset);
            return View(setEditar);
        }
        [HttpPost]
        public IActionResult EditarSet(int idset, int ap1,
            int ap2, int apganador, string resultado,
            string ronda, int idtorneo)
        {
            this.repo.UpdateSet(idset, ap1,
            ap2, apganador, resultado,
            ronda, idtorneo);
            return RedirectToAction("ListaSetsTorneo",
                new { idtorneo = idtorneo }
               );
        }

        public IActionResult NuevoSet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NuevoSet(int ap1, int ap2, 
            int apganador, string resultado, string ronda,
            int idtorneo)
        {
            int idsetMax = this.repo.GetSetMaxId();
            this.repo.InsertSet(idsetMax, ap1, ap2,
            apganador, resultado, ronda,
            idtorneo);
            return RedirectToAction("ListaSetsTorneo",
                 new {idtorneo = idtorneo}
                );
        }

        public IActionResult ListaSetsApuntado(int idap)
        {
            List<VistaSetFormateado> vistaSets = this.repo.GetSetsFormatByIdApuntado(idap);
            return View(vistaSets);
        }
    }
}
