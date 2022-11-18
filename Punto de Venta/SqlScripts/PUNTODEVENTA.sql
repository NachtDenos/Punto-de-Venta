create database ProyectoMAD
go

IF OBJECT_ID('ProyectoMAD') IS NOT NULL
BEGIN
   DROP DATABASE ProyectoMAD;
END

--ctrl r para bajar la ventana de mensajes
use ProyectoMAD
go
IF OBJECT_ID('Usuario') IS NOT NULL
BEGIN
   DROP TABLE Usuario;
END



CREATE TABLE Usuario 
(
   idUser INT IDENTITY (1, 1) NOT NULL,
   nombreU  VARCHAR (30) NOT NULL,
   apellidoPU VARCHAR (30) NOT NULL,
   apellidoMU VARCHAR (30) NOT NULL,
   claveUsuario varchar(50) not null,
   contraU VARCHAR (30) NOT NULL,
   tipoU varchar(1)  not null,
   CONSTRAINT PK_user 
   PRIMARY KEY (idUser)
);


--select  A.idAdmin , B.idUser, B.nombreU, B.claveUsuario, B.contraU, B.tipoU  from Usuario B
--join Administrador A
--on a.idUserA = b.idUser
--where B.tipoU = '1'

--select * from Usuario

--insert into Administrador(idUserA)
--values ('1');

--SELECT * FROM Departamento


IF OBJECT_ID('Administrador') IS NOT NULL
BEGIN
   DROP TABLE Administrador;
END
go
--puto si no te jalaa
CREATE TABLE Administrador
(
   idAdmin INT IDENTITY (1, 1) NOT NULL,
   idUserA  INT not NULL,
   CONSTRAINT PK_admin
   PRIMARY KEY (idAdmin), --I mean esta esta bien pero las otras jsjsj
   CONSTRAINT FK_idUser
   FOREIGN KEY (idUserA) --Ver que pedo con estas id, si no podemos dejarla solo sin FK aislada de los demas
   REFERENCES Usuario (idUser)
);

--on A.idAdmin = B.idUser parte del query de arriba
--insert into Administrador(idUserA) values ('1');

IF OBJECT_ID('Cajero') IS NOT NULL
BEGIN
   DROP TABLE Cajero;
END

CREATE TABLE Cajero
(
   idCajero INT Identity(2,1)  NOT NULL,
   CURP CHAR (18) NOT NULL,
   fechaNaci DATE NOT NULL,
   numeroNomi INT NOT NULL,
   email VARCHAR (25) NOT NULL,
   fechaIngr DATE NOT NULL,
   uniVend INT,
   ventas INT,
   claveAdmin INT NOT NULL,
   --claveUser INT NOT NULL,
   CONSTRAINT PK_Cajero
   PRIMARY KEY (idCajero),

   CONSTRAINT FK_claveAdmin
   FOREIGN KEY (claveAdmin)
   REFERENCES Administrador (idAdmin),

   --CONSTRAINT FK_claveUser
   --FOREIGN KEY (claveUser)
   --REFERENCES Usuario (idUser),
   --Constraint
   CONSTRAINT CK_uniVend
   CHECK (-1 <= uniVend),
   CONSTRAINT CK_ventas
   CHECK (-1 <= ventas)
);
go

IF OBJECT_ID('Producto') IS NOT NULL
BEGIN
   DROP TABLE Producto;
END
go
CREATE TABLE Producto
(
    idProduct INT NOT NULL,
	nombrePro VARCHAR (30) NOT NULL,
	descripcion VARCHAR (60) NOT NULL,
	uniMedida VARCHAR (10) NOT NULL,
	fechaAlta DATE NOT NULL,
	existencia INT NOT NULL,
	ptReorden INT NOT NULL,
	claveGest INT NOT NULL, 
	activo varchar(30),
	merma INT,
	Costo float not null,
	PrecioUnitario float not null,
	uniVendida INT,
	claveAdmin INT NOT NULL, 
	claveDepa INT NOT NULL,
	--claveDesc INT NOT NULL,
	--clavePre INT NOT NULL,   
	idDesc int null,
	fechaDesc DATE,
	FechaCambio date null,
	CONSTRAINT PK_idProd
	PRIMARY KEY (idProduct),
	CONSTRAINT CK_activo
	CHECK (activo = 'Activo' OR activo = 'Inactivo'),
	CONSTRAINT FK_claveUserPro
    FOREIGN KEY (claveAdmin)
    REFERENCES Administrador (idAdmin)
)


