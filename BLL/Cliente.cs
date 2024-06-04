using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente
    {
        MpCliente mpCliente = new MpCliente();

        public BE.Cliente buscarPorId(int id)
        {
            return mpCliente.buscarPorId(id);
        }
    }
}
