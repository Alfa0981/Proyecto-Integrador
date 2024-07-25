using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Perfil
    {
        MpPerfil mpPerfil = new MpPerfil();

        public void crearFamilia(BE.Familia familia)
        {
            mpPerfil.CrearFamilia(familia);
        }

        public List<BE.Familia> obtenerTodasFamilias()
        {
            return mpPerfil.ObtenerTodasLasFamilias();
        }

        public List<BE.Perfil> obtenerTodosPerfiles()
        {
            return mpPerfil.ObtenerTodosPerfiles();
        }

        public void crearPerfil(BE.Familia perfil)
        {
            mpPerfil.CrearPerfil(perfil);
        }

        public void EliminarFamilia(int id)
        {
            mpPerfil.eliminarFamilia(id);
        }

        public void EliminarPerfil(int id)
        {
            mpPerfil.eliminarPerfil(id);
        }
    }
}
