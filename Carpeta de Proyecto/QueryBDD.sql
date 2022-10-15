create database gym_bdd

go

use gym_bdd

go

-- primero creamos las tablas que son "tipo_xxxx" que son requerimientos obligatorios
-- luego de estas tablas, podemos crear el resto en orden de requerimientos.

create table tipo_documento(
id int primary key identity (1, 1),
tipo nvarchar (10) not null
)



go

insert into tipo_documento (tipo) values ('DNI')
insert into tipo_documento (tipo) values ('LE')
insert into tipo_documento (tipo) values ('LC')
insert into tipo_documento (tipo) values ('CI')
insert into tipo_documento (tipo) values ('Pasaporte')

go

create table estado_cuota_alumno(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)  /* Esta tabla es para cada cuota de cada persona, y saber si está vencida, vigente, o pendiente  */

go

insert into estado_cuota_alumno (estado) values ('Vigente')
insert into estado_cuota_alumno (estado) values ('Pendiente')
insert into estado_cuota_alumno (estado) values ('Vencida')

go

create table estado_plan(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estado_plan (estado) values ('Vigente')
insert into estado_plan (estado) values ('Caducado')

go

create table tipo_empleado(
id int identity (1, 1) primary key,
tipo nvarchar (20) not null
)

go

insert into tipo_empleado (tipo) values ('Encargado')
insert into tipo_empleado (tipo) values ('Profesor')
insert into tipo_empleado (tipo) values ('Jefe')
insert into tipo_empleado (tipo) values ('Master')

go

create table estado_empleado(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estado_empleado (estado) values ('Activo')
insert into estado_empleado (estado) values ('Baja')
insert into estado_empleado (estado) values ('Carpeta Medica')
insert into estado_empleado (estado) values ('Vacaciones')
insert into estado_empleado (estado) values ('Otros')

go

create table estado_alumno(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estado_alumno (estado) values ('Activo')
insert into estado_alumno (estado) values ('Inactivo')
insert into estado_alumno (estado) values ('Baja')

go

create table estado_login(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estado_login (estado) values ('Vigente')
insert into estado_login (estado) values ('Baja')

go

create table estado_facturacion_alumno(
id int primary key identity (1, 1),
estado nvarchar (20) not null
) /* Estados de la facturación en general, si está todo cuota o no */

go

insert into estado_facturacion_alumno (estado) values ('Ok')
insert into estado_facturacion_alumno (estado) values ('Moroso')

go

create table concepto_cuota(
id int primary key identity (1, 1),
concepto nvarchar (20) not null
-- el concepto "cancelado" es para las cuotas que se quedan sin efecto,
-- luego de que por ejemplo, el alumno ya no asista más al gym
)

go

insert into concepto_cuota (concepto) values ('Cuota Mensual')
insert into concepto_cuota (concepto) values ('Matricula')
insert into concepto_cuota (concepto) values ('Cancelado')

go


create table login_empleado(
id int primary key identity not null,
usuario varchar(255) not null,
clave varbinary(128) not null,
estado_login int not null
)-- para la clave, vamos a utilizar función Hashbytes, que almacena el hash de la clave generada.

go

create table horarios_login(
id int primary key identity (1,1),
hora_login datetime not null,
hora_logout datetime null,
empleado_id int not null
)

go

select * from estado_login

insert into login_empleado (usuario, clave, estado_login) values ('admin' , HASHBYTES('SHA2_512', '0123456Admin'), 1)

go


create table tipo_jornada(
id int primary key identity (1, 1),
tipo nvarchar (8) not null
-- el concepto "cancelado" es para las cuotas que se quedan sin efecto,
-- luego de que por ejemplo, el alumno ya no asista más al gym
)

go

insert into tipo_jornada (tipo) values ('Master')
insert into tipo_jornada (tipo) values ('Jefe')
insert into tipo_jornada (tipo) values ('Empleado')
insert into tipo_jornada (tipo) values ('Alumno')
insert into tipo_jornada (tipo) values ('Clase')

go

-----------------------------------------
-- Se crean en resto de las tablas en orden, para que no ocurran errores
-- al momento de crearlas

create table jornada(
id int primary key identity (1, 1) not null,
todos nvarchar (13) null,
lunes nvarchar (13) null,
martes nvarchar (13) null,
miercoles nvarchar (13) null,
jueves nvarchar (13) null,
viernes nvarchar (13) null,
sabado nvarchar (13) null,
domingo nvarchar (13) null,
tipo_jornada int not null
)

select * from jornada

go

create table empleado(
id int primary key identity (1, 1) not null,
nombre nvarchar (50) not null,
tipo_documento_id int not null,
num_dni char (10) null,
telefono nvarchar (20) not null,
alternativo nvarchar (20) null,
mail nvarchar (50) null,
observaciones nvarchar (200) null,
tipo_empleado_id int not null,
estado_empleado_id int not null,
login_id int not null,
jornada_id int not null
)

go

--Si hago que las tablas empleados, alumnos y clases, tengan la foránea de los horarios
--Va a ser complicado crear cada tabla por separado.

/* Lo primero que podemos crear, al tener ya las tablas y las relaciones entre si
   Son a los empleados. Voy a crear el empleado Jefe desde acá, y luego a los empleados 
   desde el programa, para que no se pueda modificar esto.*/

/*insert into empleado (nombre, tipo_documento_id, num_dni, telefono, tipo_empleado_id, estado_empleado_id, login_id) values ('MasterAdmin', 0, '123456', '3512149461', 3, 0, 0);
*/

go

create table asistencia(
id int primary key identity (1, 1) not null,
fecha datetime not null,
estado_id int not null,
alumno_id int not null
)

go

 alter table asistencia
   add constraint fk_estado_asistencia foreign key (estado_id)
      references estado_asistencia (id)

go

create table estado_asistencia(
id int primary key identity (1,1),
estado nvarchar (15) not null
)

go

use gym_bdd

insert into estado_asistencia (estado) values ('Presente')
insert into estado_asistencia (estado) values ('Tarde')
insert into estado_asistencia (estado) values ('Ausente')

go

create table planes(
id int primary key identity (1, 1) not null,
nombre_plan nvarchar (30) null,
costo decimal (18, 2) null,
cupo_total int not null,
cupo_restante int null,
estado_plan_id int not null,
usuario_id int not null,
jornada_id int not null
)

go

create table cuota(
id int primary key identity (1, 1) not null,
importe decimal (18, 2) not null,
fecha_emision datetime not null, -- mes al que corresponde la cuota
fecha_vencimiento datetime not null,
fecha_cuota datetime null,
concepto_id int not null,
estado_cuota_id int not null,
alumno_id int not null,
login_id int not null -- el login de quien tomó el cuota
)

go

create table alumno(
id int primary key identity (1, 1) not null,
nombre nvarchar (50) not null,
tipo_documento_id int not null,
num_dni char (10) not null,
telefono nvarchar (20) not null,
alternativo nvarchar (20) null,
mail nvarchar (50) not null,
fecha_inscripcion datetime not null,
observaciones nvarchar (200) not null,
plan_id int not null,
estado_alumno_id int not null,
estado_facturacion_id int not null,
login_id int not null, -- este campo es una huella del empleado que le dió el alta al alumno
jornada_id int not null
)

go

create table caja(
id int primary key identity (1, 1) not null,
abierta Bit not null, -- 0 para falso y 1 para verdadero que la caja está abierta
monto_apertura_efectivo decimal (18, 2) null,
fecha_apertura datetime not null,
login_id int not null
)

/*  Datos de la apertura de caja

id
abierta         para identificar la apertura
monto_apertura  para el cambio
fecha_apertura  
login_id        del usuario que la abrió
fecha_cierre    para el cierre de la caja de cada turno



*/



go

create table cierre_caja(
id int primary key identity (1, 1) not null,
caja_cerrada bit not null, -- 0 para falso y 1 para verdadero que la caja está abierta
apertura_caja_id int not null,
monto_cierre_efectivo decimal (18, 2) null,
monto_cierre_caja decimal (18, 2) null,
fecha_cierre datetime null
)
go

ALTER TABLE cierre_caja
ADD login_id int not null

go

	  alter table cierre_caja
   add constraint fk_apertura_cierre_caja foreign key (login_id)
      references login_empleado (id)

go

	/*alter table TablaDondeEstaFK
   add constraint NombreDeLaRestriccion foreign key (ColumnaFK)
      references TablaDondeEstaPK (ColumnaPK)*/

		/*FK alumno*/

	  alter table alumno
   add constraint fk_tipoDoc_alumno foreign key (tipo_documento_id)
      references tipo_documento (id)

	  go

	  alter table alumno
   add constraint fk_planes_alumno foreign key (plan_id)
      references planes (id)

	  go

	  alter table alumno
   add constraint fk_estado_alumno foreign key (estado_alumno_id)
      references estado_alumno (id)

	  go

	  alter table alumno
   add constraint fk_estadoFac_alumno foreign key (estado_facturacion_id)
      references estado_facturacion_alumno (id)

	  go

	  alter table alumno
   add constraint fk_login_alumno foreign key (login_id)
      references login_empleado (id)

	  go

	  alter table alumno
   add constraint fk_jornada_alumno foreign key (jornada_id)
      references jornada (id)

	  /*fk empleado*/

	  alter table empleado
   add constraint fk_tipoDoc_empleado foreign key (tipo_documento_id)
      references tipo_documento (id)

	  go

	  alter table empleado
   add constraint fk_tipo_empleado foreign key (tipo_empleado_id)
      references tipo_empleado (id)

	  go

	  alter table empleado
   add constraint fk_estado_empleado foreign key (estado_empleado_id)
      references estado_empleado (id)

	  go

	  alter table empleado
   add constraint fk_login_empleado foreign key (login_id)
      references login_empleado (id)

	  go

	  alter table empleado
   add constraint fk_jornada_empleado foreign key (jornada_id)
      references jornada (id)
	  
	  go

	  /*fk Planes*/
	  
	  alter table planes
   add constraint fk_estado_plan foreign key (estado_plan_id)
      references estado_plan (id)

	  go

	  alter table planes
   add constraint fk_login_plan foreign key (login_id)
      references login_empleado (id)

	  go

	  alter table planes
   add constraint fk_jornada_plan foreign key (jornada_id)
      references jornada (id)
	  
	  go

	  /*fk cuota*/
	  	   
	  alter table cuota
   add constraint fk_concepto_cuota foreign key (concepto_id)
      references concepto_cuota (id)

	  go

	  alter table cuota
   add constraint fk_estado_cuota foreign key (estado_cuota_id)
      references estado_cuota_alumno (id)

	  go

	  alter table cuota
   add constraint fk_alumno_cuota foreign key (alumno_id)
      references alumno (id)

	  go

	  alter table cuota
   add constraint fk_login_cuota foreign key (login_id)
      references login_empleado (id)

	  go

	  /*fk apertura_caja*/

	  alter table apertura_caja
   add constraint fk_login_apertura foreign key (login_id)
      references login_empleado (id)

	  go

	  /*fk cierre_caja*/

	  alter table cierre_caja
   add constraint fk_apertura_cierre foreign key (apertura_caja_id)
      references apertura_caja (id)

	  go

	  /*fk login_empleado*/

	  alter table login_empleado
   add constraint fk_estado_login foreign key (estado_login)
      references estado_login (id)

	  go

	  /*fk asistencia*/

	  alter table asistencia
   add constraint fk_alumno_asistencia foreign key (alumno_id)
      references alumno (id)

	   go

	  /*fk jornada*/

	  alter table jornada
   add constraint fk_tipo_jornada foreign key (tipo_jornada)
      references tipo_jornada (id)
	  

	  /*procedimientos almacenados para consultas rápidas*/

	GO

	use gym_bdd

	CREATE PROCEDURE sp_bringLastLogin  
	AS 
    select id from login_empleado where id = (select max(id) from login_empleado) 
	GO  

	exec sp_bringLasLogin

	  /**/


use gym_bdd

go

create procedure sp2_cargar_tipo_empleado
as
select * from tipo_empleado
go

exec sp2_cargar_tipo_empleado

select tipo from tipo_empleado

go

create procedure sp_cargar_tipo_documento
as
select * from tipo_documento
go

exec sp_cargar_tipo_document

select * from empleado

select * from jornada

/*

crear un procedimiento almacenado, donde se pueda consultar por un login,
y que lo traiga si este empleado sigue de alta, o sigue vigente
No puede traerlo si está de vacaciones, o si está de licencia médica, psiquiátrica
o si ya no forma parte del equipo del gym (desempleado)

*/