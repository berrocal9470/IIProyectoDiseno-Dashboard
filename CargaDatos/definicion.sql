create database Proyecto2Disenno;

create table Provincias(
	id_provincia varchar(1),
	nombre varchar(15),
	primary key (id_provincia)
);

create table Cantones(
	id_provincia varchar(1),
	id_canton varchar(2),
	nombre varchar(50),
	primary key(id_provincia, id_canton),
	foreign key(id_provincia) references Provincias
);

create table Distritos(
	id_provincia varchar(1),
	id_canton varchar(2),
	id_distrito varchar(2),
	nombre varchar(50),
	latitud float(20),
	longitud float(20),
	primary key(id_provincia, id_canton, id_distrito),
	foreign key(id_provincia, id_canton) references Cantones
);

create table Roles(
	codigo int,
	tipo varchar(50),
	primary key (codigo)
);

create table Lesiones(
	codigo int,
	tipo varchar(50),
	primary key (codigo)
);

create table Personas(
	identificador int,
	edad int,
	edadQuinquenal varchar(50),
	sexo varchar(20),
	lesion int,
	rol int,
	primary key (identificador),
	foreign key (lesion) references Lesiones,
	foreign key (rol) references Roles
);

create table Registros(
	identificador int,
	id_provincia varchar(1),
	id_canton varchar(2),
	id_distrito varchar(2),
	dia varchar(20),
	mes varchar(20),
	anno int,
	persona int,
	check (dia in ('Lunes','Martes','Miercoles','Jueves','Viernes','Sabado','Domingo')),
	check (mes in ('Enero','Febrero','Marzo','Abril','Mayo','Junio',
					'Julio','Agosto','Setiembre','Octubre','Noviembre','Diciembre')),
	check(anno between 2012 and 2014),
	primary key(identificador),
	foreign key(id_provincia, id_canton, id_distrito) references Distritos,
	foreign key(persona) references Personas
);

drop table Registros;
drop table distritos;


-- PRUEBAS XD

insert into provincias values ('1', 'San José');
select * from provincias;

insert into cantones values ('1','01','San José');
select * from cantones;

insert into distritos values ('1','01','01','Carmen',null,null);
select * from distritos;

insert into Roles values (1,'Un rol');
select * from roles;

insert into lesiones values (1,'Una lesion');
select * from lesiones;

insert into personas values (1,20,'De 20 a 24','Indefinido',1,1);
select * from personas;

insert into registros values (1,'1','01','01','Viernes','Noviembre',2012,1);
select * from registros;


delete from registros;
delete from personas;
delete from lesiones;
delete from roles;
delete from distritos;
delete from cantones;
delete from provincias;