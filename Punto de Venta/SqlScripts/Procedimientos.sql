
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
go
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

create proc ListarCaja
as
Begin
select idCaja[Numero de Caja], disponi[Disponibilidad] from Caja
end;
go
create proc ListarCajaCombo
as
Begin
select idCaja[Numero de Caja] from Caja where disponi = 'Activo'
end;

go

create proc ListarProductos
as
Begin
select A.idProduct [Codigo], A.nombrePro [Nombre Producto], A.descripcion [Descripción], A.PrecioUnitario [Precio Unitario], A.Costo [Costo],
A.activo [Activo], A.claveAdmin [Gestor], B.nombreDep [Departamento], A.existencia [Stock], A.fechaAlta [Fecha de Alta],
A.FechaCambio [Fecha de Actualizacion], A.ptReorden [Punto de Reorden], E.unidadMedida [Unidad de Medida], A.uniVendida [Cantidades Vendidas], c.claveUsuario [Usuario], D.idDesc [Id descuento] from Producto A
join Departamento B
on B.idDepa = A.claveDepa
join Usuario C
ON c.idUser = a.claveAdmin
left join Descuento D
ON D.idDesc = A.idDesc
join uniMedidaPro E
ON E.idMedida = A.uniMedida

end;

go
create proc ListarDepartamentos
as
Begin
SELECT Departamento.idDepa, Departamento.nombreDep from Departamento
end;
go

create proc ListarUnidadesMedida
as
Begin
SELECT uniMedidaPro.idMedida, uniMedidaPro.unidadMedida from uniMedidaPro
end;

go

create proc InsertarProductos
(
@CodigoProducto int,
@NombreProducto varchar(30),
@Descripcion varchar(60),
@UniMedida int,
@fechaAlta date ,
@existencia int ,
@ptReorden int ,
@activo varchar(30),
@Costo decimal(10,2),
@PrecioUnitario decimal(10,2),
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
@UnidadMedida int,
@FechaCambio date,
@existencia int,
@ptReorden int,
@Activo varchar(30),
@costo decimal(10,2),
@PrecioUnitario decimal(10,2),
@ClaveDeparmento int null
)
as
Begin
update Producto set nombrePro = @NombreProducto, descripcion = @Descripcion, uniMedida = @UnidadMedida,
FechaCambio = @FechaCambio, existencia = @existencia, ptReorden = @ptReorden, activo = @Activo, Costo = @costo, PrecioUnitario =  @PrecioUnitario, claveDepa = @ClaveDeparmento
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

create proc editDescuento
(@idDesc int, @Fecha1 date,
 @Fecha2 date, @porcentaje int)
as
Begin
update Descuento set cantidad = @porcentaje where idDesc = @idDesc
update descFecha set fechaIni = @Fecha1, fechaFin = @Fecha2 where @idDesc = idFechaDesc
end;
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

go

create proc BorrarDescuento
(
@idDes int
)
as
Begin
delete Descuento where idDesc = @idDes
end;
go
create proc listarProdDescCB
as
Begin
select [Codigo], [Nombre Producto] from vwInventary where [id Descuento] is null
end;
go
--drop proc listarProdDescCB

go
create proc ListarInventario
as
Begin
select [Departamento], [Nombre Producto], [Unidad de Medida], [Costo], [Precio Unitario], [Stock],
       [Cantidades Vendidas], [Merma] from vwInventary where [Activo] = 'Activo'
end;
go
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

--create proc BorrarCarrito
--as
--Begin
--delete VentaTemporal
--end

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

create proc SeleccionarProductoInsertarProducto
(@CodigoProd int,
@NombreProd varchar(30),
@Caja int,
@Fecha date,
@CantidadAllevar int)
as
Begin
insert into VentaTemporal(CodigoProducto,NombreProducto, PrecioUnitario, ExistenciaProducto, FechaVenta, Caja, CantidadAllevar, idDescuento)
Select Producto.idProduct [Codigo], nombrePro [Nombre Producto], PrecioUnitario [Precio], Producto.existencia [Existencia], @Fecha, @Caja, @CantidadAllevar, B.idDesc from Producto left join Descuento B
on B.idDesc = Producto.idDesc
where Producto.idProduct = @CodigoProd or Producto.nombrePro = @NombreProd;

--Update VentaTemporal set Caja = @Caja, FechaVenta = @Fecha where VentaTemporal.CodigoProducto = @CodigoProd
end;

go

--SeleccionarProductoInsertarProducto 2,'Helado Oreo', 1, '2022-11-17', 10
--select * FROM VentaTemporal
--delete VentaTemporal
go
create proc InsertarCarrito
as
Begin
Select idVentaTemp [Id], CodigoProducto [Codigo],  NombreProducto [Producto],  CantidadAllevar [A llevar], 
PrecioUnitario [Precio], ExistenciaProducto [Stock], d.cantidad [Porcentaje Descuento] from VentaTemporal
left join Descuento D
on D.idDesc = VentaTemporal.idDescuento
end;

