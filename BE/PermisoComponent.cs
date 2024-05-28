using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class PermisoComponent
    {
        public abstract string Nombre { get; }
        public abstract void Agregar(PermisoComponent componente);
        public abstract void Remover(PermisoComponent componente);
        public abstract bool TienePermiso(string permiso);
    }
}
