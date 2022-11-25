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
Nro_documento varchar(50) not null,
Tipo_Sexo_ID int not null,
Nro_Telefono nvarchar(24) not null,
Nro_Alternativo nvarchar(24) null,
Mail nvarchar(50) null,
Observaciones nvarchar(200) null,
Fecha_Alta date not null,
Fecha_Baja date null,
)

go

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
Estado nvarchar(1) not null
)


go

create table Asistencias(
Asistencia_ID int primary key identity (0, 1),
Fecha date not null,
Estado nvarchar(1) not null, --P(resente), T(arde), A(usente)
Cliente_ID int not null,
Empleado_ID int not null, --quien hizo el registro
Plan_Asignado_ID int not null
)

go

/* 
   Falta tabla donde se guarde cada persona durante cada fecha de clase 
   Falta una tabla que maneje fechas
   1 Tabla: (por día de clase)
   alumno, fechaInscripción, anulaPlan, fechaAnulacion (del día del turno) y asistencia 
   2 Tabla: Generar distintos horarios para cada fecha.
   Jornadas, Planes
*/
-- fecha de alta generación de plan, falta en PlanAsignado
-- 

/* Caja */

create table Cajas(
Caja_ID int primary key identity (0, 1),
Empleado_ID_Apertura int not null,
Empleado_ID_Cierre int null,
Fecha datetime not null,
Importe_Inicial decimal(18,0) not null,
Importe_Final decimal(18,0) null,
)

go

create table Detalles_Cajas(
Detalle_Caja_ID int primary key identity (0, 1),
Caja_ID int not null,
Plan_Asignado_ID int null,
Empleado_ID int not null,
Importe_Ingreso decimal (18, 0) null,
Importe_Egreso decimal (18, 0) null,
Motivo nvarchar(50) null,
Observaciones nvarchar(200) null,
)

go

--Se complica realizar un inner join de las cuotas,
--debido a los ID. Por lo que se va a modificar y este 
--ID de persona, va a corresponder al cliente.
create table Cuotas(
Cuota_ID int primary key identity (0, 1),
Plan_Asignado_ID int not null,
Empleado_ID int not null,
Cliente_ID int not null,
Detalle_Caja_ID int null,
Importe_Cuota decimal(18, 0) not null,
Saldo decimal(18, 0) not null,
Vto_Cuota date not null
)

go

/* Planes */

create table Planes(
Plan_ID int primary key identity (0, 1),
Persona_ID int not null, /*quien hace el registro*/
Empleado_ID int null,  /* el profesor */
Nombre nvarchar(20) not null,
Importe_Plan decimal (18, 0) not null,
Duracion int null,
Cupo_Total int null,
Cupo_Restante int null,
Fecha_Inicio date null,  /* fecha de inicio */
Fecha_Fin date null,     /* fecha de cierre */
Estado nvarchar (1) not null,
Fecha_Alta_Plan date null
)

go

create table Planes_Asignados(
Plan_Asignado_ID int primary key identity (0, 1),
Plan_ID int not null,
Cliente_ID int not null,
Empleado_ID int not null,
Fecha_Inscripcion date not null,
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
Empleado_ID int not null,
Importe decimal(18, 0) not null,
Fecha_Emision date not null,
Fecha_Vencimiento date not null,
Saldo decimal (18, 0) not null --Acá se le agregaría la facturación anterior.
)

go

/* Jornadas */

create table Jornadas_Planes(
Jornada_Plan_ID int primary key identity (0, 1),
Plan_ID int not null,
Dia nvarchar(10) not null,
Desde_Hora datetime not null,
Hasta_Hora datetime not null,
Estado nvarchar(1) not null
)

go