-----Filtros de Empleados, Productos y Departamentos

create procedure filtro_DepartamentoScreen
(@filtroI varchar(200))
as
Begin
select Departamento.idDepa [Id Departamento], Departamento.nombreDep [Departamento], Departamento.devoluDepa [Devolucion], claveAdminDepa [Usuario Cambio]
from Departamento
where Departamento.nombreDep like @filtroI + '%'
end;

go

create procedure filtro_ProductoScreen
(@filtroI varchar(200))
as
Begin
select [Codigo], [Nombre Producto], [Descripción], [Precio Unitario], [Costo], [Activo], [Gestor], [Departamento], [Stock], [Fecha de Alta],
[Fecha de Actualizacion], [Punto de Reorden], [Unidad de Medida], [Cantidades Vendidas], [Usuario], [id Descuento] 
from vwInventary
where [Nombre Producto] like @filtroI + '%'
end;

go

create procedure filtro_EmpleadosScreen
(@filtroI varchar(200))
as
Begin
select [idEmpleado], [Nombre], [Apellido Paterno], [Apellido Materno], [Clave de Usuario], [Contraseña], [CURP], [Correo], [Nomina], [Fecha de Ingreso],
[Fecha Nacimiento]
from vwEmpleados
where  [Nombre] like @filtroI + '%'
end;

go


create procedure ActualizarCantidad
(@NombreProd varchar(30),
@Cantidad int)
as
Begin
update VentaTemporal set CantidadAllevar = CantidadAllevar+ @Cantidad where NombreProducto = @NombreProd
end;
--ActualizarCantidad 'Helado Oreo', 10
--select * from VentaTemporal
--delete VentaTemporal 
--EliminarCantidad 'Control Remoto', 111
go
create procedure EliminarCantidad 
(@NombreProd varchar(30),
@Cantidad int)
as
begin
update VentaTemporal set CantidadAllevar = CantidadAllevar - @Cantidad where NombreProducto = @NombreProd
end;

go

create procedure EliminarProductoCarrito 
(@NombreProd varchar(30),
@Cant int)
as
begin
Update VentaTemporal set CantidadAllevar = CantidadAllevar - @Cant where NombreProducto = @NombreProd
delete VentaTemporal where VentaTemporal.CantidadAllevar = 0 and NombreProducto = @NombreProd 
end;

create procedure InsertarParaPagar
as
Begin  
select VentaTemporal.idVentaTemp [Id], VentaTemporal.NombreProducto [Producto], 
VentaTemporal.PrecioUnitario [Precio], VentaTemporal.CantidadAllevar [A llevar], D.cantidad [Descuento], subTotal [Subtotal], P.Costo [Costo] from VentaTemporal
left join Descuento D
on D.idDesc = VentaTemporal.idDescuento
join Producto P
on P.idProduct = VentaTemporal.CodigoProducto
end;

select*from VentaTemporal
--total
select 
SUM(CantidadAllevar*PrecioUnitario) as Total
from VentaTemporal

create proc GenerarVenta
(@CajeroId int,
@NumCaja int,
@Fecha date,
@MontoPago decimal(10,2),
@Total decimal(10,2),
@NombreCajero varchar(30)
)
as
Begin
   declare @CajeroId2 int = 0
   declare @CajeroId3 int = 0;
      set @CajeroId = (Select Usuario.idUser from Usuario where nombreU = @NombreCajero)
   
   insert into Caje_Pro(claveCajeroCP, noCajaCP)
    values(@CajeroId, @NumCaja)

   set @CajeroId3 = SCOPE_IDENTITY();

   insert into Recibo(fechaVenta, MontoPago, claveCajePro, total)
   values (@Fecha, @MontoPago, @CajeroId3, @Total)
--   set @CajeroId = (Select Usuario.idUser from Usuario where Usuario.nombreU = @NombreCajero)
End;

drop proc GenerarVenta
GenerarVenta 1, 1, '2022-10-12', '1201.00', '1201.00', 'Edson'

create proc GenerarVentaDetalle
(@idVentaHeader int,
@nombreProducto varchar(30),
@UnidaesVendidas int,
@Subtotal decimal(10,2),
@PrecioUnitario decimal(10,2),
@Venta decimal(10,2),
@Utilidad decimal(10,2)
)
as
BEGIN
declare @IdDepartamento int = 0;
declare @DescuentoId int = 0;
declare @CodigoProd int = 0;
set @IdDepartamento = (Select Producto.claveDepa from Producto where nombrePro = @nombreProducto)
set @DescuentoId = (Select Producto.idDesc from Producto where nombrePro = @nombreProducto)
set @CodigoProd = (Select Producto.idProduct from Producto where nombrePro = @nombreProducto)
set @idVentaHeader = IDENT_CURRENT('Recibo')
insert into VentaDetalle(noDeVenta,CodProducto, DepartamentoId,UnidadesVendidas, Subtotal,DescuentoId, PrecioUnitario, totalVenta, Utilidad)
values (@idVentaHeader,  @CodigoProd, @IdDepartamento, @UnidaesVendidas, @Subtotal, @DescuentoId, @PrecioUnitario, @Venta, @Utilidad)

