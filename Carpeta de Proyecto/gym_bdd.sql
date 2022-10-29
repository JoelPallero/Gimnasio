create database gym

go

use gym

go

/* Tablas Maestras */

/* Personas */
create table Personas(
Persona_ID int primary key identity (0, 1),
Nombre nvarchar(50) not null,
Apellido nvarchar(50) not null,
Tipo_Documento_ID int not null,
Nro_documento nvarchar(24) not null,
Tipo_Sexo_ID int not null,
Nro_Telefono nvarchar(24) not null,
Nro_Alternativo nvarchar(24) null,
Mail nvarchar(50) null,
Observaciones nvarchar(200) null
)

go

create table Empleados(
Empleado_ID int primary key identity (0, 1),
Persona_ID int not null,
Usuario nvarchar(255) null,
Clave nvarchar(255) null,
Tipo_Empleado_ID int not null,
Estado_Empleado_ID int not null
)

go

create table Clientes(
Cliente_ID int primary key identity (0, 1),
Persona_ID int not null,
Estado nvarchar(20) not null,
)

go

create table Asistencias(
Asistencia_ID int primary key identity (0, 1),
Fecha datetime not null,
Estado nvarchar(1) not null, --P(resente), T(arde), A(usente)
Cliente_ID int not null,
Empleado_ID int not null --quien hizo el registro
)

go

/* Caja */

create table Cajas(
Caja_ID int primary key identity (0, 1),
Empleado_ID int not null,
Fecha datetime not null,
Importe_Inicial decimal(18,0) not null,
Importe_Final decimal(18,0) not null,
)

go

create table Detalles_Cajas(
Detalle_Caja_ID int primary key identity (0, 1),
Caja_ID int not null,
Plan_Asignado_ID int not null,
Empleado_ID int not null,
Importe_Ingreso decimal (18, 0) null,
Importe_Egreso decimal (18, 0) null,
Motivo nvarchar(50) not null,
Observaciones nvarchar(200) null,
)

go

create table Cuotas(
Cuota_ID int primary key identity (0, 1),
Plan_Asignado_ID int not null,
Empleado_ID int not null,
Detalle_Caja_ID int null,
Importe_Cuota decimal(18, 0) not null,
Saldo decimal(18, 0) not null,
Vto_Cuota datetime not null
)

go

/* Planes */

create table Planes(
Plan_ID int primary key identity (0, 1),
Empleado_ID int not null,
Nombre nvarchar(20) not null,
Importe_Plan decimal (18, 0) not null,
Duracion int null,
Cupo_Total int null,
Cupo_Restante int null,
Vigencia nvarchar (1) not null
)

go

create table Planes_Asignados(
Plan_Asignado_ID int primary key identity (0, 1),
Plan_ID int not null,
Cliente_ID int not null,
Empleado_ID int not null,
Fecha_Inicio datetime not null,
Fecha_Fin datetime null
)

go

-- �C�mo voy a saber si tengo saldo en Plan asignado, si no tengo
-- una tabla que me diga que tiene un saldo vencido?
-- Para eso creo una tabla que sea de la facturaci�n.
-- Se genera de manera autom�tica a principio de mes
-- Y el programa va a saber as� si hay una cuota vencida o pendiente de pago.
create table Facturas_Clientes(
Factura_Cliente_ID int primary key identity (0, 1),
Plan_Asignado_ID int not null,
Importe decimal(18, 0) not null,
Fecha_Emision datetime not null,
Fecha_Vencimiento datetime not null,
Saldo decimal (18, 0) not null --Ac� se le agregar�a la facturaci�n anterior.
)

go

/* Jornadas */

create table Jornadas_Planes(
Jornada_Plan_ID int primary key identity (0, 1),
Plan_ID int not null,
Dia nvarchar(10) not null,
Desde_Hora nvarchar(5) not null,
Hasta_Hora nvarchar(5) not null,
)

go

create table Jornadas_Empleados(
Jornada_Empleado_ID int primary key identity (0, 1),
Empleado_ID int not null,
Dia nvarchar(10) not null,
Desde_Hora nvarchar(5) not null,
Hasta_Hora nvarchar(5) not null,
)

go

/* Registro de Login */

create table Registros_Logs(
Registro_Log_ID int primary key identity (0, 1),
Empleado_ID int not null,
Fecha_LogIn datetime not null,
Fecha_LogOut datetime null
)

go

/* Fin Tablas Maestras */

/* Tablas Tipo */

create table Tipos_Documentos(
Tipo_Documento_ID int primary key identity (0, 1),
Tipo varchar(3) not null
)

go

insert into Tipos_Documentos values ('DNI')
insert into Tipos_Documentos values ('LC')
insert into Tipos_Documentos values ('LE')
insert into Tipos_Documentos values ('CI')
insert into Tipos_Documentos values ('PAS')
insert into Tipos_Documentos values ('EXT')