go
IF OBJECT_ID('gestioProd') IS NOT NULL
BEGIN
   DROP TABLE gestioProd;
END
go
CREATE TABLE gestioProd
(
   idGest INT IDENTITY (0, 1) NOT NULL,
   fechaCambio DATE,
   usuarioCambio VARCHAR (30),
   CONSTRAINT PK_idGest
   PRIMARY KEY (idGest)
);

  go
IF OBJECT_ID('Caja') IS NOT NULL
BEGIN
   DROP TABLE Caja;
END
go
CREATE TABLE Caja
(
   idCaja INT NOT NULL,
   disponi varchar(20),
   claveAdminCa INT NOT NULL,
   CONSTRAINT PK_idCaja
   PRIMARY KEY (idCaja),
   CONSTRAINT FK_claveAdminCa
   FOREIGN KEY (claveAdminCa)
   REFERENCES Administrador (idAdmin),
   CONSTRAINT CK_disponi
   CHECK (disponi = 'Activo' OR disponi = 'Inactivo')
);
go
IF OBJECT_ID('Recibo') IS NOT NULL
BEGIN
   DROP TABLE Recibo;
END
go
CREATE TABLE Recibo
(
   noVenta INT IDENTITY (10000, 1) NOT NULL,
   fechaVenta DATE NOT NULL,
   total INT NOT NULL,
   claveCajePro INT NOT NULL,
   CONSTRAINT PK_noVenta
   PRIMARY KEY (noVenta),
   CONSTRAINT CK_total
   CHECK (0 <= total)
);
go
IF OBJECT_ID('Venta') IS NOT NULL
BEGIN
   DROP TABLE Venta;
END
go
CREATE TABLE Venta
(
   idVenta INT IDENTITY (0, 1) NOT NULL,
   noVentaVen INT NOT NULL,
   claveVentaPro INT NOT NULL, 
   precioProd INT NOT NULL,
   descProdut INT NOT NULL,
   cantidadVen INT NOT NULL,
   subtotal INT NOT NULL,
   CONSTRAINT PK_idVenta
   PRIMARY KEY (idVenta),
   CONSTRAINT FK_noVentaPro
   FOREIGN KEY (claveVentaPro)
   REFERENCES Recibo (noVenta),
   CONSTRAINT CK_precioProd
   CHECK (0 <= precioProd),
   CONSTRAINT CK_descProduct
   CHECK (0 <= descProdut),
   CONSTRAINT CK_cantVend
   CHECK (0 <= cantidadVen)
);
go
IF OBJECT_ID('VentaProduct') IS NOT NULL
BEGIN
   DROP TABLE VentaProduct;
END
go
CREATE TABLE VentaProduct
(
   idVentaProd INT IDENTITY (0, 1) NOT NULL,
   nombreProdVenta VARCHAR (30) NOT NULL,
   CONSTRAINT PK_idVentaProd
   PRIMARY KEY (idVentaProd)
);
go
ALTER TABLE Venta
  ADD CONSTRAINT FK_claveVentaProd
  FOREIGN KEY (claveVentaPro)
  REFERENCES VentaProduct (idVentaProd);
  go
IF OBJECT_ID('NotaCred') IS NOT NULL
BEGIN
   DROP TABLE NotaCred;
END
go
CREATE TABLE NotaCred
(
   noCredit INT IDENTITY (10000, 1) NOT NULL,
   total INT NOT NULL,
   numeroRecibo INT NOT NULL,
   fechaNota DATE NOT NULL,
   claveAdminNota INT NOT NULL,
   codigoProNota INT NOT NULL,
   CONSTRAINT PK_noCredit
   PRIMARY KEY (noCredit),
   CONSTRAINT FK_claveAdminNota
   FOREIGN KEY (claveAdminNota)
   REFERENCES Administrador (idAdmin),
   CONSTRAINT FK_codigoProNota
   FOREIGN KEY (codigoProNota)
   REFERENCES Producto (idProduct)
);
go
IF OBJECT_ID('ProductNota') IS NOT NULL
BEGIN
   DROP TABLE ProductNota;
