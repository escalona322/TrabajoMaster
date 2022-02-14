using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Models
{
    [Table("APUNTADOS")]
    public class Apuntado
    {
        [Key]
        [Column("IDINSCRIPCION")]
        public int IdApuntado { get; set; }
        [Column("IDTORNEO")]
        public int IdTorneo { get; set; }
        [Column("IDJUGADOR")]
        public int IdJugador { get; set; }
        [Column("PUESTO")]
        public int Puesto { get; set; }
        [Column("RECORD")]
        public string Record { get; set; }
        [Column("SEED")]
        public int Seed { get; set; }

    }
}
