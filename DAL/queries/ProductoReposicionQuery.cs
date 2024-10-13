using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public class ProductoReposicionQuery
    {
        public const string InsertarRegistro = @"
        INSERT INTO ProductosReposicion (productoId, ordenCompraId, faltantes) VALUES (@ProductoId, @OrdenCompraId, @Faltantes)";
    }
}