go

create table Tipos_Sexos(
Tipo_Sexo_ID int primary key identity (0, 1),
Sexo varchar(20) not null
)

go

insert into Tipos_Sexos values ('Masculino')
insert into Tipos_Sexos values ('Femenino')
insert into Tipos_Sexos values ('Otros')

go

create table Tipos_Empleados(
Tipo_Empleado_ID int primary key identity (0, 1),
Tipo varchar(20) not null
)

go

insert into Tipos_Empleados values ('Admin')
insert into Tipos_Empleados values ('Jefe')
insert into Tipos_Empleados values ('Usuario')
insert into Tipos_Empleados values ('Profesor')
insert into Tipos_Empleados values ('Otros')

go

create table Estados_Empleados(
Estado_Empleado_ID int primary key identity (0, 1),
Estado varchar(20) not null
)

go

insert into Estados_Empleados values ('Activo')
insert into Estados_Empleados values ('Vacaciones')
insert into Estados_Empleados values ('Vacaciones')
insert into Estados_Empleados values ('Licencia M�dica')
insert into Estados_Empleados values ('Baja')

go

/* Fin Tablas Tipo */

/* Constrains */

/* Empleados */

alter table Empleados
add CONSTRAINT FK_Empleado_Persona FOREIGN KEY (Persona_ID) 
REFERENCES Personas (Persona_ID)

go

alter table Empleados
add CONSTRAINT FK_Empleado_Tipo_Empleado FOREIGN KEY (Tipo_Empleado_ID) 
REFERENCES Tipos_Empleados (Tipo_Empleado_ID)

go

alter table Empleados
add CONSTRAINT FK_Empleado_Estado_Empleado FOREIGN KEY (Estado_Empleado_ID) 
REFERENCES Estados_Empleados (Estado_Empleado_ID)

go

/* Clientes */


alter table Clientes
add CONSTRAINT FK_Clientes_Persona FOREIGN KEY (Persona_ID) 
REFERENCES Personas (Persona_ID)

go

/* Asistencias */
alter table Asistencias
add CONSTRAINT FK_Asistencia_Cliente FOREIGN KEY (Cliente_ID) 
REFERENCES Clientes (Cliente_ID)

go

alter table Asistencias
add CONSTRAINT FK_Asistencia_Empleado FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

/* Caja */

alter table Cajas
add CONSTRAINT FK_Cajas_Empleado FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

/* Detalles de Cajas */

alter table Detalles_Cajas
add CONSTRAINT FK_Detalles_Cajas FOREIGN KEY (Caja_ID) 
REFERENCES Cajas (Caja_ID)

go

alter table Detalles_Cajas
add CONSTRAINT FK_Detalles_Plan_Asignado FOREIGN KEY (Plan_Asignado_ID) 
REFERENCES Planes_Asignados (Plan_Asignado_ID)

go

alter table Detalles_Cajas
add CONSTRAINT FK_Detalles_Cajas_Empleado FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

/* Cuotas */ 

alter table Cuotas
add CONSTRAINT FK_Cuotas_Plan_Asignado FOREIGN KEY (Plan_Asignado_ID) 
REFERENCES Planes_Asignados (Plan_Asignado_ID)

go

alter table Cuotas
add CONSTRAINT FK_Cuotas_Empleado FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

alter table Cuotas
add CONSTRAINT FK_Nombre_Detalles_Cajas FOREIGN KEY (Detalle_Caja_ID) 
REFERENCES Detalles_Cajas (Detalle_Caja_ID)

go

/* Planes */

alter table Planes
add CONSTRAINT FK_Planes_Empleados FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

/* Planes_Asignados */

alter table Planes_Asignados
add CONSTRAINT FK_Planes_Asignados_Planes FOREIGN KEY (Plan_ID) 
REFERENCES Planes (Plan_ID)

go

alter table Planes_Asignados
add CONSTRAINT FK_Planes_Asignados_Cliente FOREIGN KEY (Cliente_ID) 
REFERENCES Clientes (Cliente_ID)

go

alter table Planes_Asignados
add CONSTRAINT FK_Planes_Asignados_Empleados FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

/* Facturas_Clientes */

alter table Facturas_Clientes
add CONSTRAINT FK_Facturas_Clientes_Constrain FOREIGN KEY (Plan_Asignado_ID) 
REFERENCES Planes_Asignados (Plan_Asignado_ID)

go

/* Jornadas_Planes  */

alter table Jornadas_Planes 
add CONSTRAINT FK_Jornada_Planes FOREIGN KEY (Plan_ID) 
REFERENCES Planes (Plan_ID)

go

/* Jornada_Empleados */

alter table Jornadas_Empleados
add CONSTRAINT FK_Jornada_Empleados_Empleados FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)


/* Registro de Login */

alter table Registros_Logs
add CONSTRAINT FK_Registros_Logs_Empleados FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

/* Fin Constrains */