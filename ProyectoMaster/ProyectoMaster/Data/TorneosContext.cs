using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoMaster.Models;

namespace ProyectoMaster.Data
{
    public class TorneosContext: DbContext
    {
        public TorneosContext
            (DbContextOptions<TorneosContext> context) : base(context)
        {

        }

        public DbSet<Apuntado> Apuntados { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Torneo> Torneos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<VistaTorneo> VistaTorneos { get; set; }

        public DbSet<VistaApuntadosJugadores> VistaApJug { get; set; }
    }
}
