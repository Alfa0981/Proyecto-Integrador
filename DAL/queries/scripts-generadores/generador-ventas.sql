DECLARE @i INT = 2130;

WHILE @i <= 100
BEGIN
    INSERT INTO Cliente (nombre, apellido, direccion, dni, telefono, email)
    VALUES (
        CONCAT('Nombre', @i),  -- Generar un nombre como 'Nombre1', 'Nombre2', ...
        CONCAT('Apellido', @i),  -- Generar un apellido
        CONCAT('Calle ', @i),  -- Dirección ficticia
        FLOOR(RAND() * 100000000) + 20000000,  -- DNI aleatorio
        CONCAT('+54 9 11 ', @i),  -- Teléfono ficticio
        CONCAT('cliente', @i, '@correo.com')  -- Email ficticio
    );

    SET @i = @i + 1;
END;

-- Inserta 3 facturas para cada cliente en el último mes con carritos asociados
DECLARE @cliente_id INT;
DECLARE @fecha DATE;
DECLARE @carrito_id INT;
DECLARE @precio_final DECIMAL(10, 2);
DECLARE @i INT = 2130;

WHILE @i <= 2230
BEGIN
    SET @cliente_id = @i;

    -- Insertar 3 compras por cliente
    DECLARE @j INT = 1;
    WHILE @j <= 3
    BEGIN
        -- Generar una fecha aleatoria dentro del último mes
        SET @fecha = DATEADD(DAY, -FLOOR(RAND() * 30), GETDATE());

        -- Generar un precio final aleatorio para el carrito
        SET @precio_final = FLOOR(RAND() * 5000) + 100;  -- Precio entre 100 y 5000

        -- Insertar un carrito
        INSERT INTO Carrito (cliente_id, precioFinal)
        VALUES (@cliente_id, @precio_final);

        -- Obtener el id del carrito recién creado
        SET @carrito_id = SCOPE_IDENTITY();

        -- Insertar la factura correspondiente
        INSERT INTO Factura (cliente_id, carrito_id, fecha, precio)
        VALUES (@cliente_id, @carrito_id, @fecha, @precio_final);

        -- Insertar productos en el carrito (2-5 productos aleatorios)
        DECLARE @k INT = 1;
        DECLARE @producto_id INT;
        WHILE @k <= FLOOR(RAND() * 4) + 2  -- Número aleatorio de productos (entre 2 y 5)
        BEGIN
            SET @producto_id = FLOOR(RAND() * 7) + 1;  -- Producto_id aleatorio (entre 1 y 7)

            INSERT INTO CarritoProducto (carrito_id, producto_id, cantidad)
            VALUES (@carrito_id, @producto_id, 10);

            SET @k = @k + 1;
        END;

        SET @j = @j + 1;
    END;

    SET @i = @i + 1;
END;