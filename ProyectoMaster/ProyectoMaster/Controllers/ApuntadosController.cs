﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult ListaApuntadosTorneo(int idtorneo, int? posicion)
        {
           
            if(posicion == null)
            {
                posicion = 1;
            }
       
            ViewData["IDTORNEO"] = idtorneo;
            int Napuntados = this.repo.GetNApuntadosTorneo(idtorneo);
            ViewData["NAPUNTADOS"] = Napuntados;
            int siguiente = posicion.Value + 20;
            int anterior = posicion.Value - 20;
            if(siguiente >= Napuntados)
            {
                siguiente = Napuntados;
            }
            if(anterior < 1)
            {
                anterior = 1;
            }

            ViewData["SIGUIENTE"] = siguiente;
            ViewData["ANTERIOR"] = anterior;
            ViewData["POSICION"] = posicion;
            List<VistaApuntadosJugadores> apuntados = this.repo.GetVApuntadosByTorneo(idtorneo, posicion.Value);
            return View(apuntados);
        }

        public IActionResult NuevoApuntado()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NuevoApuntado(
            int idtorneo, int idjugador, int puesto, 
            string record, int seed)
        {
            int idapMax = this.repo.GetApuntadoMaxId();
            this.repo.InsertApuntado(idapMax, idtorneo,
            idjugador, puesto, record, seed);

            return RedirectToAction("ListaApuntadosTorneo",
                new { idtorneo = idtorneo}
                );
        }
        public IActionResult EditarApuntado(int idapuntado)
        {
            Apuntado apuntadoEditar = this.repo.GetApuntadoById(idapuntado);
            return View(apuntadoEditar);
        }

        [HttpPost]
        public IActionResult EditarApuntado(int idinscripcion,
            int idtorneo, int idjugador, int puesto,
            string record, int seed)
        {
            this.repo.UpdateApuntado(idinscripcion,
            idtorneo, idjugador, puesto,
            record, seed);
            return RedirectToAction("ListaApuntadosTorneo",
                    new {idtorneo = idtorneo}
                );
        }
    }
}
