using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    internal class ProductoQuery
    {
        public const string SeleccionarTodos = @"SELECT p.* FROM Producto p WHERE p.activo = 1";
        public const string Modificar = @"UPDATE Producto
                                            SET nombre = @Nombre,
                                                stock = @Stock,
                                                precio = @Precio,
                                                activo = @Activo
                                            WHERE id = @Id;";
        public const string Insertar = @"
                                        INSERT INTO Producto (nombre, stock, precio) 
                                        VALUES (@Nombre, @Stock, @Precio);";
    }
}
