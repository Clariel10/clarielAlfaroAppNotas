create database REGISTRO;
use REGISTRO;

--crear tablas

create table Estudiantes (
Id_estudiante int identity(1,1) primary key not null,
nombre_estudiante varchar (70),
apellido varchar(50),
usuario varchar (50),
contraseña varchar (50)
);

create table Materias (
Id_materia int identity(1,1) primary key not null,
nombre_materia varchar (50)
);

create table Calificaciones (
Id_notas int identity(1,1) primary key not null,
Id_estudiante int,
Id_materia int,
nota decimal(4,2)
);

GO

select * from Calificaciones

--Llaves Foraneas

Alter table Calificaciones add Foreign key (Id_estudiante) references Estudiantes(Id_estudiante);
Go
Alter table Calificaciones add Foreign key (Id_materia) references Materias(Id_materia);
Go

insert into Estudiantes(nombre_estudiante, apellido, usuario, contraseña) values ('Clariel','Alfaro','master','1234')
