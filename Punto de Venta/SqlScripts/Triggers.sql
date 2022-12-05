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

create trigger tr_AumentarCantVendida on VentaDetalle
for insert 
as
Begin
update Producto set uniVendida = uniVendida + inserted.UnidadesVendidas from inserted join Producto P
on P.idProduct = inserted.CodProducto

end;

go

create trigger tr_activoEnCero on VentaDetalle
for insert
as
Begin
update Producto set activo = 'Inactivo' where Producto.existencia = 0.00
end;

select * from Producto