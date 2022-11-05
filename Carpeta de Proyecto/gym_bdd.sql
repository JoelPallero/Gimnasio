DROP DATABASE IF EXISTS gym

go

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
Observaciones nvarchar(200) null,
Fecha_Alta datetime not null,
Fecha_Baja datetime null,
)

create table Empleados(
Empleado_ID int primary key identity (0, 1),
Persona_ID int not null,
Usuario nvarchar(255) null,
Clave varchar(200) null,
Tipo_Empleado_ID int not null,
Estado_Empleado_ID int not null
)

go

/*
0 Activo
1 Vacaciones

*/

create table Clientes(
Cliente_ID int primary key identity (0, 1),
Persona_ID int not null,
Estado nvarchar(20) not null
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
Estado nvarchar (1) not null
)

go

create table Planes_Asignados(
Plan_Asignado_ID int primary key identity (0, 1),
Plan_ID int not null,
Cliente_ID int not null,
Empleado_ID int not null,
Fecha_Inicio datetime not null,
Fecha_Fin datetime null,
Estado nvarchar(1) not null
)

go

-- ¿Cómo voy a saber si tengo saldo en Plan asignado, si no tengo
-- una tabla que me diga que tiene un saldo vencido?
-- Para eso creo una tabla que sea de la facturación.
-- Se genera de manera automática a principio de mes
-- Y el programa va a saber así si hay una cuota vencida o pendiente de pago.
create table Facturas_Clientes(
Factura_Cliente_ID int primary key identity (0, 1),
Plan_Asignado_ID int not null,
Importe decimal(18, 0) not null,
Fecha_Emision datetime not null,
Fecha_Vencimiento datetime not null,
Saldo decimal (18, 0) not null --Acá se le agregaría la facturación anterior.
)

go

/* Jornadas */

create table Jornadas_Planes(
Jornada_Plan_ID int primary key identity (0, 1),
Plan_ID int not null,
Dia nvarchar(10) not null,
Desde_Hora nvarchar(5) not null,
Hasta_Hora nvarchar(5) not null,
Estado nvarchar(8) not null
)

go

create table Jornadas_Empleados(
Jornada_Empleado_ID int primary key identity (0, 1),
Empleado_ID int not null,
Dia nvarchar(10) not null,
Desde_Hora nvarchar(5) not null,
Hasta_Hora nvarchar(5) not null,
Estado nvarchar(8) not null
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
Tipo varchar(4) not null,
Estado varchar(8) not null
)

go

insert into Tipos_Documentos values ('DNI', 'Activo')
insert into Tipos_Documentos values ('LC', 'Activo')
insert into Tipos_Documentos values ('LE', 'Activo')
insert into Tipos_Documentos values ('CI', 'Activo')
insert into Tipos_Documentos values ('PAS', 'Activo')
insert into Tipos_Documentos values ('EXT', 'Activo')
insert into Tipos_Documentos values ('CUIL', 'Activo')
insert into Tipos_Documentos values ('CUIT', 'Activo')

go

create table Tipos_Sexos(
Tipo_Sexo_ID int primary key identity (0, 1),
Sexo varchar(20) not null,
Estado varchar(8) not null
)

go

insert into Tipos_Sexos values ('Masculino', 'Activo')
insert into Tipos_Sexos values ('Femenino', 'Activo')
insert into Tipos_Sexos values ('Otros', 'Activo')

go

create table Tipos_Empleados(
Tipo_Empleado_ID int primary key identity (0, 1),
Tipo varchar(20) not null,
Acceso_Clave varchar(1) not null,
Estado varchar(8) not null
)

go

insert into Tipos_Empleados values ('Admin', 'Y', 'Activo')
insert into Tipos_Empleados values ('Jefe', 'Y', 'Activo')
insert into Tipos_Empleados values ('Usuario',  'Y', 'Activo')
insert into Tipos_Empleados values ('Profesor',  'N', 'Activo')
insert into Tipos_Empleados values ('Otros', 'N', 'Activo')

go

create table Estados_Empleados(
Estado_Empleado_ID int primary key identity (0, 1),
Estado_Empleado varchar(20) not null,
Estado varchar(8) not null
)

go

insert into Estados_Empleados values ('Activo', 'Activo')
insert into Estados_Empleados values ('Vacaciones', 'Activo')
insert into Estados_Empleados values ('Licencia Médica', 'Activo')
insert into Estados_Empleados values ('Baja', 'Activo')

