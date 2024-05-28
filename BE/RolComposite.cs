using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal class RolComposite : PermisoComponent
    {
        private readonly List<PermisoComponent> _componentes = new List<PermisoComponent>();

        public RolComposite(string nombre)
        {
            Nombre = nombre;
        }

        public override string Nombre { get; }

        public override void Agregar(PermisoComponent componente)
        {
            _componentes.Add(componente);
        }

        public override void Remover(PermisoComponent componente)
        {
            _componentes.Remove(componente);
        }

        public override bool TienePermiso(string permiso)
        {
            foreach (var componente in _componentes)
            {
                if (componente.TienePermiso(permiso))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
