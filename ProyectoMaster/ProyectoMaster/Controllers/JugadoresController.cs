using Microsoft.AspNetCore.Mvc;
using ProyectoMaster.Filters;
using ProyectoMaster.Models;
using ProyectoMaster.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

        public IActionResult ListaJugadoresAdmin(int? posicion)
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

        [AuthorizeJugadores]
        public IActionResult MiPerfil()
        {
            int idjugador = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
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
            string region, string nombre, string email, string password,
            string rol, string equipo)
        {
            int idjugMax = this.repo.GetJugadorMaxId()+1;
            this.repo.InsertJugador(idjugMax, nick,
            region, nombre, email, password, rol, equipo);
            return RedirectToAction("ListaJugadores");
        }
        public IActionResult EliminarJugador(int idjugador)
        {
            this.repo.DeleteJugador(idjugador);
            return RedirectToAction("ListaJugadoresAdmin");
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
