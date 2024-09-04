using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class BackupRestore
    {
        public bool VerificarRutaBackup(string ruta)
        {
            return Directory.Exists(Path.GetDirectoryName(ruta));
        }

        public bool VerificarArchivoRestore(string rutaArchivo)
        {
            return File.Exists(rutaArchivo) && Path.GetExtension(rutaArchivo).Equals(".bak", StringComparison.OrdinalIgnoreCase);
        }
    }
}
