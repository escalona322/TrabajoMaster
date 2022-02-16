
alter PROCEDURE SP_TORNEOS_JUGADOR
(@idjugador int)
AS
select t.IdTorneo, t.Nombre, t.Region, t.Fecha, t.Napuntados, t.Descripcion, t.Normas, t.Tipo, t.Link
from torneos t
inner join apuntados a on
t.IdTorneo = a.IdTorneo
inner join jugadores j on
j.Idjugador = a.IdJugador
where j.IdJugador = @idjugador
GO

ALTER PROCEDURE SP_APUNTADOS_JUGADOR
       (@idtorneo int, @posicion int)
   as
   	select* FROM V_APUNTADOS_JUGADOR

     where idtorneo = 2 and
	 posicion >= 1 and posicion < (1 +20)

      
 go

 select * from apuntados where idtorneo = 2

ALTER VIEW V_APUNTADOS_JUGADOR
AS
select CAST(row_number() over(order by apuntados.IdInscripcion) as int)
   as posicion, apuntados.IdInscripcion, apuntados.IdTorneo,
   apuntados.idJugador, apuntados.Puesto, apuntados.Record,
   apuntados.Seed, jugadores.Nombre, jugadores.Nick, jugadores.Equipo,
   jugadores.region from apuntados
   inner join
   jugadores on
   jugadores.IdJugador = apuntados.IdJugador
GO

create view V_JUGADORES
AS
	select CAST(row_number() over(order by jugadores.IdJugador) as int)
   as posicion, idjugador, nick, region, nombre, email, password, rol,
   equipo from jugadores
go

ALTER procedure SP_JUGADOR
(@posicion int)
as
	select* FROM V_JUGADORES
     where 
	 posicion >= @posicion and posicion < (@posicion +25)
go


