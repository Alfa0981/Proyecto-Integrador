using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public class ProveedorQuery
    {
        public const string BuscarPorDni = @"
        SELECT * FROM Proveedor p WHERE p.Dni = @Dni AND p.Activo = 1";
        public const string ObtenerTodos = @"SELECT 
                                                p.id AS ProveedorId, 
                                                p.Nombre AS ProveedorNombre, 
                                                p.Email, 
                                                p.Telefono, 
                                                p.Direccion, 
                                                p.Dni, 
                                                pr.id AS ProductoId, 
                                                pr.Nombre AS ProductoNombre, 
                                                pr.Stock,
												p.Activo
                                            FROM 
                                                Proveedor p
                                            INNER JOIN 
                                                ProveedorProducto pp ON p.id = pp.ProveedorId
                                            INNER JOIN 
                                                Producto pr ON pp.ProductoId = pr.id
                                            WHERE p.Activo = 1;
                                            ";
        public const string InsertarProveedor = @"INSERT INTO Proveedor (Nombre, Email, Telefono, Direccion, Dni) 
                                                    VALUES (@Nombre, @Email, @Telefono, @Direccion, @Dni);
                                                   SELECT SCOPE_IDENTITY();";

        public const string InsertarProveedorProducto = @"INSERT INTO ProveedorProducto (ProveedorId, ProductoId) 
                                                            VALUES (@ProveedorId, @ProductoId);";
        public const string Actualizar = @"UPDATE Proveedor
                                            SET nombre = @Nombre,
                                                direccion = @Direccion,
                                                dni = @Dni,
                                                telefono = @Telefono,
                                                email = @Email,
                                                activo = @Activo
                                            WHERE id = @Id;";
        public const string EliminarPorProveedor = @"DELETE FROM ProveedorProducto 
                                             WHERE ProveedorId = @ProveedorId;";
    }
}
