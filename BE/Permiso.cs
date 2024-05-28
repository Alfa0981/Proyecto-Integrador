using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal class Permiso : PermisoComponent
    {
        public Permiso(string nombre)
        {
            Nombre = nombre;
        }

        public override string Nombre { get; }

        public override void Agregar(PermisoComponent componente)
        {
            throw new NotImplementedException("No se puede agregar un permiso a un permiso individual.");
        }

        public override void Remover(PermisoComponent componente)
        {
            throw new NotImplementedException("No se puede remover un permiso de un permiso individual.");
        }

        public override bool TienePermiso(string permiso)
        {
            return Nombre == permiso;
        }
    }
}
