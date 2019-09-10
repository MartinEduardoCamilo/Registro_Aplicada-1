CREATE DATABASE Estudiantedb
GO 
USE Estudiantedb
GO
CREATE TABLE Estudiantes
(
 Id  int primary key identity(1,1),
 Matricula  varchar(9),
 Nombres varchar(15),
 Apellidos Varchar(15),
 Cedula varchar(14),
 Telefono varchar(12),
 Celular varchar(12),
 Email varchar(20),
 FechaNacimiento date,
 Sexo varchar(9),
 Balance decimal (30,2),
)