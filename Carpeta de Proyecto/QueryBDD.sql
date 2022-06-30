create database gym_bdd

go

use gym_bdd

go

-- primero creamos las tablas que son "tipo_xxxx" que son requerimientos obligatorios
-- luego de estas tablas, podemos crear el resto en orden de requerimientos.

create table tipo_documento(
id int primary key identity not null,
tipo_documento nvarchar (10) not null,
check (tipo_documento in ('DNI', 'LE', 'LC', 'CI', 'Pasaporte'))
)

go

create table estados_cuotas(
id int primary key identity not null,
estado nvarchar (20) not null,
check (estado in ('Vigente', 'Paga', 'Adeudada'))
)

go

create table estados_plan(
id int primary key identity not null,
estado nvarchar (20) not null,
check (estado in ('Actual', 'Modificado', 'Baja'))
)

go

create table Tipos_empleado(
id int primary key identity not null,
tipo_empleado nvarchar (20) not null,
check (tipo_empleado in ('Encargado', 'Profesor', 'Jefe'))
)

go

create table estados_empleados(
id int primary key identity not null,
estado nvarchar (20) not null,
check (estado in ('Activo', 'Baja', 'Carpeta Medica', 'Vacaciones', 'Otros'))
)

go

create table estados_alumnos(
id int primary key identity not null,
estado nvarchar (20) not null,
check (estado in ('Activo', 'Inactivo', 'Baja'))
)

go

create table estado_login(
id int primary key identity not null,
estado nvarchar (20) not null,
check (estado in ('Vigente', 'Baja'))
)

go

create table estados_facturacion(
id int primary key identity not null,
estado nvarchar (20) not null,
check (estado in ('Pagado', 'Adeudado', 'Cancelado'))
)

go

create table concepto_pago(
id int primary key identity not null,
concepto nvarchar (20) not null,
check (concepto in ('Cuota Mensual', 'Matricula', 'Cancelado'))
-- el concepto "cancelado" es para las cuotas que se quedan sin efecto,
-- luego de que por ejemplo, el alumno ya no asista más al gym
)

go

create table login_empleados(
id int primary key identity not null,
usuario varchar(255) not null,
clave varbinary(MAX) not null,
estado_clave int not null
)-- Para esto se tiene las funciones PWDENCRYPT (guardar clave encriptada) y PWDCOMPARE(comparar clave encriptada)

go

-----------------------------------------
-- Se crean en resto de las tablas en orden, para que no ocurran errores
-- al momento de crearlas

create table jornadas_clases(
id int primary key identity not null,
todos nvarchar (13) null,
lunes nvarchar (13) null,
martes nvarchar (13) null,
miercoles nvarchar (13) null,
jueves nvarchar (13) null,
viernes nvarchar (13) null,
sabado nvarchar (13) null,
plan_id int null
)

go

create table jornadas_empleado(
id int primary key identity not null,
todos nvarchar (13) null,
lunes nvarchar (13) null,
martes nvarchar (13) null,
miercoles nvarchar (13) null,
jueves nvarchar (13) null,
viernes nvarchar (13) null,
sabado nvarchar (13) null,
empleado_id int null
)

go

create table empleados(
id int primary key identity not null,
nombre nvarchar (50) not null,
tipo_documento_id int not null,
num_dni char (10) not null,
telefono nvarchar (20) not null,
alternativo nvarchar (20) null,
mail nvarchar (50) not null,
observaciones nvarchar (200) not null,
tipo_empleado_id int not null,
estado_empleado_id int not null,
login_id int not null
)

go

create table planes(
id int primary key identity not null,
nombre_plan nvarchar (30) null,
importe decimal (18, 2) null,
estado_plan_id int not null,
empleado_id int not null -- login de quien cargó el plan
)

go

create table pagos(
id int primary key identity not null,
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
id int primary key identity not null,
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
tipo_facturacion_id int not null,
empleado_id int not null -- este campo es una huella del empleado que le dió el alta al alumno
)

go

create table apertura_caja(
Id int primary key identity not null,
caja_abierta bit not null, -- 0 para falso y 1 para verdadero que la caja está abierta
monto_apertura_efectivo decimal (18, 2) null,
fecha_apertura datetime not null,
login_id int not null
)

go

create table cierre_caja(
Id int primary key identity not null,
caja_cerrada bit not null, -- 0 para falso y 1 para verdadero que la caja está abierta
monto_cierre_efectivo decimal (18, 2) null,
monto_cierre_caja decimal (18, 2) null,
fecha_cierre datetime null,
login_id int not null
)