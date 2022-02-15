select idtorneo from torneos

Alter View V_APUNTADOS_JUGADOR
AS
	select
	CAST(row_number() over(order by idInscripcion) as int) as posicion,
	idInscripcion, idTorneo, apuntados.idJugador,
	Puesto, Record, Seed, Nombre, Nick, Equipo, Region
	from apuntados
	inner join Jugadores
	on apuntados.idJugador = Jugadores.idJugador	
GO

ALTER PROCEDURE SP_APUNTADOS_JUGADOR 
(@idtorneo int)
as
	select posicion,
	idInscripcion, idTorneo, idJugador,
	Puesto, Record, Seed, Nombre, Nick, Equipo, Region 
	FROM V_APUNTADOS_JUGADOR
	where idtorneo = @idtorneo
go
select posicion,
	idInscripcion, idTorneo, idJugador,
	Puesto, Record, Seed, Nombre, Nick, Equipo, Region 
	FROM V_APUNTADOS_JUGADOR
	where idtorneo = 2
select * from apuntados