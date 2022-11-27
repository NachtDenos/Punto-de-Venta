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
delete VentaTemporal
select * from Producto
create trigger tr_PuntoReOrden on Recibo
for insert 
as
Begin
update Producto
set existencia =
(CASE
   When ((existencia < ptReorden)) or ((existencia < 0)) then existencia + 100
   else (existencia + 100)
END
)
	
end;
go
--Jalo una vez ahorita le doy mas pruebas, pero quita el comentario o comenta la linea donde lo aumentamos de manera manual en c#
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