END;
GenerarVentaDetalle 0, 'Television', 220, 2020.20, 3232.10, 3232.50

create proc GenerarTicket
(@IdVentaHeader int,
@MontoPagado decimal(10,2),
@ClavePago int)
as
Begin
set @IdVentaHeader = IDENT_CURRENT('Recibo')
insert into ticket(noVentaTic, clavePagoTic, montoPago)
values(@IdVentaHeader, @ClavePago, @MontoPagado)
end;

--drop proc GenerarVenta
--(@Total decimal(10,2),
--@NombreProd varchar(30),
--@Fecha date,
--@Subtotal decimal(10,2),
--@MontoPago decimal(10,2),
--@MontoTotal decimal(10,2),
--@MetodPago int,
--@CajeroId int,
--@NumCaja int,
--@NombreCajero varchar(30),
--@UnidadesVendidas int,
--@PrecioUnitario decimal(10,2),
--@Utilidad decimal(10,2)
--)
--as
--Begin
--   declare @idVenta int = 0;
--   declare @idDepartamento int= 0;
--   declare @idProducto int= 0;
--   declare @DescuentoId int= 0;
--   declare @CajeroId2 int = 0
--   declare @CajeroId3 int = 0;
--   select @idProducto = Producto.idProduct from Producto where nombrePro = @NombreProd 
--   set @CajeroId = (Select Usuario.idUser from Usuario where Usuario.nombreU = @NombreCajero)
--   set @CajeroId2 = @CajeroId;

--   insert into Caje_Pro(noCajaCP, claveCajeroCP, codigoProCP)
--   values (@NumCaja, @CajeroId2, @idProducto)
--    set @CajeroId3 = SCOPE_IDENTITY();

--   insert into Recibo(fechaVenta, MontoPago, claveCajePro, total)
--   values (@Fecha, @MontoPago, @CajeroId3, @MontoTotal)
   
--   set @idVenta = SCOPE_IDENTITY();
--   set @DescuentoId = (select Producto.idDesc from Producto where nombrePro = @NombreProd)
--   select @idDepartamento = Producto.claveDepa from Producto where nombrePro = @NombreProd 
   
--   insert into VentaDetalle(noDeVenta,CodProducto, DepartamentoId,UnidadesVendidas, Subtotal,DescuentoId, PrecioUnitario,
--   Utilidad)
--   values(@idVenta, @idProducto, @idDepartamento, @UnidadesVendidas, @Subtotal, @DescuentoId,@PrecioUnitario, @Utilidad)

--   insert into ticket(noVentaTic, clavePagoTic, montoPago)
--   values(@idVenta, @MetodPago, @MontoPago)

   

--end;

--delete Caje_Pro
--delete Recibo
--delete VentaDetalle
select * from Caje_Pro
select * from Recibo
select * from ventaDetalle
SELECT* FROM ticket

select * from Cajero
select * from Departamento
select * from Producto
--idVentaDetalle int not null,
--  noDeVenta int not null,
--  CodProducto int not null,
--  DepartamentoId int not null,
--  UnidadesVendidas int not null,
--  Subtotal money not null,
--  DescuentoId int null,
--  PrecioUnitario money not null,
--  Utilidad money not null, 
--  Constraint Pk_VentaDetail
--  Primary key(idVentaDetalle),
--  Constraint FK_noDeVenta
--  Foreign key (noDeVenta)
--  references MetodPago(idPago),
--  Constraint FK_noDeDepa
--  Foreign key (DepartamentoId)
--  references Departamento(idDepa),
--  Constraint FK_noProd
--  Foreign key (CodProducto)
--  references Producto(idProduct)



  --noVenta INT IDENTITY (10000, 1) NOT NULL,
  -- fechaVenta DATE NOT NULL,
  -- total INT NOT NULL,
  -- claveCajePro INT NOT NULL,
  -- MontoPago Money null,

create procedure obtenerCajeroCobra
(@filtroI int)
as
Begin
select [Nombre], IdEmpleado
from vwEmpleados
where  @filtroI = [Clave de Usuario]
end;

create procedure obteneridCajeroCobra
(@filtroI int)
as
Begin
select IdEmpleado
from vwEmpleados
where  @filtroI = [Clave de Usuario]
end;

create procedure vaciarVentaTemporal
as
Begin
delete VentaTemporal
end;

create procedure obtenerIdVenta
as
Begin
declare @buscaID int = 0;
set @buscaID = IDENT_CURRENT('Recibo')
select noVenta from Recibo where noVenta = @buscaID
end;