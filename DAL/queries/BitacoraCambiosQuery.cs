using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public class BitacoraCambiosQuery
    {
        public const string SeleccionarTodos = @"
                                                    SELECT 
                                                        pc.id, 
                                                        p.id AS Cod_Prod, 
                                                        p.precio,
                                                        p.Nombre, 
                                                        pc.Fecha, 
                                                        pc.Hora, 
                                                        pc.Stock, 
                                                        pc.Act 
                                                    FROM 
                                                        Productos_C pc
                                                    INNER JOIN 
                                                        Producto p ON pc.Cod_Prod = p.id;
                                                ";
        public const string DeleteUltimaFila = @"DELETE FROM Productos_C
                                                    WHERE id = (
                                                        SELECT TOP 1 id
                                                        FROM Productos_C
                                                        WHERE Cod_Prod = @Cod_Prod
                                                        ORDER BY Fecha DESC, hora DESC
                                                    );
                                                ";
        public const string UpdateUltimaFila = "update Productos_C set Act = 1 where id = @Id;";
    }
}
