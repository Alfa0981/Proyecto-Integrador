using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal class Familia : Perfil
    {
        private readonly List<Perfil> _componentes = new List<Perfil>();

        public Familia(string nombre)
        {
            Nombre = nombre;
        }

        public override string Nombre { get; }

        public override void Agregar(Perfil componente)
        {
            _componentes.Add(componente);
        }

        public override void Remover(Perfil componente)
        {
            _componentes.Remove(componente);
        }

        public override bool TienePermiso(TippoPermiso permiso)
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
