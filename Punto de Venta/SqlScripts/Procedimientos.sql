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
@UnidadMedida int,
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
insert into VentaTemporal(CodigoProducto,NombreProducto, PrecioUnitario, ExistenciaProducto, FechaVenta, Caja, CantidadAllevar)
Select Producto.idProduct [Codigo], nombrePro [Nombre Producto], PrecioUnitario [Precio], Producto.existencia [Existencia], @Fecha, @Caja, @CantidadAllevar from Producto where Producto.idProduct = @CodigoProd or Producto.nombrePro = @NombreProd
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
PrecioUnitario [Precio], ExistenciaProducto [Stock] from VentaTemporal
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
--drop VentaTemporal
--EliminarCantidad 'Control Remoto', 100
go
create procedure EliminarCantidad 
(@NombreProd varchar(30),
@Cantidad int)
as
begin
update VentaTemporal set CantidadAllevar = CantidadAllevar - @Cantidad where NombreProducto = @NombreProd
end;