using Microsoft.AspNetCore.Mvc;
using ProyectoMaster.Models;
using ProyectoMaster.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Controllers
{
    public class ApuntadosController : Controller
    {

        private RepositoryTorneos repo;

        public ApuntadosController(RepositoryTorneos repo)
        {
            this.repo = repo;
        }

        public IActionResult ListaApuntadosTorneo(int idtorneo)
        {
            List<VistaApuntadosJugadores> apuntados = this.repo.GetVApuntadosByTorneo(idtorneo);
            return View(apuntados);
        }

        public IActionResult ListaTestVAp(int idtorneo, int? posicion)
        {
            if(posicion == null)
            {
                posicion = 1;
            }
  
            List<VistaApuntadosJugadores> Vapuntados = this.repo.GetVApuntadosByTorneo(idtorneo);
            return View(Vapuntados);
        }
    }
}
