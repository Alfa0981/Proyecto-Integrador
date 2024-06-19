using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Perfil
    {
        public abstract string Nombre { get; }
        public abstract void Agregar(Perfil perfil);
        public abstract void Remover(Perfil perfil);
        public abstract bool TienePermiso(TippoPermiso permiso);
    }
}
