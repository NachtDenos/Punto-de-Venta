go
use ProyectoMAD
go
create function CalculoUtilidad
(@cantidad decimal(10,2), @precio decimal(10,2), @Costo decimal(10,2), @Descuento decimal(10,2))
returns decimal(10,2)
as
begin
	declare @Utilidad decimal(10,2)
	declare @precioDis decimal(10,2)
	declare @PrecioDisFinal decimal(10,2)
	set @precioDis = (select PrecioUnitario from Producto)
	set @Descuento = @Descuento /100 
	set @PrecioDisFinal = @precioDis - @Descuento
	set @Utilidad = (@precio - @Costo - @PrecioDisFinal)
	return @Utilidad 
end;


--create function Utilidad
--(@cantidad int, @precio smallmoney, @descuento tinyint, @costo smallmoney)
--returns money
--as
--begin
--	declare @utilidad money
--	set @utilidad=dbo.Ganancias(@cantidad, @precio, @descuento)-(@costo*@cantidad)
--	return @utilidad
--end