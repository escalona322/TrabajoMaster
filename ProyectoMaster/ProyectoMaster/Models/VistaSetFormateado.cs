using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Models
{
    public class VistaSetFormateado
    {
        [Key]
        [Column("IDSET")]
        public int IdSet { get; set; }
        [Column("GANADOR")]
        public int Ganador { get; set; }
        [Column("RESULTADO")]
        public string Resultado { get; set; }
        [Column("RONDA")]
        public string Ronda { get; set; }
        [Column("IDTORNEO")]
        public int IdTorneo { get; set; }
        [Column("NICK2")]
        public string Nick2 { get; set; }
        [Column("NICK1")]
        public string Nick1 { get; set; }
        [Column("NICKGANADOR")]
        public string NickGanador { get; set; }
    }
}
