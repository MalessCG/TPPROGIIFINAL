--Se solicita un reporte de cuántos vehiculos de cada modelo se han vendido en el año actual y cuál fue el total de ventas, siempre que
--la mínima cantidad de facturas haya sido mayor a 5
SELECT Nombre,
	   Modelo,
	   YEAR(f.fecha) Año, 
	   COUNT(DISTINCT f.nroFac) CantidadVendida,
       SUM(df.precio_venta * df.cantidad) - SUM(df.descuento) TotalVentas
FROM Facturas f join DetalleFactura df on df.nroFac = f.nroFac
join Orden_Pedido o on o.nro_orden = f.nro_orden
join Detalle_Orden_Pedido do on do.nro_orden = o.nro_orden
join Vehiculos_Terminados v on v.id_tipo_vehiculo = do.id_Vehiculo
WHERE f.fecha BETWEEN '2023-01-01' AND '2023-12-31'
GROUP BY nombre, Modelo,YEAR(f.fecha)
having COUNT(*) > 5
ORDER BY nombre, Modelo;

--En una misma tabla de resultados se quiere mostrar la cantidad de ordenes de pedido 
--que se ejecutaron, la mayor cantidad vendida y el costo total de las órdenes correspondiente
--al año en curso en primer lugar y las del año pasado en 2do lugar 

SELECT count(*) CantidadVendida,max(cantidad)'Mayor cantidad',
sum(df.precio_venta * df.cantidad) - SUM(df.descuento) CostoTotal,'Este año' Observaciones
FROM Orden_Pedido o join Facturas f on f.nro_orden = o.nro_orden
join DetalleFactura df on df.nroFac = f.nroFac
WHERE datediff(year,fecha,getdate())=0
UNION
SELECT count(*),max(cantidad),sum(df.precio_venta * df.cantidad) - SUM(df.descuento),'Año anterior'
FROM Orden_Pedido o join Facturas f on f.nro_orden = o.nro_orden
join DetalleFactura df on df.nroFac = f.nroFac
WHERE datediff(year,fecha,getdate())=1
ORDER BY 4 DESC

--Se requiere un listado,por forma de pago y forma de envio, con la cantidad total vendida, el importe y promedio vendido mensual del año en curso,
--siempre que esa cantidad sea superior al promedio de la cantidad global.
SELECT MONTH(fecha) Mes,fp.forma_pago FormaPago,fe.forma_envio FormaEnvio,sum(cantidad) 'Cantidad total vendida',
sum(cantidad*d.precio_venta)-SUM(d.descuento) Importe,
sum(cantidad*d.precio_venta)/count(distinct d.nroFac) PromedioVendido
FROM DetalleFactura d join Facturas f ON f.nroFac=d.nroFac
join Formas_Pago fp on fp.id_forma_pago = f.id_forma_pago
join Formas_envio fe on fe.id_forma_envio = f.id_forma_envio
WHERE YEAR(fecha) = YEAR(GETDATE())
GROUP BY fecha,fp.forma_pago,fe.forma_envio
having sum(cantidad)>(select avg(cantidad) from DetalleFactura)

--Emitir un listado que muestra el precio historico,precio actual y diferencia entre ambos de un vehículo específico que se pasara por variable.
CREATE PROCEDURE BuscarVehiculosPorDescripcion
@vehiculo VARCHAR(100) = '%'
AS
BEGIN
SELECT v.nombre NombreVehiculo, ph.precio_hist PrecioHistorico,
       v.precio PrecioActual,v.precio - ph.precio_hist Diferencia
FROM Vehiculos_Terminados AS v
JOIN Precios_Historicos AS ph ON v.id_vehiculo = ph.id_vehiculo
WHERE v.nombre LIKE '%' + @vehiculo + '%'
ORDER BY ph.fecha_precio;
END;

exec BuscarVehiculosPorDescripcion



--Se quiere el registro de los datos de los vendedores,cuántas ventas ha realizado cada uno,
--el importe total, y la primer y ultima fecha de venta, de los ultimos dos años;Mostrar esos datos siempre que 
--importe promedio de vendido sea superior al importe promedio general (importe promedio de todas las facturas).

SELECT YEAR(fecha) Año,
	   V.Id_vendedor Id,
       V.nom_vendedor +' '+V.ape_vendedor Vendedor,
       COUNT(DF.nroFac) CantidadVentas,
	   SUM(df.precio_venta * df.cantidad) - SUM(df.descuento) ImporteTotal,
	   MIN(fecha) PrimerFecha,
	   MAX(fecha) UltimaFecha
FROM Vendedores V JOIN Facturas F ON V.Id_vendedor = F.Id_vendedor
JOIN DetalleFactura DF ON F.nroFac = DF.nroFac
WHERE YEAR(fecha) in (2022,2023)
GROUP BY YEAR(fecha),V.Id_vendedor,V.nom_vendedor +' '+V.ape_vendedor
HAVING SUM(df.precio_venta * df.cantidad) - 
		  SUM(df.descuento) / COUNT(distinct f.nroFac) > (select sum(cantidad*precio_venta)/count(distinct nroFac)
												  from DetalleFactura)

--Encontrar el promedio de precios de autopartes por tipo de vehículo para aquellos tipos de vehículos que tienen al menos 3 autopartes registradas,
--y mostrarlo junto con el nombre del tipo de vehículo:

