use pruebas 

go

drop database gym

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
Fecha datetime not null,
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
Fecha_Apertura date not null,
Hora_Apertura time null,
Importe_Apertura decimal(18,0) not null,
Caja_Abierta bit not null,
Empleado_ID_Cierre int null,
Fecha_Cierre date null,
Hora_Cierre time null,
Importe_Cierre decimal(18,0) null,
Importe_Cierre_Caja decimal (18, 0) null
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
Estado nvarchar (1) not null,
Fecha_Alta_Plan date null,
Fecha_Inicio date null,  /* fecha de inicio */
Fecha_Fin date null     /* fecha de cierre */
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

insert into Tipos_Sexos values ('Mdesculino', 'Activo')
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
add CONSTRAINT FK_Cajas_Empleado_Apertura FOREIGN KEY (Empleado_ID_Apertura) 
REFERENCES Empleados (Empleado_ID)

go

alter table Cajas
add CONSTRAINT FK_Cajas_Empleado_Cierre FOREIGN KEY (Empleado_ID_Cierre) 
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

--alter table Facturas_Clientes
--add CONSTRAINT FK_Facturas_Clientes_Constrain FOREIGN KEY (Plan_Asignado_ID) 
--REFERENCES Planes_Asignados (Plan_Asignado_ID)

--go

--alter table Facturas_Clientes
--add CONSTRAINT FK_Facturas_Clientes_Cliente FOREIGN KEY (Empleado_ID) 
--REFERENCES Empleados (Empleado_ID)

--go

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
select p.Nombre, e.Empleado_ID
from Personas as p
inner join Empleados as e
on e.Persona_ID = p.Persona_ID
inner join Tipos_Empleados as tp
on e.Tipo_Empleado_ID = tp.Tipo_Empleado_ID
where tp.Tipo = 'Profesor'
and e.Estado_Empleado_ID = 0

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
SELECT c.Cliente_ID, 
p.Persona_ID, p.Nombre, p.Apellido, p.Nro_Documento, p.Nro_telefono, 
c.Estado
FROM Personas as p
INNER JOIN Clientes as c
ON p.Persona_ID = c.Persona_ID
WHERE p.Fecha_Alta BETWEEN GETDATE()-7 AND GETDATE()
and c.Estado = 'A'
ORDER BY p.Fecha_Alta desc

go

create proc sp_Cargar_Empleados_Desc
AS
SELECT p.Persona_ID, p.Nombre, p.Apellido, p.Nro_Documento, 
	   tp.Tipo, ep.Estado_Empleado
FROM Personas as p
INNER JOIN Empleados as em
ON p.Persona_ID = em.Persona_ID
INNER JOIN Tipos_Empleados tp
ON em.Tipo_Empleado_ID = tp.Tipo_Empleado_ID
INNER JOIN Estados_Empleados as ep
ON em.Estado_Empleado_ID = ep.Estado_Empleado_ID
WHERE p.Fecha_Alta BETWEEN GETDATE()-7 AND GETDATE()
and em.Tipo_Empleado_ID != 0
and em.Tipo_Empleado_ID != 1
ORDER BY p.Fecha_Alta desc

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
select pl.Plan_ID, pl.Nombre, p.Nombre, replace(pl.Estado, 'A', 'Activo') as Estado
from Planes as pl
inner join Empleados as e
on e.Empleado_ID = pl.Empleado_ID
inner join Personas as p
on p.Persona_ID = e.Persona_ID
inner join Tipos_Empleados tp
on e.Tipo_Empleado_ID = tp.Tipo_Empleado_ID
where pl.Estado = 'A'
and tp.Tipo = 'Profesor'
or pl.Estado = (select replace(pl.Estado, 'I', 'Inactivo') as Estado)

go

create procedure sp_get_Asistencias_diarias
as
select c.Cliente_ID, pe.Nombre, pe.Apellido, pe.Nro_documento, pl.Nombre, a.Estado
from Asistencias as a
inner join Clientes as c
on c.Cliente_ID = a.Cliente_ID
inner join Personas as pe
on c.Persona_ID = pe.Persona_ID
inner join Planes_Asignados as pa
on a.Plan_Asignado_ID = pa.Plan_Asignado_ID
inner join Planes as pl
on pl.Plan_ID = pa.Plan_ID
where a.Fecha between GETDATE() - 1 and GETDATE()
order by a.Fecha desc