END
go
CREATE TABLE ProductNota
(
   idNotaP INT IDENTITY (0, 1) NOT NULL,
   idNoCredit INT NOT NULL,
   proRegresa VARCHAR (30) NOT NULL,
   cantidadNota INT NOT NULL,
   subtotalNota INT NOT NULL,
   CONSTRAINT PK_idNotaP
   PRIMARY KEY (idNotaP),
   CONSTRAINT FK_idNoCredit
   FOREIGN KEY (idNoCredit)
   REFERENCES NotaCred (noCredit),
   CONSTRAINT CK_cantidadNota
   CHECK (0 <= cantidadNota),
   CONSTRAINT CK_subtotalNota
   CHECK (0 <= subtotalNota)
);
go
IF OBJECT_ID('Departamento') IS NOT NULL
BEGIN
   DROP TABLE Departamento;
END
go
CREATE TABLE Departamento
(
   idDepa INT NOT NULL,
   nombreDep VARCHAR (30) NOT NULL,
   devoluDepa varchar(10) not null,
   claveAdminDepa INT NULL,
   CONSTRAINT PK_idDepa
   PRIMARY KEY (idDepa),
   --CONSTRAINT FK_claveAdminDepa
   --FOREIGN KEY (claveAdminDepa)
   --REFERENCES Administrador (idAdmin),
   --CONSTRAINT CK_devoluDepa
   CHECK ('No' = devoluDepa OR 'Si' = devoluDepa)
);
go
ALTER TABLE Producto
  ADD CONSTRAINT FK_claveDepa
  FOREIGN KEY (claveDepa)
  REFERENCES Departamento (idDepa);
  go
IF OBJECT_ID('MetodPago') IS NOT NULL
BEGIN
   DROP TABLE MetodPago;
END
go
CREATE TABLE MetodPago
(
   idPago INT IDENTITY (0, 1) NOT NULL,
   tipoMetod VARCHAR (30) NOT NULL,
   CONSTRAINT PK_idPago
   PRIMARY KEY (idPago),
);
go
IF OBJECT_ID('Descuento') IS NOT NULL
BEGIN
   DROP TABLE Descuento;
END
go

IF OBJECT_ID('descFecha') IS NOT NULL
BEGIN
   DROP TABLE descFecha;
END
go
CREATE TABLE descFecha
(
   idFechaDesc INT IDENTITY (1, 1) NOT NULL,
   fechaIni DATE NOT NULL,
   fechaFin DATE NOT NULL,
   CONSTRAINT PK_idFechaDesc
   PRIMARY KEY (idFechaDesc)
);
go

CREATE TABLE Descuento
(
   idDesc INT IDENTITY (1, 1) NOT NULL,
   cantidad INT NOT NULL,
   claveFechaD INT default(1) NULL, 
   CONSTRAINT PK_idDesc
   PRIMARY KEY (idDesc),
   CONSTRAINT CK_cantidad
   CHECK (0 < cantidad),
   CONSTRAINT FK_claveFechaD
   FOREIGN KEY (claveFechaD)
   REFERENCES descFecha (idFechaDesc)
);
go

  go
IF OBJECT_ID('Caje_Pro') IS NOT NULL
BEGIN
   DROP TABLE Caje_Pro;
END
go
CREATE TABLE Caje_Pro
(
   idCajePro INT IDENTITY (0, 1) NOT NULL,
   claveCajeroCP INT NOT NULL,
   codigoProCP INT NOT NULL,
   noCajaCP INT NOT NULL,
   activoCP BIT DEFAULT (1),
   existenciaCP INT NOT NULL, 
   CONSTRAINT PK_idCajePro
   PRIMARY KEY (idCajePro),
   CONSTRAINT FK_claveCajeroCP
   FOREIGN KEY (claveCajeroCP)
   REFERENCES Cajero (idCajero),
   CONSTRAINT FK_codigoProCP
   FOREIGN KEY (codigoProCP)
   REFERENCES Producto (idProduct),
   CONSTRAINT FK_noCajaCP
   FOREIGN KEY (noCajaCP)
   REFERENCES Caja (idCaja),
   CONSTRAINT CK_activoCP
   CHECK (0 = activoCP OR 1 = activoCP)
);
go
ALTER TABLE Recibo
  ADD CONSTRAINT FK_claveCajePro
  FOREIGN KEY (claveCajePro)
  REFERENCES Caje_Pro (idCajePro);
