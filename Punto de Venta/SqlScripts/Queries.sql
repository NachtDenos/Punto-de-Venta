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