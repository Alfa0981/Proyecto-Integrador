using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BackupRestore
    {
        Acceso acceso = new Acceso();

        public void RealizarBackup(string backupPath)
        {
            string nombreArchivo = $"MiSistema.BCK_{DateTime.Now:ddMMyy_HHmm}.bak";
            string rutaCompleta = System.IO.Path.Combine(backupPath, nombreArchivo);
            string comandoBackup = $"BACKUP DATABASE ProyectoIntegrador TO DISK='{rutaCompleta}'";

            acceso.escribir(comandoBackup, null);
        }
        public void RealizarRestore(string backupFilePath)
        {
            try
            {
                acceso.conectar();

                acceso.escribir("USE master;", null);
                acceso.escribir("ALTER DATABASE ProyectoIntegrador SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", null);

                string comandoRestore = $"RESTORE DATABASE ProyectoIntegrador FROM DISK = '{backupFilePath}' WITH REPLACE;";
                acceso.escribir(comandoRestore, null);

                acceso.escribir("ALTER DATABASE ProyectoIntegrador SET MULTI_USER;", null);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al restaurar la base de datos: {ex.Message}");
            }
            finally
            {
                acceso.desconectar();
            }
        }
    }
}
