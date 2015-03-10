Create Table Cuentas(IdCuenta int primary key identity(1,1),Descripcion varchar(50),Balance Float)

Create Table Clasificaciones(IdClasificacion int primary key identity(1,1),Descripcion varchar(50))

create table SubClasificaciones(
 	IdSubClas int primary key identity(1,1),
IdClasificacion int references Clasificaciones(IdClasificacion),
 	Descripcion varchar(150),
 	);

CREATE TABLE Ingresos(
IdIngreso INT PRIMARY KEY IDENTITY (1,1),
Fecha	DATETIME,
IdCuenta INT  references Cuentas(IdCuenta),
IdSubClas INT   references SubClasificaciones(IdSubClas),
Concepto varchar(80), 
Valor	FLOAT);

Create table Gastos(
IdGasto int IDENTITY(1,1) Primary Key,
Fecha Datetime,
IdCuenta int references Cuentas(IdCuenta),
IdSubClas int references SubClasificaciones(IdSubClas),
Concepto varchar(80),
Monto float)

Create Table Transferencias(IdTransferecia int primary key identity(1,1),
Fecha datetime, IdCuentaOrigen int, IdCuentaDestino int, Concepto varchar(100), Valor float)

go
Create table Presupuesto(
IdPresupuesto int IDENTITY(1,1) Primary Key,
Fecha datetime,
Descripcion varchar(100)
);

Create table PresupuestoDetalle(
IdPresupuesto int IDENTITY(1,1) Primary Key,
IdClasificacion int references Clasificaciones(IdClasificacion),
Valor float);

create table Prestamos(
IdPrestamo int identity(1,1),
Cuenta int,
Concepto varchar(50),
Monto float,
Balance float
);

create table CobroPrestmos(
IdCobro int identity(1,1),
IdPrestamo int,
Monto float
);



 

-- select * from SubClasificaciones

--select * from Ingresos

--select IdIngreso,Valor , SubClasificaciones.Descripcion 
--from Ingresos  inner join SubClasificaciones  
--	on Ingresos.IdSubClas = SubClasificaciones.IdSubClas 


--insert into Clasificaciones(Descripcion) values ('sueldos')

--insert into SubClasificaciones(IdClasificacion,Descripcion) values (1,'sueldos extra')

--Insert into Cuentas (Descripcion,Balance ) values('Efectivo',0)

--balance = balance + (inicial-final)

--select Ingresos.* , SubClasificaciones.*



--insert Into Ingresos(Fecha,IdCuenta,IdSubClas,Concepto ,Valor) values (getdate(),1,2,'sueldo',100)

--Update Cuentas set Balance = Balance + Valor +50 where IdCuenta =1