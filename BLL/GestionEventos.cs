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
            if (SessionManager.GetInstance != null)
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
        }

        public List<Evento> obtenerEventos()
        {
            return mpEvento.obtenerTodos();
        }

        public List<DescEvento> obtenerDescsEventos()
        {
            string relativePath = @"..\..\..\Services\Resources\descripciones-eventos.json";
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string rutaArchivo = Path.GetFullPath(Path.Combine(basePath, relativePath));
            string json = File.ReadAllText(rutaArchivo);

            Dictionary<string, DescEvento> eventos = JsonConvert.DeserializeObject<Dictionary<string, DescEvento>>(json);

            return eventos.Values.ToList();
        }
    }
}
