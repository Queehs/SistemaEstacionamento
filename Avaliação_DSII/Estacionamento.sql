create database Estacionamento

create table CadCli (
idCli int primary key identity not null,
nomeCli varchar (25) not null,
sobrenomeCli varchar (30) not null,
enderecoCli varchar (50) not null,
numeroCli varchar (5) not null,
bairroCli varchar (20) not null,
cidadeCli varchar (20) not null,
);

create table CadCar (
idCar int primary key identity not null,
placa int not null,
marca varchar (30) not null,
modelo varchar (30) not null,
cor varchar (15) not null,
chassi int not null,
anoFab date not null,
anoMod date not null
);

create table CadFunc (
idFunc int primary key identity not null,
nome varchar (20) not null,
sobrenome varchar (30) not null,
nascimento date not null,
admissao date not null,
cpf varchar (15) not null,
rg varchar (15) not null,
endereco varchar (50) not null
);

select * from CadCar
select * from CadCli
select * from CadFunc