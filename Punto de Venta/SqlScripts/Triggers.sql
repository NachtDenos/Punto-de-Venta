use ProyectoMAD
go
CREATE TRIGGER tr_bajaDescuentoPro ON Descuento
INSTEAD OF DELETE
AS
BEGIN
DECLARE @ID INT
Select @ID = idDesc
FROM deleted
update Producto set idDesc = null where @ID = idDesc
end;

go

--drop trigger tr_PuntoReOrden on Recibo
--for insert 
--as
--Begin
--update Producto
--set existencia =
--(CASE
--   When ((existencia < ptReorden)) or ((existencia < 0)) then existencia + 100
--   else (existencia + 100)
--END
--)
	
--end;

go

create trigger tr_AumentarCantVendida on VentaDetalle
for insert 
as
Begin
update Producto set uniVendida = uniVendida + inserted.UnidadesVendidas from inserted join Producto P
on P.idProduct = inserted.CodProducto

end;
--drop trigger tr_Actualizarcant on devolucion
--instead of insert
--as
--Begin
--declare @Id int;
--declare @Merma int;
--declare @Cant int;
--select @Id = idProduct from Producto
--update Producto set merma = merma + @Merma, existencia = existencia + @Cant where idProduct = @Id
--end;
go

--drop trigger tr_activoEnCero on Recibo
--for insert
--as
--Begin
--update Producto set activo = 'Inactivo' where Producto.existencia = 0
--end;