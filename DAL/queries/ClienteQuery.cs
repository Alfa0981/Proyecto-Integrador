using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public abstract class ClienteQuery
    {
        public const string SeleccionarTodos = @"SELECT * FROM CLIENTE c WHERE c.activo = 1";
        public const string Insertar = @"INSERT INTO Cliente (apellido,direccion,dni,email,nombre,telefono)
                                    VALUES (@Apellido,@Direccion, @Dni, @Email,@Nombre, @Telefono)";
        public const string BuscarPorId = "SELECT * FROM CLIENTE c WHERE c.id = @Id";
        public const string BuscarPorDni = "SELECT * FROM CLIENTE c WHERE c.dni = @Dni";
        public const string Actualizar = @"UPDATE Cliente
                                            SET nombre = @Nombre,
                                                apellido = @Apellido,
                                                direccion = @Direccion,
                                                dni = @Dni,
                                                telefono = @Telefono,
                                                email = @Email,
                                                activo = @Activo
                                            WHERE id = @Id;";


    }
}
