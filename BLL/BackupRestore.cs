using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BackupRestore
    {
        DAL.BackupRestore backup = new DAL.BackupRestore();

        public void RealizarBackup(string backupPath)
        {
            backup.RealizarBackup(backupPath);
        }
        public void RealizarRestore(string restorePath)
        {
            backup.RealizarRestore(restorePath);
        }
    }
}
