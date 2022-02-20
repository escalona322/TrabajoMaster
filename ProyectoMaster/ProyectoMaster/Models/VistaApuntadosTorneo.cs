using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Models
{
    [Table("V_APUNTADOS_TORNEO")]
    public class VistaApuntadosTorneo
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
        [Column("NICK")]
        public string Nick { get; set; }
        [Column("REGION")]
        public string Region { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("EQUIPO")]
        public string Equipo { get; set; }
        [Column("POSICION")]
        public int Posicion { get; set; }
    }
}
