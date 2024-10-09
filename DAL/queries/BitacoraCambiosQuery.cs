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
        
        public const string ActivarRegistro = "update Productos_C set Act = 1 where id = @Id;";
        public const string DesactivarRegistro = "update Productos_C set Act = 0 where Cod_Prod = @Cod_Prod;";
        public const string DesactivarTrigger = "DISABLE TRIGGER trg_AfterUpdateProductos ON Producto;";
        public const string ActivarTrigger = "ENABLE TRIGGER trg_AfterUpdateProductos ON Producto;";
    }
}
