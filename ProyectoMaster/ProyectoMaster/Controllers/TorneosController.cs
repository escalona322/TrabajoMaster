using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoMaster.Filters;
using ProyectoMaster.Helpers;
using ProyectoMaster.Models;
using ProyectoMaster.Providers;
using ProyectoMaster.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Controllers
{
    public class TorneosController : Controller
    {
        private RepositoryTorneos repo;
        private HelperUploadFiles helperUpload;

        public TorneosController(RepositoryTorneos repo,
            HelperUploadFiles helperUpload)
        {
            this.helperUpload = helperUpload;
            this.repo = repo;
        }
        [AuthorizeJugadores]
        public IActionResult ListaTorneos(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            int MaxRegistro = this.repo.GetNumeroTorneos();
            ViewData["REGISTROS"] = MaxRegistro;
            int siguiente = posicion.Value + 1;
            if (siguiente > MaxRegistro)
            {
                siguiente = MaxRegistro;
                ViewData["MENSAJE"] = "Este es el ultimo torneo";
            }
            int anterior = posicion.Value - 1;
            if (anterior < 1)
            {
                anterior = 1;
                ViewData["MENSAJE"] = "Este es el primer primer torneo";
            }
            ViewData["SIGUIENTE"] = siguiente;
            ViewData["ANTERIOR"] = anterior;
            ViewData["POSICION"] = posicion;
            List<VistaTorneo> torneos = this.repo.GetTorneosPaginado(posicion.Value);
            return View(torneos);
        }

        public IActionResult ListaTorneosAdmin(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            int MaxRegistro = this.repo.GetNumeroTorneos();
            ViewData["REGISTROS"] = MaxRegistro;
            int siguiente = posicion.Value + 1;
            if (siguiente > MaxRegistro)
            {
                siguiente = MaxRegistro;
                ViewData["MENSAJE"] = "Este es el ultimo torneo";
            }
            int anterior = posicion.Value - 1;
            if (anterior < 1)
            {
                anterior = 1;
                ViewData["MENSAJE"] = "Este es el primer primer torneo";
            }
            ViewData["SIGUIENTE"] = siguiente;
            ViewData["ANTERIOR"] = anterior;
            ViewData["POSICION"] = posicion;
            List<VistaTorneo> torneos = this.repo.GetTorneosPaginado(posicion.Value);
            return View(torneos);
        }
        public IActionResult DetallesTorneo(int idtorneo)
        {
            List<VistaApuntadosTorneo> apuntados = this.repo.GetVApuntadosByTorneoNoPag(idtorneo);
            Torneo torneo = this.repo.GetTorneoById(idtorneo);
            ViewData["TORNEO"] = torneo;
            return View(apuntados);
        }

        public IActionResult NuevoTorneo()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NuevoTorneo(string nombre, string region,
            DateTime fecha, int napuntados, string descripcion,
            string normas, string tipo, string link, IFormFile foto)
        {
            int idtorneoMax = this.repo.GetTorneoMaxId()+1;

            string path = await this.helperUpload.UploadFileAsync(foto, Folders.Images);
            this.repo.InsertTorneo(idtorneoMax, nombre, region, fecha,
                napuntados, descripcion, normas, tipo, link, path);
            return RedirectToAction("ListaTorneos");
        }

        public IActionResult EliminarTorneo(int idtorneo)
        {
            this.repo.DeleteTorneo(idtorneo);
            return RedirectToAction("ListaTorneosAdmin");
        }

        public IActionResult EditarTorneo(int idtorneo)
        {
            Torneo torneo = this.repo.GetTorneoById(idtorneo);
            return View(torneo);
        }

        [HttpPost]
        public async Task<IActionResult> EditarTorneo(int idtorneo, string nombre, 
            string region, DateTime fecha, int napuntados, 
            string descripcion, string normas, string tipo,
            string link, IFormFile foto)
        {
            string path = await this.helperUpload.UploadFileAsync(foto, Folders.Images);
            this.repo.UpdateTorneo(idtorneo, nombre,
            region, fecha, napuntados, descripcion, 
            normas, tipo, link, path);
            return RedirectToAction("ListaTorneos");
        }
       

    }
}
