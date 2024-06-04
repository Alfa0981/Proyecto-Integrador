using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public abstract class ClienteQuery
    {
        public const string SeleccionarTodos = @"SELECT c.*, FROM CLIENTE c";
        public const string Insertar = @"INSERT INTO Cliente (apellido,direccion,dni,email,nombre,telefono)
                                    VALUES ('@Apellido','@Direccion', '@Dni', '@Email','@Nombre', '@Telefono')";
        public const string BuscarPorId = "SELECT * FROM CLIENTE c WHERE c.id = @Id";
        
    }
}
