using Microsoft.AspNetCore.Mvc;
using ProyectoMaster.Models;
using ProyectoMaster.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Controllers
{
    public class JugadoresController : Controller
    {
        private RepositoryTorneos repo;

        public JugadoresController(RepositoryTorneos repo)
        {
            this.repo = repo;
        }
        public IActionResult ListaJugadores(int? posicion)
        {

            if (posicion == null)
            {
                posicion = 1;
            }


            int NJugadores = this.repo.GetNJugadores();
            ViewData["NJUGADORES"] = NJugadores;
            int siguiente = posicion.Value + 25;
            int anterior = posicion.Value - 25;
            if (siguiente >= NJugadores)
            {
                siguiente = NJugadores;
            }
            if (anterior < 1)
            {
                anterior = 1;
            }
            ViewData["POSICION"] = posicion;
            ViewData["SIGUIENTE"] = siguiente;
            ViewData["ANTERIOR"] = anterior;
            List<VistaJugadores> Jugadores = this.repo.GetVistaJugadores(posicion.Value);
            return View(Jugadores);
        }

        public IActionResult PerfilJugador(int idjugador)
        {
            List<Torneo> TorneosJugador = this.repo.GetTorneosByIdJugador(idjugador);
            List<VistaSetFormateado> Sets = this.repo.GetSetsFormatByIdJugador(idjugador);
            Jugador jug = this.repo.GetJugadorById(idjugador);
            ViewData["SETS"] = Sets;
            ViewData["TORNEOS"] = TorneosJugador;
            return View(jug);
        }

        public IActionResult NuevoJugador()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NuevoJugador(string nick,
            string region, string nombre, string email,
            string rol, string equipo)
        {
            int idjugMax = this.repo.GetJugadorMaxId();
            this.repo.InsertJugador(idjugMax, nick,
            region, nombre, email, rol, equipo);
            return RedirectToAction("ListaJugadores");
        }

        public IActionResult EditarJugador(int idjugador)
        {
            Jugador jugadorEditar = this.repo.GetJugadorById(idjugador);
            return View(jugadorEditar);
        }

        [HttpPost]
        public IActionResult EditarJugador(int idjugador,
            string nick, string region, string nombre, 
            string email, string rol, string equipo)
        {
            this.repo.UpdateJugador(idjugador,
               nick, region, nombre,
               email, rol, equipo);
            return RedirectToAction("ListaJugadores");
        }
    }
}