go

/* Fin Tablas Tipo */

/* Constrains */

/* Personas */


alter table Personas
add CONSTRAINT FK_Personas_TipoDocumento FOREIGN KEY (Tipo_Documento_ID) 
REFERENCES Tipos_Documentos (Tipo_Documento_ID)

go

alter table Personas
add CONSTRAINT FK_Personas_TipoSexo FOREIGN KEY (Tipo_Sexo_ID) 
REFERENCES Tipos_Sexos (Tipo_Sexo_ID)

go

/* Empleados */

alter table Empleados
add CONSTRAINT FK_Empleado_Tipo_Empleado FOREIGN KEY (Tipo_Empleado_ID) 
REFERENCES Tipos_Empleados (Tipo_Empleado_ID)

go

alter table Empleados
add CONSTRAINT FK_Empleado_Estado_Empleado FOREIGN KEY (Estado_Empleado_ID) 
REFERENCES Estados_Empleados (Estado_Empleado_ID)

go

alter table Empleados
add CONSTRAINT FK_Empleado_Persona FOREIGN KEY (Persona_ID) 
REFERENCES Personas (Persona_ID)

go


/* Clientes */


alter table Clientes
add CONSTRAINT FK_Cliente_Persona FOREIGN KEY (Persona_ID) 
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


/* Procedimientos, triggers y demás */

create proc sp_cargar_tipos_documentos
as
select Tipo_Documento_ID, Tipo
from Tipos_Documentos
where Estado = 'Activo'

go

create proc sp_cargar_tipos_sexos
as
select Tipo_sexo_ID, Sexo
from Tipos_Sexos
where Estado = 'Activo'

go

create proc sp_cargar_tipos_empleados
as
select Tipo, Acceso_Clave
from Tipos_Empleados
where Tipo != 'Admin'
and Tipo != 'Jefe'

go

create proc sp_cargar_tipos_empleados_Jefe
as
select Tipo_Empleado_ID, Tipo
from Tipos_Empleados
where Tipo != 'Admin'
and Estado = 'Activo'

go

create proc sp_cargar_tipos_empleados_Admin
as
select Tipo_Empleado_ID, Tipo
from Tipos_Empleados
where Estado = 'Activo'

go

create proc sp_cargar_ultimo_ID
as
select Empleado_ID
from Empleados
where Empleado_ID = (select(max(Empleado_ID)) from Empleados)

go

create proc sp_cargar_ultimo_ID_Personas
as
select Persona_ID
from Personas
where Persona_ID = (select(max(Persona_ID)) from Personas)

go

create proc sp_Cargar_Clientes_Desc
as
SELECT Personas.Persona_ID, Personas.Nombre, Personas.Apellido, Personas.Nro_Documento, Personas.Nro_telefono, Clientes.Estado
FROM Personas
INNER JOIN Clientes
ON Personas.Persona_ID=Clientes.Persona_ID
WHERE Personas.Fecha_Alta BETWEEN GETDATE()-7 AND GETDATE()
ORDER BY Personas.Fecha_Alta desc

go


create proc sp_Cargar_Empleados_Desc
AS
SELECT Personas.Persona_ID, Personas.Nombre, Personas.Apellido, Personas.Nro_Documento, 
	   Tipos_Empleados.Tipo, Estados_Empleados.Estado_Empleado
FROM Personas
INNER JOIN Empleados
ON Personas.Persona_ID = Empleados.Persona_ID
INNER JOIN Tipos_Empleados
ON Empleados.Tipo_Empleado_ID = Tipos_Empleados.Tipo_Empleado_ID
INNER JOIN Estados_Empleados
ON Empleados.Estado_Empleado_ID = Estados_Empleados.Estado_Empleado_ID
WHERE Personas.Fecha_Alta BETWEEN GETDATE()-7 AND GETDATE()
and Empleados.Tipo_Empleado_ID != 0
and Empleados.Tipo_Empleado_ID != 1
ORDER BY Personas.Fecha_Alta desc

go

--Desde acá creo el perfil de admin, con la clave encriptada.
insert into Personas values ('Admin', 'Admin', 0, '123456', 0, '0', null, null, null, GETDATE(), null)
insert into Empleados values (0, 'Admin', 'c4a0b7848bf1526e502f68b2c296f384d1aeee3857780b90ce2ddf7530875a27', 0, 0)



select * from Personas
select * from Empleados
select * from Jornadas_Empleados