go
IF OBJECT_ID('ticket') IS NOT NULL
BEGIN
   DROP TABLE ticket;
END
go
CREATE TABLE ticket
(
   idTicket INT IDENTITY (10000, 1) NOT NULL,
   noVentaTic INT NOT NULL,
   clavePagoTic INT NOT NULL,
   fechaTic DATE NOT NULL,
   CONSTRAINT PK_idTicket
   PRIMARY KEY (idTicket),
   CONSTRAINT FK_noVentaTic
   FOREIGN KEY (noVentaTic)
   REFERENCES Recibo (noVenta),
   CONSTRAINT FK_clavePagoTic
   FOREIGN KEY (clavePagoTic)
   REFERENCES MetodPago (idPago)
);
go
IF OBJECT_ID('devolucion') IS NOT NULL
BEGIN
   DROP TABLE devolucion;
END
go
CREATE TABLE devolucion
(
   idDev INT IDENTITY (0, 1) NOT NULL,
   noCredDev INT NOT NULL,
   codigoProDev INT NOT NULL,
   fechaDev DATE NOT NULL,
   CONSTRAINT PK_idDev
   PRIMARY KEY (idDev),
   CONSTRAINT FK_noCredDev
   FOREIGN KEY (noCredDev)
   REFERENCES NotaCred (noCredit),
   CONSTRAINT FK_codigoProDev
   FOREIGN KEY (codigoProDev)
   REFERENCES Producto (idProduct)
);

ALTER TABLE Producto
  ADD CONSTRAINT FK_idDesc 
  FOREIGN KEY (idDesc)
  REFERENCES Descuento (idDesc);
go

create table VentaTemporal
(
  idVentaTemp int identity (0,1) not null,
  CodigoProducto int not null,
  NombreProducto varchar(50) not null,
  ExistenciaProducto varchar(200) not null,
  PrecioUnitario int not null,
  FechaVenta date null,
  Caja int null,

);
go



create proc SelectUsuarios
(
@ClaveU varchar(50),
@Contraseña varchar(50),
@TipoU varchar(1) 
)
as
begin
select Usuario.idUser as NumeroIdentificacion, Usuario.nombreU [Nombre], Usuario.contraU [Contraseña], Usuario.tipoU, claveUsuario [Clave de Usuario] from Usuario
where claveUsuario = @ClaveU and contraU = @Contraseña and tipoU = @TipoU
end;
go
--drop proc SelectUsuarios


IF OBJECT_ID('SelectUsuarios') IS NOT NULL
BEGIN
   DROP PROC SelectUsuarios;
END
go

Create procedure ObtenerAdministradores --Obtiene las credenciales del Administrador
(
@ClaveU varchar(50),
@Contra varchar(50),
@TipoU int
)
as
Begin
select  A.idAdmin , B.idUser, B.nombreU, B.claveUsuario, B.contraU, B.tipoU  from Usuario B
join Administrador A
on a.idUserA = b.idUser
where A.idUserA = B.idUser and b.claveUsuario = @ClaveU and b.contraU = @Contra and b.tipoU = @TipoU
end;
go

