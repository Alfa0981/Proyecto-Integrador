using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public abstract class PerfilQuery
    {
        public const string InsertarPerfil = @"INSERT INTO Perfil (Nombre, Tipo)
                                           VALUES (@Nombre, @Tipo);
                                           SELECT SCOPE_IDENTITY();";

        public const string InsertarRelacion = @"INSERT INTO PerfilRelacion (PerfilID, RelacionadoID)
                                             VALUES (@PerfilID, @RelacionadoID);";

        public const string ObtenerPerfilPorNombre = @"SELECT ID FROM Perfil
                                                   WHERE Nombre = @Nombre;";

        public const string ActualizarPerfil = @"UPDATE Perfil
                                             SET Nombre = @Nombre
                                             WHERE ID = @ID;";

        public const string ObtenerRelaciones = @"SELECT RelacionadoID FROM PerfilRelacion WHERE PerfilID = @FamiliaID;";

        public const string EliminarRelacionEspecifica = @"DELETE FROM PerfilRelacion
                                                  WHERE PerfilID = @FamiliaID AND RelacionadoID = @RelacionadoID;";

        public const string ObtenerTodasFamilias = @"
                                                    SELECT 
                                                        p.ID,
                                                        p.Nombre,
                                                        p.Tipo,
                                                        pr.PerfilID AS ParentID
                                                    FROM 
                                                        Perfil p
                                                    LEFT JOIN 
                                                        PerfilRelacion pr ON p.ID = pr.RelacionadoID
                                                    WHERE 
                                                        p.Tipo IN ('Familia', 'Patente')";

        public const string VerificarExistenciaRelacion = @"SELECT COUNT(*) FROM PerfilRelacion WHERE PerfilID = @PerfilID AND RelacionadoID = @RelacionadoID";
        public const string ObtenerTodosPerfilesConRelaciones = @"
                                            SELECT 
                                                p.ID,
                                                p.Nombre,
                                                p.Tipo,
                                                pr.PerfilID AS ParentID
                                            FROM 
                                                Perfil p
                                            LEFT JOIN 
                                                PerfilRelacion pr ON p.ID = pr.RelacionadoID";
        public const string EliminarRelacionesPorFamilia = "DELETE FROM PerfilRelacion WHERE PerfilID = @FamiliaID OR RelacionadoID = @FamiliaID;";
        public const string EliminarFamiliaId = "DELETE FROM Perfil WHERE ID = @FamiliaID AND Tipo = 'Familia';";
        public const string EliminarPerfilId = "DELETE FROM Perfil WHERE ID = @FamiliaID AND Tipo = 'Perfil';";


    }
}
