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
 Balance float (30,2),
)
GO
CREATE TABLE Inscripciones
(
	InscripcionID int primary key identity,
	Fecha date,
	EstudianteID  int primary Key identity,
	Conetario varchar(40),
	Monto float(10,2),
	Deposito float(10,2),
	Balance float(10,2),
)