create table Jornadas_Empleados(
Jornada_Empleado_ID int primary key identity (0, 1),
Empleado_ID int not null,
Dia nvarchar(10) not null,
Desde_Hora datetime not null,
Hasta_Hora datetime not null,
Estado nvarchar(1) not null
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
add CONSTRAINT FK_Detalles_Cajas_Empleado FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

/* Cuotas */ 

alter table Cuotas
add CONSTRAINT FK_Cuotas_Plan_Asignado FOREIGN KEY (Plan_Asignado_ID) 
REFERENCES Planes_Asignados (Plan_Asignado_ID)

go
use gym
alter table Cuotas
add CONSTRAINT FK_Cuotas_Clientes FOREIGN KEY (Cliente_ID) 
REFERENCES Clientes (Cliente_ID)

go

alter table Cuotas
add CONSTRAINT FK_Cuotas_Empleados FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

alter table Cuotas
add CONSTRAINT FK_Nombre_Detalles_Cajas FOREIGN KEY (Detalle_Caja_ID) 
REFERENCES Detalles_Cajas (Detalle_Caja_ID)

go

/* Planes */

alter table Planes
add CONSTRAINT FK_Planes_Persona_Logueada FOREIGN KEY (Persona_ID) 
REFERENCES Personas (Persona_ID)

go

alter table Planes
add CONSTRAINT FK_Planes_Profesor_De_La_Clase FOREIGN KEY (Empleado_ID) 
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

alter table Facturas_Clientes
add CONSTRAINT FK_Facturas_Clientes_Cliente FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

/* Jornadas_Planes  */

alter table Jornadas_Planes 
add CONSTRAINT FK_Jornada_Planes FOREIGN KEY (Plan_ID) 
REFERENCES Planes (Plan_ID)

go

/* Jornada_Empleados */

alter table Jornadas_Empleados
add CONSTRAINT FK_Jornada_Empleados FOREIGN KEY (Empleado_ID) 
REFERENCES Empleados (Empleado_ID)

go

/* Registro de Login */

alter table Registros_Logs
add CONSTRAINT FK_Registros_Logs_Empleado FOREIGN KEY (Empleado_ID) 
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
select Tipo, Tipo_Empleado_ID
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


create proc sp_cargar_Profesores_Actuales
as
select Personas.Nombre, Empleados.Empleado_ID
from Personas
inner join Empleados
on Empleados.Persona_ID = Personas.Persona_ID
inner join Tipos_Empleados
on Empleados.Tipo_Empleado_ID = Tipos_Empleados.Tipo_Empleado_ID
where Tipos_Empleados.Tipo = 'Profesor'
and Empleados.Estado_Empleado_ID = 0

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
SELECT Clientes.Cliente_ID, Personas.Persona_ID, Personas.Nombre, Personas.Apellido, Personas.Nro_Documento, Personas.Nro_telefono, Clientes.Estado
FROM Personas
INNER JOIN Clientes
ON Personas.Persona_ID=Clientes.Persona_ID
WHERE Personas.Fecha_Alta BETWEEN GETDATE()-7 AND GETDATE()
and Estado = 'A'
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

create procedure sp_last_Login
as
select Registro_Log_ID
from Registros_Logs
where Registro_Log_ID = (select(max(Registro_Log_ID)) from Registros_Logs)

go

create proc sp_cargar_planes
as
select Plan_ID, Nombre
from Planes
where Estado = 'A'

go

create procedure sp_cargar_planes_Actuales
as
select Planes.Plan_ID as Plan_ID, Planes.Nombre as Nombre_Planes, Personas.Nombre as Nombre_Empleado, replace(Planes.Estado, 'A', 'Activo') as Estado
from Planes
inner join Empleados
on Empleados.Empleado_ID = Planes.Empleado_ID
inner join Personas
on Personas.Persona_ID = Empleados.Persona_ID
inner join Tipos_Empleados
on Empleados.Tipo_Empleado_ID = Tipos_Empleados.Tipo_Empleado_ID
where Planes.Estado = 'A'
and Tipos_Empleados.Tipo = 'Profesor'
or Planes.Estado = (select replace(Planes.Estado, 'I', 'Inactivo') as Estado)

go

create procedure sp_Get_Last_Caja_ID
as
select Caja_ID from Cajas
where Caja_ID = (select max(Caja_ID) from Cajas)
and Importe_Final = null

go

create procedure sp_get_cajas
as
select Cajas.Caja_ID, Cajas.Fecha, Cajas.Importe_Inicial, Cajas.Importe_Final, Personas.Nombre
from Cajas
inner join Empleados
on Empleados.Empleado_ID = Cajas.Empleado_ID
inner join Personas
on Empleados.Persona_ID = Personas.Persona_ID
order by Cajas.Fecha desc

go

create procedure sp_get_Asistencias_diarias
as
select Clientes.Cliente_ID, Personas.Nombre, Personas.Apellido, Personas.Nro_documento, Planes.Nombre, Asistencias.Estado
from Asistencias
inner join Clientes
on Clientes.Cliente_ID = Asistencias.Cliente_ID
inner join Personas
on Clientes.Persona_ID = Personas.Persona_ID
inner join Planes_Asignados
on Asistencias.Plan_Asignado_ID = Planes_Asignados.Plan_Asignado_ID
inner join Planes
on Planes.Plan_ID = Planes_Asignados.Plan_ID
where Asistencias.Fecha between GETDATE() - 1 and GETDATE()
order by Asistencias.Fecha desc

go

/* Tablas de consulta interna */

--set dateformat dmy;
--select Personas.Nombre + ' ' + Personas.Apellido as Nombre, Clientes.Cliente_ID
--from Personas
--inner join Clientes
--    on Clientes.Persona_ID = Personas.Persona_ID
--inner join Planes_Asignados
--    on Planes_Asignados.Cliente_ID = Clientes.Cliente_ID
--inner join Planes
--    on Planes.Plan_ID = Planes_Asignados.Plan_ID
--inner join Asistencias
--on Asistencias.Cliente_ID = Clientes.Cliente_ID
--where Planes_Asignados.Estado like 'A'
--and Clientes.Estado = 'A'
--and Planes.Plan_ID = 0
--and Asistencias.Fecha = '22/11/2022'


--use gym

set dateformat dmy;

select Planes.Plan_ID, Planes.Nombre, Jornadas_Planes.Dia
from Planes
inner join Jornadas_Planes
on Jornadas_Planes.Plan_ID = Planes.Plan_ID
where Planes.Estado = 'A'
and Planes.Fecha_Inicio <= '21/11/2022'
and Jornadas_Planes.Dia = 'Todos'
or Jornadas_Planes.Dia = 'Lunes'

select * from Planes
select * from Jornadas_Planes


set dateformat dmy;
if exists (select max(Importe_Final) from Cajas where Importe_Final != null or Importe_Final != 0 and Fecha = '23/11/2022' and Empleado_ID_Apertura = 0)
begin
select max(Importe_Final) as Resultado from Cajas where Importe_Final != null or Importe_Final != 0 and Fecha = '23/11/2022' and Empleado_ID_Apertura = 0
end

if exists (select Caja_ID from Cajas
where Caja_ID = (select max(Caja_ID) from Cajas)
and Importe_Final = null)
begin 
select Caja_ID as Caja_ID from Cajas
where Caja_ID = (select max(Caja_ID) from Cajas)
and Importe_Final = null
end
