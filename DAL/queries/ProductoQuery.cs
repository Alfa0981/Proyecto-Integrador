using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    internal class ProductoQuery
    {
        public const string SeleccionarTodos = @"SELECT p.* FROM Producto p";
        public const string Modificar = @"UPDATE Producto
                                            SET nombre = @Nombre,
                                                stock = @Stock,
                                                fechaExp = @FechaExp,
                                                precio = @Precio
                                            WHERE id = @Id;";
        public const string Insertar = @"
                                        INSERT INTO Producto (nombre, stock, fechaExp, precio) 
                                        VALUES (@Nombre, @Stock, @FechaExp, @Precio);";
    }
}