go
--drop proc sp_InsertarEmpleado
create procedure sp_InsertarEmpleado
(
@Nombre varchar(30),
@ApellidoP varchar(50),
@ApellidoM varchar(50),
@FechaNac date,
@NumeroNomina int,
@Email varchar(25),
@CURP char(18),
@FechaIngreso date,
@ClaveUsuario varchar(30),
@Contraseña varchar(30)
)
as
Begin
--Usuario
insert into Usuario(claveUsuario, contraU, nombreU, apellidoPU, apellidoMU,tipoU)
values(@ClaveUsuario, @Contraseña, @Nombre, @ApellidoP, @ApellidoM, '0')
--Cajero
insert into Cajero(fechaNaci, fechaIngr, numeroNomi, email, CURP, claveAdmin)
values(@FechaNac, @FechaIngreso, @NumeroNomina, @Email, @CURP, 1)
end;
go
Create proc ListarEmpleados
as
Begin
select C.idCajero as IdEmpleado, U.nombreU [Nombre], U.apellidoPU [Apellido Paterno], U.apellidoMU [Apellido Materno],
U.claveUsuario [Clave de Usuario], U.contraU [Contraseña], C.CURP [CURP], C.email [Correo], C.numeroNomi [Nomina], C.fechaIngr [Fecha de Ingreso],
C.fechaNaci [Fecha Nacimiento] from Cajero C
join Usuario U
ON C.idCajero = U.idUser
end;
go
create proc ActualizarEmpleados
(
@Id int,
@Nombre varchar(30),
@ApellidoP varchar(30),
@ApellidoM varchar(30),
@ClaveU varchar(30),
@Contra varchar(30),
@Correo varchar(30),
@FechaNac date,
@FechaIng date,
@Curp char(18),
@Nomina int
)
as
Begin
Update Usuario set nombreU = @Nombre, apellidoPU = @ApellidoP, apellidoMU = @ApellidoM, claveUsuario = @ClaveU, contraU = @Contra
where idUser = @Id
update Cajero set CURP = @Curp, fechaNaci = @FechaNac, fechaIngr = @FechaIng, email = @Correo, numeroNomi = @Nomina
where idCajero = @Id
end;
go
create proc BorrarEmpleados
(
@id int
)
as
Begin
delete Cajero where idCajero = @id
delete Usuario where idUser = @id
end;
go
--insert into Departamento(idDepa, nombreDep, devoluDepa, claveAdminDepa)
--values ('1', 'Electronica', 'No', '1')
select * from Departamento

--CUANDO A UN INSERT INMEDIATAMENTE LE METO UN SELECT ESTA MADRE SE INSERTA EN ESA TABLA
go
create proc InsertarDepartamentos
(
@NombreDepa varchar(50),
@IdDepa int,
@Devolucion varchar(10),
@IdAdmin int
)
as 
Begin

insert into Departamento(departamento.idDepa, nombreDep, devoluDepa, claveAdminDepa)
values(@IdDepa, @NombreDepa, @Devolucion, @IdAdmin)
end;

go
create proc ActualizarDepartamentos
(
@Nombre varchar(30),
@Devolucion varchar(10),
@IdDepa int
)
as
Begin
Update Departamento set nombreDep = @Nombre, devoluDepa = @Devolucion, claveAdminDepa = '1'
where idDepa = @IdDepa
end;

go
create proc BorrarDepartamentos
(@IdCaja int
)
as
Begin
delete Departamento where idDepa = @IdCaja;
end;
go

---Crear un view, o una proc
create proc LeerDepartamentos
as
Begin
select Departamento.idDepa [Id Departamento], Departamento.nombreDep [Departamento], Departamento.devoluDepa [Devolucion], claveAdminDepa [Usuario Cambio]
from Departamento
end;

-- exec InsertarDepartamentos 'Electronica Monterrey', '4', 'Si'
/*
select * from Departamento
idDepa INT NOT NULL,
   nombreDep VARCHAR (30) NOT NULL,
   devoluDepa BIT DEFAULT (1),
   claveAdminDepa INT NOT NULL,
*/


-----------------CAJAS EN DESARROLLO--------------

create proc CrearCajas
(@Id int,
@Disponibilidad varchar(20)
)
as
Begin	
Insert into Caja(idCaja, disponi, claveAdminCa)
values(@Id, @Disponibilidad, 1) 
end;

Create proc EditarCajas
(
@Id int, @Disponibilidad varchar(20)
)
as
Begin
update Caja set disponi = @Disponibilidad where idCaja = @Id
end;

create proc bajaCajas
(@idC int)
as
Begin
delete Caja where idCaja = @idC
end;

select * from Caja

create proc ListarCaja
as
Begin
select idCaja[Numero de Caja], disponi[Disponibilidad] from Caja
end;

create proc ListarCajaCombo
as
Begin
select idCaja[Numero de Caja] from Caja where disponi = 'Activo'
end;

