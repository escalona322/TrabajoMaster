using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Models
{
    [Table("TORNEOS")]
    public class Torneo
    {
        [Key]
        [Column("IDTORNEO")]
        public int IdTorneo { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("REGION")]
        public string Region { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }
        [Column("NAPUNTADOS")]
        public int Napuntados { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("NORMAS")]
        public string Normas { get; set; }
        [Column("TIPO")]
        public string Tipo { get; set; }
        [Column("LINK")]
        public string Link { get; set; }

    }
}