SELECT tv.nombre_tipo AS TipoVehiculo, AVG(a.precio) AS PrecioPromedioAutopartes
FROM Autopartes a
JOIN Tipos_Vehiculos tv ON a.id_tipo_autoparte = tv.id_tipo_vehiculo
WHERE a.precio IS NOT NULL
GROUP BY tv.nombre_tipo
HAVING COUNT(a.id_Autoparte) >= 3

UNION

SELECT 'Otros' AS TipoVehiculo, AVG(a.precio) AS PrecioPromedioAutopartes
FROM Autopartes a
WHERE a.id_tipo_autoparte NOT IN (
    SELECT id_tipo_vehiculo
    FROM Tipos_Vehiculos
) AND a.precio IS NOT NULL;

--Calcular la cantidad de órdenes de compra, el monto total de ventas y 
--el promedio de compras por tipo de cliente para los ultimos 12 meses.
SELECT tc.tipo_cliente TiposClientes,
       COUNT(op.nro_orden) AS CantidadOrdenes,
       SUM(df.precio_venta *cantidad) - SUM(df.descuento) AS MontoTotalVentas,
       SUM(df.precio_venta * df.cantidad) - SUM(df.descuento) / COUNT(distinct df.nroFac) AS PromedioVenta
FROM Clientes c JOIN Tipos_Clientes tc on tc.id_tipo_cliente = c.id_Tipo_Cliente
JOIN Orden_Pedido op ON c.Id_Cliente = op.id_cliente
JOIN DetalleFactura df ON op.nro_orden = df.nroFac
WHERE DATEDIFF(MONTH, op.fecha_entrega, GETDATE()) between 0 and 12
GROUP BY tc.tipo_cliente;

--En una misma tabla listar los datos de los clientes que estan en un autoplan y por otro lado
-- los clientes que tienen 2 o mas compras con nosotros, ya sea de vehiculos o autopartes
SELECT c.Id_cliente Id, c.ape_cliente +' '+c.nom_cliente Cliente,'Autoplan' Observaciones
FROM clientes c
WHERE c.Id_cliente in (select f.id_cliente
					   from AutoPlan a join DetalleFactura df on df.id_autoplan = a.id_autoplan
					   join Facturas f on df.nroFac = f.nroFac
					   where f.id_cliente  = c.Id_cliente)
UNION
SELECT c.Id_cliente, c.ape_cliente +' '+c.nom_cliente,'Mas de dos compras'
FROM clientes c join Facturas f on f.id_cliente = c.Id_cliente
GROUP BY c.Id_cliente,c.ape_cliente +' '+c.nom_cliente
HAVING  count(distinct f.nroFac) >= 2;

--Obtenga una lista de los montos totales facturados por vendedor para cada mes, 
--junto con el promedio de esos montos y el promedio de los precios de las autopartes. 
--Estos datos deben abarcar el período desde el 1° de junio hasta el 30 de diciembre de 2022. 
--Muestre únicamente aquellos datos en los que los montos totales sean iguales o superiores al promedio global.

SELECT 
    v.Id_vendedor  CODIGO, 
    v.ape_vendedor + ' ' +v.nom_vendedor  Vendedor,
    YEAR(f.fecha) AÑO,
	MONTH(f.fecha)  MES,
    SUM(d.precio_venta * d.cantidad)  MONTO_TOTAL,
    SUM(d.precio_venta * d.cantidad) / COUNT(DISTINCT d.nroFac)  PROMEDIO_MONTO_TOTAL,
    AVG(a.precio)  PROMEDIO_PRECIO_AUTOPARTES
FROM Facturas f
JOIN Vendedores v ON f.Id_vendedor = v.Id_vendedor
JOIN DetalleFactura d ON f.nroFac = d.nroFac
JOIN Autopartes a ON d.id_autoparte = a.id_autoparte
WHERE f.fecha BETWEEN '2022-06-01' AND '2022-12-30'
GROUP BY v.Id_vendedor,v.ape_vendedor + ' ' +v.nom_vendedor,YEAR(f.fecha), MONTH(f.fecha)
HAVING SUM(d.precio_venta * d.cantidad)>= (SELECT  SUM(precio_venta * cantidad) / COUNT(DISTINCT nroFac) 
											FROM DetalleFactura)


--Se quiere un listado con los datos de los vehiculos mas vendidos y por otro lado los que nunca se vendieron
SELECT TOP 3 v.id_vehiculo IdVehiculo,
           v.nombre Nombre, 
		   v.modelo Modelo,
		   COUNT(distinct do.id_detalle_orden_pedido) CantidadVentas,
		   'Mas vendidos' Observaciones
FROM Vehiculos_Terminados v join Detalle_Orden_Pedido do on do.id_Vehiculo = v.id_vehiculo
group by v.id_vehiculo,v.nombre,v.modelo
UNION
SELECT v.id_vehiculo ,
           v.nombre , 
		   v.modelo,
		   COUNT(distinct do.id_detalle_orden_pedido) CantidadVentas,
		   'Nunca se vendieron' Observaciones
FROM Vehiculos_Terminados v join Detalle_Orden_Pedido do on do.id_Vehiculo = v.id_vehiculo
where v.id_vehiculo not in (select d2.id_Vehiculo
							from Detalle_Orden_Pedido d2)
group by v.id_vehiculo,v.nombre,v.modelo
order by CantidadVentas