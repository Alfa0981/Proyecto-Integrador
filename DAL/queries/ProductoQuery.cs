using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    internal class ProductoQuery
    {
        public const string SeleccionarTodos = @"SELECT p.*, pr.id AS ProveedorId, pr.nombre AS ProveedorNombre, pr.dni, pr.direccion, pr.telefono, pr.email, pr.activo
                                                FROM Producto p
                                                LEFT JOIN ProveedorProducto pp ON p.id = pp.ProductoId
                                                LEFT JOIN Proveedor pr ON pp.ProveedorId = pr.id AND pr.activo = 1
                                                WHERE p.activo = 1;";
        public const string Modificar = @"UPDATE Producto
                                            SET nombre = @Nombre,
                                                stock = @Stock,
                                                precio = @Precio,
                                                activo = @Activo
                                            WHERE id = @Id;";
        public const string Insertar = @"
                                        INSERT INTO Producto (nombre, stock, precio) 
                                        VALUES (@Nombre, @Stock, @Precio);";
        public const string ModificarStock = "UPDATE Producto SET Stock = Stock + @cantidad WHERE id = @idProducto";
    }
}
