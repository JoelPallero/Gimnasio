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

create table estados_cuotas(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estados_cuotas (estado) values ('Vigente')
insert into estados_cuotas (estado) values ('Paga')
insert into estados_cuotas (estado) values ('Adeudada')

go

create table estados_plan(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estados_plan (estado) values ('Actual')
insert into estados_plan (estado) values ('Modificado')
insert into estados_plan (estado) values ('Baja')

go

create table tipos_empleado(
id int identity (1, 1) primary key,
tipo nvarchar (20) not null
)

go

insert into tipos_empleado (tipo) values ('Encargado')
insert into tipos_empleado (tipo) values ('Profesor')
insert into tipos_empleado (tipo) values ('Jefe')
insert into tipos_empleado (tipo) values ('Master')

go

create table estados_empleados(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estados_empleados (estado) values ('Activo')
insert into estados_empleados (estado) values ('Baja')
insert into estados_empleados (estado) values ('Carpeta Medica')
insert into estados_empleados (estado) values ('Vacaciones')
insert into estados_empleados (estado) values ('Otros')

go

create table estados_alumnos(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estados_alumnos (estado) values ('Activo')
insert into estados_alumnos (estado) values ('Inactivo')
insert into estados_alumnos (estado) values ('Baja')

go

create table estado_login(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estado_login (estado) values ('Vigente')
insert into estado_login (estado) values ('Baja')

go

create table estados_facturacion(
id int primary key identity (1, 1),
estado nvarchar (20) not null
)

go

insert into estados_facturacion (estado) values ('Pagado')
insert into estados_facturacion (estado) values ('Adeudado')
insert into estados_facturacion (estado) values ('Cancelado')

go

create table concepto_pago(
id int primary key identity (1, 1),
concepto nvarchar (20) not null
-- el concepto "cancelado" es para las cuotas que se quedan sin efecto,
-- luego de que por ejemplo, el alumno ya no asista más al gym
)

go

insert into concepto_pago (concepto) values ('Cuota Mensual')
insert into concepto_pago (concepto) values ('Matricula')
insert into concepto_pago (concepto) values ('Cancelado')

go

create table login_empleados(
id int primary key identity not null,
usuario varchar(255) not null,
clave varbinary(128) not null,
estado_login int not null,
open_session bit not null
)-- para la clave, vamos a utilizar función Hashbytes, que almacena el hash de la clave generada.

go

insert into login_empleados (usuario, clave, estado_login) values ('admin' , HASHBYTES('SHA2_512', '0123456Admin'), 0)

go

-----------------------------------------
-- Se crean en resto de las tablas en orden, para que no ocurran errores
-- al momento de crearlas

create table jornadas(
id int primary key identity (1, 1) not null,
todos nvarchar (13) null,
lunes nvarchar (13) null,
martes nvarchar (13) null,
miercoles nvarchar (13) null,
jueves nvarchar (13) null,
viernes nvarchar (13) null,
sabado nvarchar (13) null,
)

go

create table empleados(
id int primary key identity (1, 1) not null,
nombre nvarchar (50) not null,
tipo_documento_id int not null,
num_dni char (10) null,
telefono nvarchar (20) not null,
alternativo nvarchar (20) null,
mail nvarchar (50) null,
observaciones nvarchar (200) null,
jornada_id int not null,
tipo_empleado_id int not null,
estado_empleado_id int not null,
login_id int not null
)

go

insert into empleados (nombre, tipo_documento_id, num_dni, telefono, tipo_empleado_id, estado_empleado_id, login_id) values ('MasterAdmin', 0, '123456', 3512149461, 3, 0, 0);


go

create table planes(
id int primary key identity (1, 1) not null,
nombre_plan nvarchar (30) null,
importe decimal (18, 2) null,
estado_plan_id int not null,
jornada_id int not null,
empleado_id int not null -- login de quien cargó el plan
)

go

create table pagos(
id int primary key identity (1, 1) not null,
importe decimal (18, 2) not null,
fecha_emision datetime not null, -- mes al que corresponde la cuota
fecha_vencimiento datetime not null,
fecha_pago datetime null,
concepto_id int not null,
estado_cuota_id int not null,
alumno_id int not null,
empleado_id int not null -- el login de quien tomó el pago
)

go

create table alumnos(
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
empleado_id int not null -- este campo es una huella del empleado que le dió el alta al alumno
)

go

create table apertura_caja(
id int primary key identity (1, 1) not null,
caja_abierta bit not null, -- 0 para falso y 1 para verdadero que la caja está abierta
monto_apertura_efectivo decimal (18, 2) null,
fecha_apertura datetime not null,
login_id int not null
)

go

create table cierre_caja(
id int primary key identity (1, 1) not null,
caja_cerrada bit not null, -- 0 para falso y 1 para verdadero que la caja está abierta
caja_abierta_id bit not null,
monto_cierre_efectivo decimal (18, 2) null,
monto_cierre_caja decimal (18, 2) null,
fecha_cierre datetime null,
login_id int not null
)


select * from empleados