﻿using DAL;
using Services;
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
        BLL.GestionEventos gestionEventos = new BLL.GestionEventos();

        public BE.Cliente buscarPorId(int id)
        {
            BE.Cliente cliente = mpCliente.buscarPorId(id);
            cliente.Direccion = UserEncryption.DecryptData(cliente.Direccion);
            return cliente;
        }

        public List<BE.Cliente> buscarTodos()
        {
            List<BE.Cliente> clientes = mpCliente.buscarTodos();
            foreach (BE.Cliente cliente  in clientes)
            {
                cliente.Direccion = UserEncryption.DecryptData(cliente.Direccion);
            }
            return clientes;
        }

        public void crear(BE.Cliente cliente)
        {
            if (mpCliente.buscarPorDni(cliente.Dni) != null)
            {
                throw new Exception();
            }
            mpCliente.crear(cliente);
            gestionEventos.persistirEvento("Nuevo cliente", BE.Modulos.Clientes.ToString(), 2);
            DV.Instance.Generar();
        }

        public void eliminar(BE.Cliente cliente)
        {
            cliente.Activo = false;
            mpCliente.modificar(cliente);
            gestionEventos.persistirEvento("Cliente eliminado", BE.Modulos.Clientes.ToString(), 1);
            DV.Instance.Generar();
        }

        public void modificar(BE.Cliente cliente)
        {
            mpCliente.modificar(cliente);
            gestionEventos.persistirEvento("Cliente actualizado", BE.Modulos.Clientes.ToString(), 2);
            DV.Instance.Generar();
        }
    }
}
