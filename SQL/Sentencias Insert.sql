INSERT INTO AutoPlan (cant_cuotas, Importe_Cuota, interes, fecha)
VALUES (12, 5000.00, 1.5, '2023-10-10'),
       (24, 3000.00, 1.6, '2023-10-11'),
       (18, 4500.00, 0.4, '2023-10-12'),
       (36, 2500.00, 0.7, '2023-9-13'),
       (6, 7000.00, 1.3, '2023-9-14'),
       (48, 2000.00, 0.9, '2023-9-15'),
       (9, 6000.00, 0.8, '2022-10-16'),
       (15, 4000.00, 0.4, '2022-10-17'),
       (30, 2750.00, 0.65, '2022-10-18'),
       (21, 3500.00, 1.55, '2022-10-19')

-- Insertar valores en la tabla Tipos_autopartes
INSERT INTO Tipos_autopartes (descripcion)
VALUES
    ('Motor'),
    ('Frenos'),
    ('Caja de cambios'),
    ('Baterías'),
    ('Ruedas y llantas'),
    ('Chasis'),
    ('Dirección'),
    ('Fusibles'),
    ('Suspensión'),
    ('Radiadores');


-- Insertar valores en la tabla Autopartes
INSERT INTO Autopartes (nombre, id_tipo_autoparte, precio, stock_minimo, stock_actual)
VALUES
    ('Filtro de Aceite Bosch', 1, 10000.00, 10, 50),
    ('Pastillas de Frenos Ferodo', 2, 20000.00, 15, 40),
    ('Amortiguador Monroe', 9, 8000.00, 20, 30),
    ('Batería Varta', 4, 35000.00, 5, 15),
    ('Neumático Pirelli', 5, 60000.00, 10, 20),
    ('Aceite de Motor Shell', 1, 10000.00, 10, 60),
    ('Correa de Distribución Dayco', 7, 17000.00, 5, 10),
    ('Volante Fiat', 8, 20000.00, 10, 50),
    ('Embrague Luk', 2, 8000.00, 5, 25),
    ('Radiador Behr', 10, 4000.00, 5, 15);
--TIPOS CLIENTES
INSERT INTO Tipos_Clientes(tipo_cliente)
VALUES('Vendedora de autopartes')
INSERT INTO tipos_clientes(tipo_cliente)
VALUES('Consumidor final')
INSERT INTO tipos_clientes(tipo_cliente)
VALUES('Empresa')
INSERT INTO tipos_clientes(tipo_cliente)
VALUES('Concesionario')
--PAISES
INSERT INTO Paises(pais) 
VALUES ('Argentina'),
    ('Chile'),
    ('Uruguay');
--PROVINCIAS
INSERT INTO provincias (provincia, id_pais) VALUES
   ('Buenos Aires', 1),
   ('Córdoba', 1),
   ('Santa Fe', 1),
   ('Mendoza', 1),
   ('Tucumán', 1),
   ('Salta', 1),
   ('Entre Ríos', 1);
--LOCALIDADES
INSERT INTO localidades (localidad, id_provincia) VALUES
   ('La Plata', 1), -- Buenos Aires
   ('Córdoba Capital', 2), -- Córdoba
   ('Rosario', 3), -- Santa Fe
   ('Mendoza Capital', 4), -- Mendoza
   ('San Miguel de Tucumán', 5), -- Tucumán
   ('Salta Capital', 6), -- Salta
   ('Paraná', 7), -- Entre Ríos
   ('Villa María', 2), -- Córdoba
   ('Río Cuarto', 2), -- Córdoba
   ('Alta Gracia', 2); -- Córdoba
--BARRIOS

INSERT INTO barrios (nombreBarrio, id_localidad) VALUES
   ('Nueva Córdoba', 2), -- Córdoba Capital
   ('Alberdi', 2), -- Córdoba Capital
   ('Güemes', 2), -- Córdoba Capital
   ('Altos de San Martín', 2),
   ('Jardín Espinosa', 2),
   ('Los Boulevares', 2),
   ('Villa Cabrera', 2),
   ('Centro', 2),
   ('Alto Alberdi', 2),
   ('Talleres Este', 2),
   ('Ayacucho', 2);
--CLIENTES
INSERT INTO clientes (ape_cliente , nom_cliente ,id_tipo_cliente ,  mail ,calle , altura ,id_barrio)
VALUES('Lafalda concesionario SA.' ,'null',4 ,'concesionario@gmail.com' , 'av  38' ,1200,3 )

INSERT INTO clientes (ape_cliente , nom_cliente ,id_tipo_cliente ,  mail ,calle , altura ,id_barrio)
VALUES('Repuestos cba SA.' ,'null',1 ,'repuestos@hotmail.com' , 'la tablada' ,1500 ,2 )

