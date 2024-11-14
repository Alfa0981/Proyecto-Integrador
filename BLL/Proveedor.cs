using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Proveedor
    {
        DAL.MpProveedor mpProveedor = new DAL.MpProveedor();
        BLL.GestionEventos gestorEventos = new BLL.GestionEventos();

        public void eliminar(BE.Proveedor proveedor)
        {
            proveedor.Activo = false;
            mpProveedor.modificar(proveedor);
            gestorEventos.persistirEvento("Proveedor eliminado", BE.Modulos.Compras.ToString(), 1);
            DV.Instance.Generar();
        }

        public void insertarProveedor(BE.Proveedor proveedor)
        {
            if (mpProveedor.buscarPorDni(proveedor) != null)
            {
                throw new Exception("El proveedor ya existe");
            }
            mpProveedor.CrearProveedor(proveedor);
            gestorEventos.persistirEvento("Nuevo proveedor", BE.Modulos.Compras.ToString(), 3);
            DV.Instance.Generar();
        }

        public void modificar(BE.Proveedor proveedor)
        {
            mpProveedor.modificar(proveedor);
            gestorEventos.persistirEvento("Proveedor modificado", BE.Modulos.Compras.ToString(),3);
            DV.Instance.Generar();
        }

        public List<BE.Proveedor> obtenerTodos() 
        {
            return mpProveedor.obtenerTodos();
        }
    }
}
