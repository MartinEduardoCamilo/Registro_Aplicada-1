CREATE DATABASE Estudiantedb
GO 
USE Estudiantedb
GO
CREATE TABLE Estudiantes
(
 EstudianteID  int primary key identity,
 Matricula  varchar(9),
 Nombres varchar(15),
 Apellidos Varchar(15),
 Cedula varchar(14),
 Telefono varchar(12),
 Celular varchar(12),
 Email varchar(20),
 FechaNacimiento date,
 Sexo varchar(9),
 Balance decimal (30),
)
GO
CREATE TABLE Inscripcions
(
	InscripcionID int primary key identity,
	Fecha date,
	EstudianteID  int,
	Monto decimal(10),
	Deposito decimal(10),
	Balance decimal(10),
	Comentario varchar(40),
)