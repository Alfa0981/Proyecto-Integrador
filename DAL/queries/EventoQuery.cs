using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    internal class EventoQuery
    {
        public const string SeleccionarTodos = @"SELECT 
                                                e.evento_id, u.nombre, u.apellido, u.usuario, e.fecha, e.hora, e.modulo, e.descripcion, e.criticidad
                                                FROM 
                                                    Eventos e
                                                INNER JOIN 
                                                    Usuario u ON e.Usuario_Id = u.id";
        public const string Insertar = @"INSERT INTO Eventos (usuario_id, fecha, hora, modulo,
                                         descripcion, criticidad) VALUES (@UsuarioId, GETDATE(),
                                        GETDATE(), @Modulo, @Descripcion, @Criticidad)";
    }
}
