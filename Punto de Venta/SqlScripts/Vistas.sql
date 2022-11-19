create view vwInventary
as
select A.idProduct [Codigo], A.nombrePro [Nombre Producto], A.descripcion [Descripción], A.PrecioUnitario [Precio Unitario], A.Costo [Costo],
A.activo [Activo], A.claveAdmin [Gestor], B.nombreDep [Departamento], A.existencia [Stock], A.fechaAlta [Fecha de Alta],
A.FechaCambio [Fecha de Actualizacion], A.ptReorden [Punto de Reorden], D.unidadMedida [Unidad de Medida], A.merma[Merma], A.uniVendida [Cantidades Vendidas], c.claveUsuario [Usuario], 
A.idDesc [id Descuento] from Producto A
join Departamento B
on B.idDepa = A.claveDepa
join Usuario C
ON c.idUser = a.claveAdmin
join uniMedidaPro D
ON D.idMedida = A.uniMedida

go

create view vwEmpleados
as
select C.idCajero as IdEmpleado, U.nombreU [Nombre], U.apellidoPU [Apellido Paterno], U.apellidoMU [Apellido Materno],
U.claveUsuario [Clave de Usuario], U.contraU [Contraseña], C.CURP [CURP], C.email [Correo], C.numeroNomi [Nomina], C.fechaIngr [Fecha de Ingreso],
C.fechaNaci [Fecha Nacimiento] from Cajero C
join Usuario U
ON C.idCajero = U.idUser

go

create view vwDescuento
as
SELECT Descuento.idDesc [Id Descuento], descFecha.fechaIni [Inicia], descFecha.fechaFin [Termina], Descuento.cantidad [Porcentaje], P.nombrePro [Nombre Producto], P.idProduct [Codigo] from Descuento
	join descFecha
	on descFecha.idFechaDesc = Descuento.idDesc
	join Producto P
	on Descuento.idDesc = P.idDesc