go

create procedure sp_Buscar_Listado_Asistencia_Total @Parametro nvarchar
as
begin
select distinct(c.Cliente_ID) as Cliente_ID, p.Nombre, p.Apellido, p.Nro_documento, pl.Nombre, a.Estado
from Asistencias as a
inner join Clientes as c
on c.Cliente_ID = a.Cliente_ID
inner join Personas as p
on c.Persona_ID = p.Persona_ID
inner join Planes_Asignados pa
on a.Plan_Asignado_ID = pa.Plan_Asignado_ID
inner join Planes pl
on pl.Plan_ID = pa.Plan_ID
where p.Nombre like @Parametro
or p.Apellido like @Parametro
or a.Fecha like @Parametro
or pl.Nombre like @Parametro
end

go

create procedure sp_get_cajas
as
select c.Caja_ID, c.Fecha_Apertura, c.Importe_Apertura, c.Importe_Cierre,
dc.Importe_Ingreso, dc.Importe_Egreso, dc.Motivo, 
p.Apellido
from Cajas as c
left join Detalles_Cajas as dc
on dc.Caja_ID = c.Caja_ID
and dc.Empleado_ID = c.Empleado_ID_Apertura
left join Empleados as em
on em.Empleado_ID = c.Empleado_ID_Apertura
inner join Personas as p
on p.Persona_ID = em.Persona_ID
order by c.Fecha_Apertura desc

go


create procedure sp_Cargar_Presentes @Plan_ID int, @Fecha date
as
begin
set dateformat dmy;
Select p.Nombre + ' ' + p.Apellido as NombreCliente, c.Cliente_ID as Cliente_ID
from Personas as p
left join Clientes as c
on p.Persona_ID = c.Persona_ID
inner join Planes_Asignados as pa
on c.Cliente_ID = pa.Cliente_ID
inner join Planes as pl
on pa.Plan_ID = pl.Plan_ID
left join Asistencias as a
on a.Cliente_ID = c.Cliente_ID
where pl.Plan_ID = @Plan_ID
and a.Fecha = @Fecha
and a.Cliente_ID is not null
end

go

create procedure sp_Cargar_Ausentes @Plan_ID int, @Fecha date
as
begin
set dateformat dmy;
Select  p.Nombre + ' ' + p.Apellido as NombreCliente, c.Cliente_ID
from Personas as p
inner join Clientes as c
on p.Persona_ID = c.Persona_ID
inner join Planes_Asignados as pa
on c.Cliente_ID = pa.Cliente_ID
inner join Planes as pl
on pa.Plan_ID = pl.Plan_ID
where pl.Plan_ID = @Plan_ID
and c.Cliente_ID not in (select Cliente_ID from Asistencias where Fecha = @Fecha)
end

go

create procedure sp_Buscar_Cliente_Ausentismo @buscar nvarchar
as
begin
select pa.Plan_Asignado_ID, c.Cliente_ID,
p.Nombre, p.Apellido, p.Nro_documento, p.Nro_Telefono, p.Mail,
pl.Nombre
from Personas as p
inner join Clientes c
on c.Persona_ID = p.Persona_ID
inner join Planes_Asignados as pa
on c.Cliente_ID = pa.Cliente_ID
inner join Planes as pl
on pa.Plan_ID = pl.Plan_ID
where pa.Estado = 'A'
and c.Estado = 'A'
and p.Nro_documento like @buscar
end

go


create procedure sp_Buscar_Cliente_Por_ID @Plan_ID int, @Cliente_ID int
as
begin
select pa.Plan_Asignado_ID, c.Cliente_ID,
p.Nombre, p.Apellido, p.Nro_documento, p.Nro_Telefono, p.Mail,
pl.Nombre
from Personas as p
inner join Clientes as c
on c.Persona_ID = p.Persona_ID
inner join Planes_Asignados as pa
on c.Cliente_ID = pa.Cliente_ID
inner join Planes pl
on pa.Plan_ID = pl.Plan_ID
where pa.Estado = 'A'
and c.Estado = 'A'
and pa.Plan_ID = @Plan_ID
and c.Cliente_ID = @Cliente_ID
end

go