go
--Considerar hacerlo view y meterlo e el proc pero lo hare mañana a
create proc ListarProductos
as
Begin
select A.idProduct [Codigo], A.nombrePro [Nombre Producto], A.descripcion [Descripción], A.PrecioUnitario [Precio Unitario], A.Costo [Costo],
A.activo [Activo], A.claveAdmin [Gestor], B.nombreDep [Departamento], A.existencia [Stock], A.fechaAlta [Fecha de Alta],
A.FechaCambio [Fecha de Actualizacion], A.ptReorden [Punto de Reorden], A.uniMedida [Unidad de Medida], A.uniVendida [Cantidades Vendidas], c.claveUsuario [Usuario], D.idDesc [Id descuento] from Producto A
join Departamento B
on B.idDepa = A.claveDepa
join Usuario C
ON c.idUser = a.claveAdmin
left join Descuento D
ON D.idDesc = A.idDesc

end;

go
create proc ListarDepartamentos
as
Begin
SELECT Departamento.idDepa, Departamento.nombreDep from Departamento
end;
go
create proc InsertarProductos
(
@CodigoProducto int,
@NombreProducto varchar(30),
@Descripcion varchar(60),
@UniMedida varchar(10),
@fechaAlta date ,
@existencia int ,
@ptReorden int ,
@activo varchar(30),
@Costo float,
@PrecioUnitario float ,
@ClaveDepartamento int
)
as 
Begin
insert into Producto(idProduct, nombrePro,descripcion,uniMedida, fechaAlta,existencia,
ptReorden, activo,Costo,PrecioUnitario,claveAdmin,claveDepa, claveGest)
values(@CodigoProducto, @NombreProducto, @Descripcion, @UniMedida, @fechaAlta, @existencia,
@ptReorden, @activo, @Costo, @PrecioUnitario,1, @ClaveDepartamento, 1)

End;
go

create proc ActualizarProductos
(
@IdP int,
@NombreProducto varchar(30),
@Descripcion varchar(60),
@UnidadMedida varchar(10),
@FechaCambio date,
@existencia int,
@ptReorden int,
@Activo varchar(30),
@costo float,
@PrecioUnitario float,
@ClaveDeparmento int null
)
as
Begin
update Producto set nombrePro = @NombreProducto, descripcion = @Descripcion, uniMedida = @UnidadMedida,
FechaCambio = @FechaCambio, existencia = @existencia, ptReorden = @ptReorden, activo = @Activo, Costo = @costo, claveDepa = @ClaveDeparmento
where idProduct = @IdP
end;
go
create proc BajaProductos
(@CodigProduc int)
as
Begin
update Producto set activo = 'Inactivo' where Producto.idProduct = @CodigProduc
end;

--Este es el select para departamentos y productos, probar hacerlo stored procedure
--select A.idProduct [Id], A.nombrePro [Nombre del Producto], A.descripcion [Descripcion], A.claveDepa [Id Departamento], A.existencia [Stock], A.uniVendida [Unidades Vendidas], B.nombreDep [Departamento]
--from Producto A
--join Departamento B
--on A.claveDepa = B.idDepa
--where A.claveDepa = B.idDepa
--smn est select jala pra eso, solo hazlo procedure y que reciba el id que buscamos y con eso buscamos el producto y su depa
go



create proc RealizarDescuento
(@Porcentaje int,
@Fecha1 date,
@Fecha2 date,
@ClaveProd int
)
as
Begin
	DECLARE @iDdis int;
	
	Print @iDdis
insert into descFecha(fechaIni, fechaFin)
values (@Fecha1, @Fecha2)	
select @iDdis= SCOPE_IDENTITY(); --Nesecario ponerlo aqui para que aqui reciba la ultima identity creada 
insert into Descuento(cantidad, claveFechaD)
values (@Porcentaje, @iDdis)
update Producto set idDesc = @iDdis where Producto.idProduct = @ClaveProd

end;

go
	--RealizarDescuento 30, '1998-04-16', '2777-10-22', 1
go	


