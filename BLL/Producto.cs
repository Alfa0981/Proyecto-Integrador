﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto
    {
        MpProducto mpUsuario = new MpProducto();

        public List<BE.Producto> mostrarTodos()
        {
            return mpUsuario.buscarTodos();
        }
    }
}