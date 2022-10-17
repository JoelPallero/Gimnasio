create database gym

go

use gym

go

/*alter table TablaDondeEstaFK
   add constraint NombreDeLaRestriccion foreign key (ColumnaFK)
      references TablaDondeEstaPK (ColumnaPK)*/

/* Tablas Tipo Generales */

create table tipoDocumento(
id int primary key identity (0, 1),
tipo varchar(20) not null,
)
go

insert into tipoDocumento (tipo) values ('DNI')
insert into tipoDocumento (tipo) values ('LE')
insert into tipoDocumento (tipo) values ('LC')
insert into tipoDocumento (tipo) values ('CI')
insert into tipoDocumento (tipo) values ('Pasaporte')

go

/* Tablas Tipo para Empleados */

create table tipoEmpleado(
id int primary key identity (0, 1),
tipo varchar(20) not null
)
go

insert into tipoEmpleado (tipo) values ('Usuario')
insert into tipoEmpleado (tipo) values ('Profesor')
insert into tipoEmpleado (tipo) values ('Jefe')
insert into tipoEmpleado (tipo) values ('Admin')

go

create table estadoEmpleado(
id int primary key identity (0, 1),
estado varchar(30) not null
)

go

insert into estadoEmpleado (estado) values ('Activo')
insert into estadoEmpleado (estado) values ('Baja')
insert into estadoEmpleado (estado) values ('Carpeta Medica')
insert into estadoEmpleado (estado) values ('Vacaciones')
insert into estadoEmpleado (estado) values ('Suspendido')

go

/* Tablas tipo para Clientes */

create table estadoCliente(
id int primary key identity (0, 1),
estado varchar(30) not null
)
go

insert into estadoCliente (estado) values ('Activo')
insert into estadoCliente (estado) values ('Inactivo')
insert into estadoCliente (estado) values ('Baja')

go

/**/

--create table empleados(
--id int primary key identity (0, 1)
--)

--go

--create table empleados(
--id int primary key identity (0, 1)
--)

--go

--create table empleados(
--id int primary key identity (0, 1)
--)

go

/* Fin tablas Tipo*/

/* Tablas maestras */

--Tabla Personas
-- crear un campo de profesor, que sea como un profe general
-- que se pueda utilizar por defecto.
-- que no sea alguien específico, sino como cuando no hay
-- un profe para asignar a un plan, por si son varios
-- como por ejemplo si hay 2 o 3 profes a la misma hora para hacer musculación
-- que directamente se elija el 1 y que cuente como que cada profe
-- pueda capacitarlo en caso de necesitar ayuda el cliente.
create table empleados(
id int primary key identity (0, 1),
nombre nvarchar(50) not null,
apellido nvarchar (50) not null,
idTipoDocumento int not null,  
numDocumento varchar(15) not null,
telefono nvarchar (20) not null,
alternativo nvarchar (20) null,
mail nvarchar (50) null,
observaciones nvarchar (200) null,
idTipoEmpleado int not null,   --
idEstadoEmpleado int not null, 
usuario varchar(255) null, -- con algún hash para encriptar claves
clave varbinary(128) null, -- Si no es Usuario, no hace falta que tenga clave para acceder al sistema.
idJornada int not null -- jornada laboral
)

go
/* Sus FK */

alter table empleados
add constraint fk_empleado_tipoDoc foreign key (idTipoDocumento)
      references tipoDocumento (id)
go

alter table empleados
add constraint fk_empleado_tipoEmpleado foreign key (idTipoEmpleado)
      references tipoEmpleado (id)

go

alter table empleados
add constraint fk_empleado_estadoEmpleado foreign key (idEstadoEmpleado)
      references estadoEmpleado (id)

go

/*  Fin de sus FK */

--Tabla clientes

create table clientes(
id int primary key identity (0, 1),
nombre nvarchar(50) not null,
apellido nvarchar (50) not null,
idTipoDocumento int not null,
numDocumeto varchar(15) not null,
telefono nvarchar (20) not null,
alternativo nvarchar (20) null,
mail nvarchar (50) null,
observaciones nvarchar (200) null,
fechaAlta datetime not null,
fechaBaja datetime null,
idEstadoCliente int not null, 
idUsuario int not null -- quien registró al cliente (la huella)
)
go

/* Sus Fk */

alter table clientes
add constraint fk_cliente_tipoDoc foreign key (idTipoDocumento)
      references tipoDocumento (id)
go

alter table clientes
add constraint fk_clientes_estadoCliente foreign key (idEstadoCliente)
      references estadoCliente (id)

go

alter table clientes
add constraint fk_clientes_empleado foreign key (idUsuario)
      references empleados (id)

