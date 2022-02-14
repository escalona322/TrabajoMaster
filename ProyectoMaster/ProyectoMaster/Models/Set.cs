using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Models
{
    [Table("SETS")]
    public class Set
    {
        [Key]
        [Column("IDSET")]
        public int IdSet { get; set; }
        [Column("IDAPUNTADO1")]
        public int IdApuntado1 { get; set; }
        [Column("IDAPUNTADO2")]
        public int IdApuntado2 { get; set; }
        [Column("GANADOR")]
        public int Ganador { get; set; }
        [Column("RESULTADO")]
        public string Resultado { get; set; }
        [Column("RONDA")]
        public string Ronda { get; set; }
        [Column("IDTORNEO")]
        public int IdTorneo { get; set; }
    }
}