create procedure sp_Buscar_Listado_Clientes @query nvarchar
as
begin
SELECT c.Cliente_ID, p.Persona_ID, p.Nombre,
p.Apellido, p.Nro_Documento, p.Nro_telefono,
c.Estado
FROM Personas as p
INNER JOIN Clientes as c
ON p.Persona_ID = c.Persona_ID
where p.Nombre LIKE @query 
or p.Apellido LIKE @query
or p.Nro_Documento LIKE @query
or c.Estado LIKE @query
and c.Estado = 'A'
Order by p.Fecha_Alta desc
end

go

create procedure sp_Calcular_Importes @Caja_ID int
as
begin
select Importe_Apertura from Cajas where Caja_ID = @Caja_ID and Fecha_Apertura = GETDATE();
select sum(Importe_Ingreso) as Importe_Ingreso from Detalles_Cajas where Caja_ID = @Caja_ID;
select sum(Importe_Egreso) as Importe_Egreso from Detalles_Cajas where Caja_ID = @Caja_ID;
select sum(Importe_Ingreso - Importe_Egreso) as Total from Detalles_Cajas where Caja_ID = @Caja_ID;
end


go

--create procedure sp_GetCajas_Y_Detalles @Parametro nvarchar
--as 
--begin
--select c.Caja_ID, c.Fecha_Apertura, c.Importe_Apertura, c.Importe_Cierre,
--    dc.Importe_Ingreso, dc.Importe_Egreso, dc.Motivo, 
--    p.Apellido
--from Detalles_Cajas as dc
--inner join Cajas as c
--    on c.Caja_ID = dc.Caja_ID
--inner join Empleados as em
--    on em.Empleado_ID = dc.Empleado_ID
--inner join Personas as p
--    on p.Persona_ID = em.Persona_ID
--where c.Caja_ID like @Parametro 
--    or c.Fecha_Apertura like @Parametro
--    or p.Apellido like @Parametro
--    or dc.Motivo like @Parametro
--order by c.Fecha_Apertura desc
--end

go

create procedure sp_cargar_Plan_unico @Estado nvarchar, @Profesor nvarchar, @Parametro nvarchar
as begin
select pl.Plan_ID, pl.Nombre as Nombre_Planes, p.Nombre as Nombre_Empleado, replace(pl.Estado, 'A', 'Activo') as Estado
from Planes as pl
inner join Empleados em
on em.Empleado_ID = pl.Empleado_ID
inner join Personas as p
on p.Persona_ID = em.Persona_ID
inner join Tipos_Empleados as tp
on em.Tipo_Empleado_ID = tp.Tipo_Empleado_ID
where pl.Estado = @Estado
and tp.Tipo = @Profesor
or pl.Estado = (select replace(pl.Estado, 'I', 'Inactivo') as Estado)
and pl.Nombre Like @Parametro
or p.Nombre like @Parametro
or pl.Estado like @Parametro
end

go

create procedure sp_Get_Last_Caja_ID @Fecha date
as begin
select max(Caja_ID) as Caja_ID from Cajas 
where Caja_Abierta = 1
and Fecha_Apertura = @Fecha
end

go

/* queries para realizar registros */

create procedure sp_abrir_caja @Empleado_ID_Apertura int, @Fecha datetime, @Importe_Apertura decimal, @Caja_Abierta bit
as
insert into Cajas (Empleado_ID_Apertura, Fecha_Apertura, Hora_Apertura, Importe_Apertura, Caja_Abierta) 
values(@Empleado_ID_Apertura, @Fecha, @Fecha, @Importe_Apertura, @Caja_Abierta)

go

create procedure sp_Cerrar_Caja @Empleado_ID_Cierre int, @Fecha_Cierre DateTime, @Importe_Cierre decimal, @Importe_Cierre_Caja decimal, @Caja_ID int, @Caja_Abierta bit
as
begin
update Cajas set 
Empleado_ID_Cierre = @Empleado_ID_Cierre,
Fecha_Cierre = @Fecha_Cierre,
Hora_Cierre = @Fecha_Cierre,
Importe_Cierre = @Importe_Cierre,
Importe_Cierre_Caja = @Importe_Cierre_Caja,
Caja_Abierta = @Caja_Abierta
where Caja_ID = @Caja_ID
end

/* - - */


/*  Pruebas  */

select max(Caja_ID) as Caja_ID from Cajas 
where Fecha_Apertura = getdate()
and Caja_Abierta = 1


select * from Cajas

exec sp_Get_Last_Caja_ID

/*  Fin Pruebas  */