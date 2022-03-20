create database casa;

use casa;

create table telecomunicaciones(
num_facturaT int,
valor_tv int,
valor_int int,
valor_tel int,
valor_totalT int,
fecha date,
activo bit,
primary key (num_facturaT)
);

create table servicios(
num_facturaS int,
valor_agua int,
valor_gas int,
valor_luz int,
valor_totalS int,
fecha date,
activo bit,
primary key (num_facturaS)
);

create table mercado(
num_facturaM int,
valor_mercado int,
valor_totalM int,
fecha date,
activo bit,
primary key (num_facturaM)
);


use casa
create procedure guardar_telecom
@num_facturaT int,
@valor_tv int,
@valor_int int,
@valor_tel int,
@valor_totalT int,
@fecha date,
@activo bit
as
INSERT INTO
telecomunicaciones (num_facturaT, valor_tv, valor_int, valor_tel, valor_totalT, fecha, activo)
values (@num_facturaT, @valor_tv, @valor_int, @valor_tel, @valor_totalT, @fecha, @activo)



use casa
create procedure eliminar_telecom
@num_facturaT int
as
DELETE telecomunicaciones WHERE num_facturaT = @num_facturaT

create procedure consultar
@num_facturaT int
as
BEGIN	
SELECT num_facturaT, valor_tv, valor_int, valor_tel, valor_totalT, fecha, activo
FROM telecomunicaciones
WHERE num_facturaT = @num_facturaT
END




use casa
create procedure guardar_servicios
@num_facturaS int,
@valor_agua int,
@valor_gas int,
@valor_luz int,
@valor_totalS int,
@fecha date,
@activo bit
as
INSERT INTO 
servicios (num_facturaS, valor_agua, valor_gas, valor_luz, valor_totalS, fecha, activo)
values (@num_facturaS, @valor_agua, @valor_gas, @valor_luz, @valor_totalS, @fecha, @activo)


create procedure eliminar_servicios
@num_facturaS int
as
DELETE servicios
WHERE num_facturaS = @num_facturaS

create procedure consultar_servicios
@num_facturaS int
as
BEGIN
SELECT num_facturaS, valor_agua, valor_gas, valor_luz, valor_totalS, fecha, activo
FROM servicios where num_facturaS = @num_facturaS
END

use casa
create procedure guardar_mercado
@num_facturaM int,
@valor_mercado int,
@valor_totalM int,
@fecha date,
@activo bit
as
INSERT INTO
mercado (num_facturaM, valor_mercado, valor_totalM, fecha, activo)
values (@num_facturaM, @valor_mercado, @valor_totalM, @fecha, @activo)


create procedure eliminar_mercado
@num_facturaM int
as
DELETE mercado
WHERE num_facturaM = @num_facturaM 


create procedure consultar_mercado
@fecha date
as
BEGIN
SELECT num_facturaM, valor_mercado, valor_totalM, fecha
FROM mercado 
WHERE fecha = @fecha
END



use casa
select*from mercado