INSERT INTO clientes (ape_cliente , nom_cliente ,id_tipo_cliente ,  mail ,calle , altura ,id_barrio)
VALUES('Morales' ,'Hector',2 ,'hectormo@hotmail.com' , 'rosamonte' ,2500 ,1 )

INSERT INTO clientes (ape_cliente , nom_cliente ,id_tipo_cliente , mail ,calle , altura ,id_barrio,fecha_nac)
VALUES('Salas' ,'Maria',2  ,'Maria@hotmail.com' , 'las palmeras' ,700 ,5 ,'18/02/1983' )
--COLORES
INSERT INTO Colores (descripcion) VALUES ('Rojo');
INSERT INTO Colores (descripcion) VALUES ('Azul');
INSERT INTO Colores (descripcion) VALUES ('Verde');
INSERT INTO Colores (descripcion) VALUES ('Blanco');
INSERT INTO Colores (descripcion) VALUES ('Negro');
INSERT INTO Colores (descripcion) VALUES ('Gris');
--TIPOSV
INSERT INTO Tipos_Vehiculos (nombre_tipo) VALUES ('Automóvil');
INSERT INTO Tipos_Vehiculos (nombre_tipo) VALUES ('Camioneta');
INSERT INTO Tipos_Vehiculos (nombre_tipo) VALUES ('Motocicleta');


create PROCEDURE SP_CONSULTAR_FACTURA
    @cliente int,
    @fechadesde datetime,
    @fechahasta datetime
AS
BEGIN
    SELECT f.nroFac nroFac, c.ape_cliente   Cliente, fecha, cantidad * precio_venta Total
    FROM Facturas f
    JOIN clientes c ON c.Id_cliente = f.id_cliente 
    JOIN DetalleFactura df ON df.nroFac = f.nroFac
    WHERE f.id_cliente = @cliente
    AND fecha BETWEEN @fechadesde AND @fechahasta;

END; 

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_AUTOPARTES]
AS
BEGIN
	
	SELECT * from Autopartes;
END
GO
--Facturas
--
CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES]
AS
BEGIN
	
	SELECT * from clientes;
END
GO
--no ejecute
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_INSERTAR_DETALLE] 
    @fac int,
    @id_autoparte int, 
    @cantidad int,
    @precio money
AS
BEGIN
    -- Insertar detalle en la tabla DetalleFactura
    INSERT INTO DetalleFactura (nroFac, id_autoparte, cantidad, precio_venta)
    VALUES (@fac, @id_autoparte, @cantidad, @precio);

END
GO

--no ejecute
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_INSERTAR_MAESTRO] 
	@cliente int, 
	@nroFac int OUTPUT
AS
BEGIN
	INSERT INTO Facturas(fecha,id_cliente)
    VALUES (GETDATE(), @cliente);
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @nroFac = SCOPE_IDENTITY();

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(nroFac)+1  FROM Facturas);
END
GO

--facturas
CREATE PROCEDURE SP_CONSULTAR_FACTURAS
    @fecha_desde DATETIME,
    @fecha_hasta DATETIME,
    @cliente_id INT
AS
BEGIN
    SELECT
        id_cliente,
        nroFac,
        fecha
    FROM
        Facturas 
    WHERE
        fecha BETWEEN @fecha_desde AND @fecha_hasta
        AND id_cliente = @cliente_id
		and fecha_baja is null;;
END;

CREATE PROCEDURE SP_ELIMINAR_FACTURA
    @nro_factura INT
AS
BEGIN
    -- Eliminar la factura
    DELETE DetalleFactura where nroFac = @nro_factura
	DELETE FROM Facturas WHERE nroFac = @nro_factura;

END;

CREATE PROCEDURE SP_CONSULTAR_FACTURAS_BY_ID
    @nro INT
AS
BEGIN
    SELECT
        nroFac,
        id_cliente,
        fecha
    FROM
        Facturas
    WHERE
        nroFac = @nro
		
END;

CREATE PROCEDURE SP_MODIFICAR_MAESTRO
    @fac_nro INT,
    @cliente int,
    @fecha DATE
AS
BEGIN
    UPDATE facturas
    SET
        id_cliente = @cliente,
        fecha = @fecha
    WHERE
        nroFac = @fac_nro;
END;
CREATE PROCEDURE SP_MODIFICAR_DETALLE
    @fac INT,
    @id_autoparte INT,
    @cantidad INT,
    @precio MONEY