go

/*  Fin de sus FK */

-- Tabla Asistencia

create table asistencia(
id int primary key identity (1, 1) not null,
fecha datetime not null,
estado varchar(1) not null, --Una sola letra para el Presente (P), Ausente (A), o tarde (T)
idCliente int not null,
idPlanAsig int not null,    --Para saber a qué clase o plan pertenece, en caso de ser clases con horarios específicos
idUsuario int not null
)

go

/* Sus FK */

 alter table asistencia
   add constraint fk_asistencia_cliente foreign key (idCliente)
      references cliente (id)

go

 alter table asistencia
   add constraint fk_asistencia_planAsign foreign key (estado_id)
      references planAsignado (id)


/* Fin de sus FK */

go

--Tabla Caja

create table caja(
id int primary key identity (0, 1),
fecha datetime not null,
idUsuario int not null,
importeInicial decimal(18, 0) not null,
importeFinal decimal(18, 0) null
)
go

/* Sus FK */

 alter table caja
   add constraint fk_caja_empleado foreign key (idUsuario)
      references empleados (id)

/* Fin de sus FK*/

go

--Tabla Detalles de caja

create table detalleCaja(
id int primary key identity (0, 1),
idCaja int not null,
idPlanAsignado int not null,
idUsuario int not null,    --quien registro todo.
Motivo varchar (100) not null, --zumba, pase libre, o al plan que se haya anotado podría ser
importeIngreso decimal (18, 0) null, --importe del dinero que ingresa
importeEgreso decimal (18, 0) null,
observaciones varchar(255) not null
)
go

/* Sus FK */

alter table detalleCaja
add constraint fk_detalleCaja_idCaja foreign key (idCaja)
      references caja (id)
go

alter table detalleCaja
add constraint fk_detalleCaja_idPlanAsignado foreign key (idPlanAsignado)
      references planAsignado (id)

go

/*  Fin de sus FK */

--Tabla Plan

create table planes(
id int primary key identity (0, 1),
nombre varchar(50) not null,
importePlan decimal (18,0) not null,
idUsuario int not null,
duración int not null,   -- en cantidad de meses
cupoTotal int null,
cupoRestante int null,
idJornada int not null -- se asigna la jornada correspondiente.
)
go

/* Sus FK */

alter table planes
add constraint fk_planes_empleado foreign key (idUsuario)
      references empleados (id)

go

alter table planes
add constraint fk_planes_jornada foreign key (idJornada)
      references jornada (id)

go

/*  Fin de sus FK */

--Tabla Plan Asignado

create table planAsignado(
id int primary key identity (0, 1),
idPlan int not null,    --
idCliente int not null, --
idUsuario int not null,
fechaInicio datetime not null,
fechaFin datetime null,
importePlan decimal (18, 0) not null,
saldo decimal (18, 0) not null,
vigencia varchar(1) not null,
)

go

/* Sus Fk */

alter table planAsignado
add constraint fk_planAsignado_idPlan foreign key (idPlan)
      references planes (id)
go

alter table detalleCaja
add constraint fk_planAsignado_idCliente foreign key (idCliente)
      references clientes (id)

go

/*  Fin de sus FK */

--Tabla Cuotas
--Para cuando un pago se haga en varias cuotas

create table cuotas(
id int primary key identity (0, 1),
idPlanAsignado int not null,
vtoCuota datetime null,
importeCuota decimal (18, 0) not null, --No hace falta tener el id del detalle, 
									   --porque las claves foráneas no pueden ser null
									   --Si son asociadas a claves primarias
saldo decimal (18, 0),
idDetalle int null, --No se crea como FK porque cuando se creen las cuotas, el sistema
							  --va a requerir los id del detalle de cuotas y no van a estar porque
							  --no están realizados aún.
idUsuario int not null
)
go

/* Sus FK */

alter table cuotas
add constraint fk_cuotas_idPlanAsignado foreign key (idPlanAsignado)
      references planAsignado (id)

go

/*  Fin de sus FK */

/* Consultar al respecto de la tabla de jornadas ********************************************************* */

/*

¿Debería ser una tabla particular que recopile todos los datos necesesarios, o solo un Join para traer los datos de la bdd?

*/

--Tabla Jornada

--create table jornadaTurnos(

--)

go

--Tabla Jornada Semanal de clases

create table jornada(
id int primary key identity (0, 1),
Todos varchar (20) null,
lunes varchar (20) null,
martes varchar (20) null,
miercoles varchar (20) null,
jueves varchar (20) null,
viernes varchar (20) null,
sabado varchar (20) null
)

/* Fin tablas maestras */