create proc ListarDescuentosFecha
as
Begin
	SELECT Descuento.idDesc [Id Descuento], descFecha.fechaIni [Inicia], descFecha.fechaFin [Termina], Descuento.cantidad [Porcentaje], P.nombrePro [Nombre Producto], P.idProduct [Codigo] from Descuento
	join descFecha
	on descFecha.idFechaDesc = Descuento.idDesc
	join Producto P
	on Descuento.idDesc = P.idDesc
end;

create proc BorrarDescuento
(
@idDes int
)
as
Begin
delete Descuento where idDesc = @idDes
end;

CREATE TRIGGER tr_bajaDescuentoPro ON Descuento
INSTEAD OF DELETE
AS
BEGIN
DECLARE @ID INT
Select @ID = idDesc
FROM deleted
update Producto set idDesc = null where @ID = idDesc
end;

drop trigger tr_bajaDescuentoPro

--exec BorrarDescuento 4

--select * from Descuento

--select * from Producto

--Insert into Usuario(nombreU,apellidoPU,apellidoMU,claveUsuario,contraU,tipoU)
--values ('Isaac','Espinoza','Morales','Wonder','123456',1)

--select * from Usuario --Se insertaron los usuario de manera correcta, los cajeros no pero ya estan, checar el select para poder juntarlos
--insert into Usuario(nombreU,apellidoPU,apellidoMU,contraU,tipoU)
--values('Isaac','Espinoza','Morales','1234', 'Cajero')
--SelectUsuarios 'Natch','123456','0'

--insert into Administrador(idUserA)
--values (1)

--Intentare hacer la vista del inventario

create view vwInventary
as
select A.idProduct [Codigo], A.nombrePro [Nombre Producto], A.descripcion [Descripción], A.PrecioUnitario [Precio Unitario], A.Costo [Costo],
A.activo [Activo], A.claveAdmin [Gestor], B.nombreDep [Departamento], A.existencia [Stock], A.fechaAlta [Fecha de Alta],
A.FechaCambio [Fecha de Actualizacion], A.ptReorden [Punto de Reorden], A.uniMedida [Unidad de Medida], A.merma[Merma], A.uniVendida [Cantidades Vendidas], c.claveUsuario [Usuario], 
A.idDesc [id Descuento] from Producto A
join Departamento B
on B.idDepa = A.claveDepa
join Usuario C
ON c.idUser = a.claveAdmin

create proc ListarInventario
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary where [Activo] = 'Activo'
end;

create procedure filtro_existenciaI
(@filtroI int)
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary
where [stock] like @filtroI 
end;

create procedure filtro_DepartamentoI
(@filtroI varchar (200))
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary
where [Departamento] like @filtroI + '%'
end;

create procedure filtro_agotadoI
(@filtroI int)
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary
where [stock] = @filtroI or (1 = @filtroI and [stock] > 0)
end;

create procedure filtro_mermaI
(@filtroI int)
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary
where (0 = @filtroI and [Merma] is null) or (1 = @filtroI and [Merma] > 0)
end;


--PROCEDURES PARA VER EN LAS VENTAS

create proc ConsultaRapida
as
Begin
select [Codigo], [Nombre Producto], [Precio Unitario], [Stock] from vwInventary where [Activo] = 'Activo'
end;

create proc filtroConsultaRapida
(@filID int, @filName varchar(200))
as
Begin
select [Codigo], [Nombre Producto], [Precio Unitario], [Stock] from vwInventary 
where @filID = [Codigo] or @filName like [Nombre Producto] + '%' or (@filID = [Codigo] and @filName like [Nombre Producto] + '%') and [Activo] = 'Activo'
end;

create proc productosVenta
as
Begin
select [Codigo], [Nombre Producto] from vwInventary where [Activo] = 'Activo'
end;

create proc filtroSelectProduct
(@filID int, @filName varchar(200))
as
Begin
select [Codigo], [Nombre Producto] from vwInventary 
where @filID = [Codigo] or @filName like [Nombre Producto] + '%' or (@filID = [Codigo] and @filName like [Nombre Producto] + '%') and [Activo] = 'Activo'
end;

--EN EL CASE DEL DATAGRID TENER UN STRING QUE SE ENCARGUE DE OBTENER EL NOMBRE DEL PRODUCTO ACTUAL SELECCIONADO Y CON ESO HACEERLE INSERT
