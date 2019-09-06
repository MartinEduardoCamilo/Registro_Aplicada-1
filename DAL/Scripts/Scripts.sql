CREATE DATABASE Estudiantedb
GO
USE Estudiantedb
GO
CREATE TABLE Estudiante(

 EstudianteId int primary key identity(1,1),
 Matricula varchar(9),
 Nombres varchar(15),
 Apellidos varchar(15),
 Cedula varchar(11),
 Telefono varchar(10),
 Celular varchar(10),
 Email varchar(30),
 FechaNacimiento date,
 Sexo varchar(7),
 Balance varchar(9),

);