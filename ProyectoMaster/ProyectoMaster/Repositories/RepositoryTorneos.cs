using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProyectoMaster.Data;
using ProyectoMaster.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Repositories
{
    #region STORED PROCEDURES / VISTAS
    //    alter VIEW V_TORNEO_INDIVIDUAL
    //AS

    //    select
    //    CAST(row_number() over(order by idTorneo) as int)

    //   as posicion, isnull(idTorneo, 0) as idTorneo
    //   , Nombre, Region, Fecha, Napuntados, Descripcion,
    //   Normas, Tipo, Link from Torneos
    //Go
//    Alter View V_APUNTADOS_JUGADOR
//AS

//    select
//    CAST(row_number() over(order by idInscripcion) as int) as posicion,
//	idInscripcion, idTorneo, apuntados.idJugador,
//	Puesto, Record, Seed, Nombre, Nick, Equipo, Region
//    from apuntados
//    inner join Jugadores

//    on apuntados.idJugador = Jugadores.idJugador
//GO

//    ALTER PROCEDURE SP_APUNTADOS_JUGADOR
//    (@idtorneo int, @registros int out, @posicion int)
//as
//	select @registros

    //    select* FROM V_APUNTADOS_JUGADOR
    //   where idtorneo = @idtorneo and

    //   
    //go

    //SELECT PARA OBTENER LOS 2 NICKS DE UN SET
//    select * ,
//(select Nick from Jugadores
//inner join apuntados
//on Jugadores.idJugador = apuntados.idJugador
//where idInscripcion = idApuntado2)
//,
//(select Nick from Jugadores
//inner join apuntados
//on Jugadores.idJugador = apuntados.idJugador
//where idInscripcion = idApuntado1)

//from Jugadores

//inner join apuntados
//on Jugadores.idJugador = apuntados.idJugador

//inner join sets
//on sets.idApuntado1 = idInscripcion or

//    sets.idApuntado2 = idInscripcion

//where apuntados.IdInscripcion = 10

    #endregion
    public class RepositoryTorneos
    {
        private TorneosContext context;

        public RepositoryTorneos(TorneosContext context)
        {
            this.context = context;
        }

        #region METODOS TORNEOS

        public int GetNumeroTorneos()
        {
            return this.context.Torneos.Count();
        }
        public List<Torneo> GetTorneos()
        {
            var consulta = from datos in this.context.Torneos
                           select datos;
            return consulta.ToList();
        }
        public Torneo GetTorneoById(int idtorneo)
        {
            var consulta = from datos in this.context.Torneos
                           where datos.IdTorneo == idtorneo
                           select datos;
            return consulta.SingleOrDefault();
        }
        public List<VistaTorneo> GetTorneosPaginado(int posicion)
        {
            var consulta = from datos in this.context.VistaTorneos
                           where datos.Posicion >= posicion
                           && datos.Posicion < (posicion + 2)
                           select datos;
            return consulta.ToList();
        }
        public void InsertTorneo(int idtorneo, string nombre, string region, DateTime fecha, int napuntados, string descripcion, string tipo, string link)
        {
            Torneo TorneoNuevo = new Torneo
            {
                IdTorneo = idtorneo,
                Nombre = nombre,
                Region = region,
                Fecha = fecha,
                Napuntados = napuntados,
                Descripcion = descripcion,
                Tipo = tipo,
                Link = link
            };
            this.context.Torneos.Add(TorneoNuevo);
            this.context.SaveChanges();
        }
        public void UpdateTorneo(int idtorneo, string nombre, string region, DateTime fecha, int napuntados, string descripcion, string tipo, string link)
        {
            Torneo TorneoEditar = this.GetTorneoById(idtorneo);
            TorneoEditar.Nombre = nombre;
            TorneoEditar.Region = region;
            TorneoEditar.Fecha = fecha;
            TorneoEditar.Napuntados = napuntados;
            TorneoEditar.Descripcion = descripcion;
            TorneoEditar.Tipo = tipo;
            TorneoEditar.Link = link;
            this.context.SaveChanges();
        }

        #endregion


        #region METODOS SETS
        public List<Set> GetSets()
        {
            var consulta = from datos in this.context.Sets
                           select datos;
            return consulta.ToList();
        }

        public Set GetSetById(int idset)
        {
            var consulta = from datos in this.context.Sets
                           where datos.IdSet == idset
                           select datos;
            return consulta.FirstOrDefault();
        }


        public void InsertSet(int idset, int ap1, int ap2, int apganador, string resultado, string ronda, int idtorneo)
        {
            Set SetNuevo = new Set
            {
                IdSet = idset,
                IdApuntado1 = ap1,
                IdApuntado2 = ap2,
                Ganador = apganador,
                Resultado = resultado,
                Ronda = ronda,
                IdTorneo = idtorneo
            };
            this.context.Sets.Add(SetNuevo);           
            this.context.SaveChanges();
        }

        public void UpdateSet(int idset, int ap1, int ap2, int apganador, string resultado, string ronda, int idtorneo)
        {
            Set SetEditar = this.GetSetById(idset);
            SetEditar.IdApuntado1 = ap1;
            SetEditar.IdApuntado2 = ap2;
            SetEditar.Ganador = apganador;
            SetEditar.Resultado = resultado;
            SetEditar.Ronda = ronda;
            SetEditar.IdTorneo = idtorneo;
            SetEditar.IdApuntado1 = ap1;
            this.context.SaveChanges();
        }


        #endregion


        #region METODOS APUNTADOS
        public List<Apuntado> GetApuntados()
        {
            var consulta = from datos in this.context.Apuntados
                           select datos;
            return consulta.ToList();
        }
        public List<Apuntado> GetApuntadosByTorneo(int idtorneo)
        {
            var consulta = from datos in this.context.Apuntados
                           where datos.IdTorneo == idtorneo
                           select datos;
            return consulta.ToList();
        }

        public List<VistaApuntadosJugadores> GetVApuntadosByTorneo(int idtorneo)
        {
            string sql = "SP_APUNTADOS_JUGADOR @idtorneo";
           
            SqlParameter paramidtorneo = new SqlParameter("@idtorneo", idtorneo);
           
            var consulta =
                this.context.VistaApJug.FromSqlRaw
                (sql, paramidtorneo);

            List<VistaApuntadosJugadores> VApuntados = consulta.ToList();
        
            return VApuntados;
        }
        public Apuntado GetApuntadoById(int idapuntado)
        {
            var consulta = from datos in this.context.Apuntados
                           where datos.IdApuntado == idapuntado
                           select datos;
            return consulta.FirstOrDefault();
        }
        public void InsertApuntado(int idinscripcion, int idtorneo, int idjugador, int puesto, string record, int seed)
        {
            Apuntado ApuntadoNuevo = new Apuntado
            {
                IdApuntado = idinscripcion,
                IdTorneo = idtorneo,
                IdJugador = idjugador,
                Puesto = puesto,
                Record = record,
                Seed = seed,
            };
            this.context.Apuntados.Add(ApuntadoNuevo);
            this.context.SaveChanges();
        }
        public void UpdateApuntado(int idinscripcion, int idtorneo, int idjugador, int puesto, string record, int seed)
        {
            Apuntado ApuntadoEditar = this.GetApuntadoById(idinscripcion);
            ApuntadoEditar.IdTorneo = idtorneo;
            ApuntadoEditar.IdJugador = idjugador;
            ApuntadoEditar.Puesto = puesto;
            ApuntadoEditar.Record = record;
            ApuntadoEditar.Seed = seed;
            this.context.SaveChanges();
        }
        #endregion


        #region METODOS JUGADORES
        public List<Jugador> GetJugadores()
        {
            var consulta = from datos in this.context.Jugadores
                           select datos;
            return consulta.ToList();
        }
        public Jugador GetJugadorById(int idjugador)
        {
            var consulta = from datos in this.context.Jugadores
                           where datos.IdJugador == idjugador
                           select datos;
            return consulta.SingleOrDefault();
        }
        public void InsertJugador(int idjugador, string nick, string region, string nombre, string email, string rol, string equipo)
        {
            Jugador JugadorNuevo = new Jugador
            {
                IdJugador = idjugador,
                Nick = nick,
                Region = region,
                Nombre = nombre,
                Email = email,
                Rol = rol,
                Equipo = equipo
            };
            this.context.Jugadores.Add(JugadorNuevo);
            this.context.SaveChanges();
        }
        public void UpdateJugador(int idjugador, string nick, string region, string nombre, string email, string rol, string equipo)
        {
            Jugador JugadorEditar = this.GetJugadorById(idjugador);
            JugadorEditar.Nick = nick;
            JugadorEditar.Region = region;
            JugadorEditar.Nombre = nombre;
            JugadorEditar.Email = email;
            JugadorEditar.Rol = rol;
            JugadorEditar.Equipo = equipo;
            this.context.SaveChanges();
        }
        #endregion


    }
}
