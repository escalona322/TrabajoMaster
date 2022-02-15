﻿using Microsoft.AspNetCore.Mvc;
using ProyectoMaster.Models;
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

        public TorneosController(RepositoryTorneos repo)
        {
            this.repo = repo;
        }
        public IActionResult ListaTorneos(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            int MaxRegistro = this.repo.GetNumeroTorneos();
            ViewData["ULTIMO"] = MaxRegistro;
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
            List<VistaTorneo> torneos = this.repo.GetTorneosPaginado(posicion.Value);
            return View(torneos);
        }
        public IActionResult DetallesTorneo(int idtorneo)
        {
            List<Apuntado> apuntados = this.repo.GetApuntadosByTorneo(idtorneo);
            Torneo torneo = this.repo.GetTorneoById(idtorneo);
            ViewData["TORNEO"] = torneo;
            return View(apuntados);
        }

        public IActionResult NuevoTorneo()
        {
            return View();
        }
        public IActionResult EditarTorneo(int idtorneo)
        {
            Torneo torneo = this.repo.GetTorneoById(idtorneo);
            return View(torneo);
        }
    }
}