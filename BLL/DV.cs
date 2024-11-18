using DAL;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DV
    {
        private static DV _instance;
        public static DV Instance => _instance ?? (_instance = new DV());
        MpDV mpDV = new MpDV();

        private static readonly string[] tablas = {"Carrito", "Cliente", "Factura", "OrdenCompra", "PedidoCotizacion", "Producto", "Proveedor"};
        long DVHCalculado = 0;
        long DVVCalculado = 0;

        private DV()
        {
        }

        private long GenerarDVH(string tabla)
        {
            List<Dictionary<string, object>> filas = mpDV.ObtenerDatosTabla(tabla); 

            List<long> DVHs = new List<long>();

            foreach (var fila in filas)
            {
                StringBuilder filaConcatenada = new StringBuilder();
                foreach (var valor in fila.Values)
                {
                    filaConcatenada.Append(valor.ToString());
                }

                long DVH = CalcularCRC32(filaConcatenada.ToString());
                DVHs.Add(DVH);
            }
            return DVHs.Sum() % 1000000000000;
        }

        private long GenerarDVV(string tabla)
        {
            List<Dictionary<string, object>> filas = mpDV.ObtenerDatosTabla(tabla); 

            Dictionary<string, StringBuilder> columnasConcatenadas = new Dictionary<string, StringBuilder>();

            if (filas.Count == 0)
            {
                return 0;
            }
            foreach (var columna in filas.First().Keys)
            {
                columnasConcatenadas[columna] = new StringBuilder();
            }

            foreach (var fila in filas)
            {
                foreach (var columna in fila.Keys)
                {
                    columnasConcatenadas[columna].Append(fila[columna].ToString());
                }
            }

            StringBuilder columnasTotalesConcatenadas = new StringBuilder();
            foreach (var sb in columnasConcatenadas.Values)
            {
                columnasTotalesConcatenadas.Append(sb.ToString());
            }

            long DVV = CalcularCRC32(columnasTotalesConcatenadas.ToString());

            return DVV % 1000000000000;
        }

        public void Generar()
        {
            long DVH = 0;
            long DVV = 0;

            foreach (var tabla in tablas)
            {
                DVH += GenerarDVH(tabla);
                DVV += GenerarDVV(tabla);
            }
            mpDV.ActualizarDV(DVH, DVV);
        }

        private static uint CalcularCRC32(string input)
        {
            uint[] crcTable = new uint[256];
            const uint polynomial = 0xedb88320;

            for (uint i = 0; i < 256; i++)
            {
                uint crc = i;
                for (uint j = 8; j > 0; j--)
                {
                    if ((crc & 1) == 1)
                    {
                        crc = (crc >> 1) ^ polynomial;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
                crcTable[i] = crc;
            }

            uint crc32 = 0xffffffff;
            byte[] bytes = Encoding.UTF8.GetBytes(input);

            foreach (byte b in bytes)
            {
                byte tableIndex = (byte)(((crc32) & 0xff) ^ b);
                crc32 = ((crc32 >> 8) & 0xffffff) ^ crcTable[tableIndex];
            }

            return ~crc32; 
        }

        public bool VerificarIntegridad()
        {
            DVHCalculado = 0;
            DVVCalculado = 0;

            foreach (var tabla in tablas)
            {
                long DVHTabla = GenerarDVH(tabla);
                long DVVTabla = GenerarDVV(tabla);

                DVHCalculado += DVHTabla;
                DVVCalculado += DVVTabla;
            }
            
            var DVActual = mpDV.ObtenerDV(); 
            long DVHAlmacenado = DVActual.DVH;
            long DVVAlmacenado = DVActual.DVV;

            bool longegridadDVH = DVHCalculado == DVHAlmacenado;
            bool longegridadDVV = DVVCalculado == DVVAlmacenado;

            if (!longegridadDVH || !longegridadDVV)
            {
                return false;
            }

            return true;
        }

        public void ActualizarDV()
        {
            mpDV.ActualizarDV(DVHCalculado, DVVCalculado);
        }

    }

}

