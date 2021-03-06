using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Models
{
    public class VistaJugadores
    {
        [Key]
        [Column("IDJUGADOR")]
        public int IdJugador { get; set; }
        [Column("NICK")]
        public string Nick { get; set; }
        [Column("REGION")]
        public string Region { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("PASSWORD")]
        public string Password { get; set; }
        [Column("ROL")]
        public string Rol { get; set; }
        [Column("EQUIPO")]
        public string Equipo { get; set; }
        [Column("POSICION")]
        public int Posicion { get; set; }
    }
}