AS
BEGIN
	UPDATE DetalleFactura
    SET id_autoparte = @id_autoparte,
		cantidad = @cantidad,
        precio_venta = @precio
    WHERE nroFac = @fac  ;
END;



create proc sp_baja_factura
	@nro int
as
begin
	update Facturas
	set fecha_baja  = GETDATE()
	where nroFac = @nro
end

CREATE PROCEDURE SP_INSERTAR_VEHICULO
    @nombre VARCHAR(50),
    @idcolor INT,
    @idtipov INT,
    @pre MONEY,
    @modelo INT
AS
BEGIN
-- Insertar el nuevo vehículo en la tabla Vehiculos_Terminados
        INSERT INTO Vehiculos_Terminados (nombre, color, id_tipo_vehiculo, precio, modelo)
        VALUES (@nombre, @idcolor, @idtipov, @pre, @modelo);
END;

CREATE PROCEDURE sp_consultar_colores
AS
BEGIN
    SELECT id_color, descripcion
    FROM Colores;
END;

CREATE PROCEDURE sp_consultar_tiposV
AS
BEGIN
    SELECT *
    FROM Tipos_Vehiculos;
END;
CREATE PROCEDURE SP_CONSULTAR_VEHICULOS
    @precio_desde DECIMAL,
    @precio_hasta DECIMAL,
    @tipov INT
AS
BEGIN
	SELECT
		v.id_vehiculo,
		v.nombre,
		v.color,
		v.id_tipo_vehiculo,
		v.modelo,
		v.precio
	FROM
		Vehiculos_Terminados v
	WHERE
		v.precio between @precio_desde AND @precio_hasta 
		AND v.id_tipo_vehiculo = @tipov;
END;

CREATE PROCEDURE SP_ELIMINAR_VEHICULO
    @idVehiculo INT
AS
BEGIN
    DELETE FROM Vehiculos_Terminados
    WHERE id_vehiculo = @idVehiculo;
END
CREATE PROCEDURE SP_INSERTAR_AUTOPARTE
    @nombre varchar(100),
    @idtipoa INT,
    @pre money,
    @stock_min INT,
    @stock_act INT
AS
BEGIN
    INSERT INTO Autopartes(nombre, id_tipo_autoparte, precio, stock_minimo, stock_actual)
    VALUES (@nombre, @idtipoa, @pre, @stock_min, @stock_act);
END;

CREATE PROCEDURE sp_consultar_tiposA
AS
BEGIN
    SELECT *
    FROM Tipos_autopartes;
END;
-- Crear el stored procedure para eliminar una autoparte
CREATE PROCEDURE SP_ELIMINAR_AUTOPARTE
    @idAutoparte INT
AS
BEGIN
    -- Eliminar la autoparte de la tabla correspondiente
    DELETE FROM Autopartes
    WHERE id_autoparte = @idAutoparte;
END;

CREATE PROCEDURE SP_CONSULTAR_AUTOPARTES_FILTROS
    @stock INT,
    @tipoa INT
AS
BEGIN
    -- Seleccionar autopartes con stock actual mayor que el valor especificado
    SELECT
        id_Autoparte,
        nombre,
        id_tipo_autoparte,
        stock_minimo,
        stock_actual,
        precio
    FROM
        Autopartes
    WHERE
        stock_actual > @stock
        AND (@tipoa IS NULL OR id_tipo_autoparte = @tipoa);
END;
-- Crear el stored procedure para modificar una autoparte
CREATE PROCEDURE SP_MODIFICAR_AUTOPARTE
    @nombre VARCHAR(200),
    @id_tipoA INT,
    @id_autoparte INT,
    @precio MONEY,
    @stockAct INT,
    @stockMin INT
AS
BEGIN
    -- Actualizar la información de la autoparte en la tabla correspondiente
    UPDATE Autopartes
    SET
        nombre = @nombre,
        id_tipo_autoparte = @id_tipoA,
        precio = @precio,
        stock_actual = @stockAct,
        stock_minimo = @stockMin
    WHERE
        id_Autoparte = @id_autoparte;
END;
-- Crear el stored procedure para modificar un vehículo
CREATE PROCEDURE SP_MODIFICAR_VEHICULO
    @nombre VARCHAR(100),
    @id_tipoV INT,
    @id_color INT,
    @id_autoparte INT,
    @precio MONEY,
    @modelo INT
AS
BEGIN
    -- Actualizar la información del vehículo en la tabla correspondiente
    UPDATE Vehiculos_Terminados
    SET
        nombre = @nombre,
        id_tipo_vehiculo = @id_tipoV,
        color = @id_color,
        precio = @precio,
        modelo = @modelo
    WHERE
        id_vehiculo = @id_autoparte;
END;