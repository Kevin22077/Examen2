create database BDencuestas
use BDencuestas
create table preguntas (numEnc int primary key identity (1,1), nombre varchar (30), apellido varchar(30), fechanac date, correo varchar (80), carro bit)
