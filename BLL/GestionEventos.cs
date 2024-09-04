using BE;
using DAL;
using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestionEventos
    {
        MpEvento mpEvento = new MpEvento();

        public void persistirEvento (string tipoEvento, string modulo, int criticidad)
        {
            Evento evento = new Evento()
            {
                Criticidad = criticidad,
                Descripcion = tipoEvento,
                Modulo = modulo,
                Usuario = SessionManager.GetInstance.Usuario,
                Fecha = DateTime.Now.Date, 
                Hora = DateTime.Now.TimeOfDay,
            };
            mpEvento.persitirEvento(evento);
        }

        public List<Evento> obtenerEventos()
        {
            return mpEvento.obtenerTodos();
        }

        public string[] obtenerDescsEventos()
        {
            string rutaArchivo = @"C:\Users\tomas\OneDrive - UNIVERSIDAD ABIERTA INTERAMERICANA\Compu vieja\Facu\Tercer año\Ing Software\Proyecto-Integrador-git\Services\Resources\descripciones-eventos.json";
            string json = File.ReadAllText(rutaArchivo);

            Dictionary<string, string> descripcionesEventos = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            return descripcionesEventos.Values.ToArray();
        }
    }
}
