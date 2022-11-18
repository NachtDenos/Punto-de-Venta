
------Otras Vistas (La de inventario esta en la otra parte)
create view vwEmpleados
as
select C.idCajero as IdEmpleado, U.nombreU [Nombre], U.apellidoPU [Apellido Paterno], U.apellidoMU [Apellido Materno],
U.claveUsuario [Clave de Usuario], U.contraU [Contraseña], C.CURP [CURP], C.email [Correo], C.numeroNomi [Nomina], C.fechaIngr [Fecha de Ingreso],
C.fechaNaci [Fecha Nacimiento] from Cajero C
join Usuario U
ON C.idCajero = U.idUser


--------------------------------------------------
create proc SeleccionarProductoInsertarProducto
(@CodigoProd int,
@NombreProd varchar(30),
@Caja int,
@Fecha date)
as
Begin
insert into VentaTemporal(CodigoProducto,NombreProducto, PrecioUnitario, ExistenciaProducto)
Select Producto.idProduct [Codigo], nombrePro [Nombre Producto], PrecioUnitario [Precio], Producto.existencia [Existencia] from Producto where Producto.idProduct = @CodigoProd or Producto.nombrePro = @NombreProd
Update VentaTemporal set Caja = @Caja, FechaVenta = @Fecha where VentaTemporal.CodigoProducto = @CodigoProd
end;
go
SeleccionarProductoInsertarProducto 1,'Television LED4K', 1, '2022-11-17'
select * FROM VentaTemporal
go
create proc InsertarCarrito
as
Begin
Select idVentaTemp [Id], CodigoProducto [Codigo], NombreProducto [Producto], PrecioUnitario [Precio], ExistenciaProducto [Stock] from VentaTemporal
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

drop proc filtro_EmpleadosScreen