using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BE;
using Newtonsoft.Json;

namespace Services
{
    public class IdiomaManager
    {
        private static IdiomaManager _instance;
        private readonly List<IIdiomaObserver> _observers = new List<IIdiomaObserver>();
        private Idioma _idiomaActual;
        public static Dictionary<string, string> Etiquetas { get; private set; }

        private ResourceManager _resourceManager;
        private CultureInfo _currentCulture;

        public static IdiomaManager Instance => _instance ?? (_instance = new IdiomaManager());

        private IdiomaManager()
        {
            _currentCulture = CultureInfo.CurrentUICulture;
            string relativePath = @"..\..\..\Services\Resources\etiquetas-es.json";
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.GetFullPath(Path.Combine(basePath, relativePath));
            Etiquetas = CargarEtiquetas(filePath);
        }

        public void Inicializar(Usuario usuario)
        {
            _idiomaActual = usuario.Idioma;
            NotificarObservadores();
            string relativePath = "";
            
            switch (_idiomaActual)
            {
                case Idioma.Spanish:
                    relativePath = @"..\..\..\Services\Resources\etiquetas-es.json";
                    _currentCulture = new CultureInfo("es");
                    break;
                case Idioma.English:
                    relativePath = @"..\..\..\Services\Resources\etiquetas-en.json";
                    _currentCulture = new CultureInfo("en");
                    break;
            }
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.GetFullPath(Path.Combine(basePath, relativePath));
            Etiquetas = CargarEtiquetas(filePath);
        }

        public Idioma IdiomaActual
        {
            get => _idiomaActual;
            set
            {
                _idiomaActual = value;
                string relativePath = "";

                switch (_idiomaActual)
                {
                    case Idioma.Spanish:
                        relativePath = @"..\..\..\Services\Resources\etiquetas-es.json";
                        _currentCulture = new CultureInfo("es");
                        break;
                    case Idioma.English:
                        relativePath = @"..\..\..\Services\Resources\etiquetas-en.json";
                        _currentCulture = new CultureInfo("en");
                        break;
                }
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.GetFullPath(Path.Combine(basePath, relativePath));
                Etiquetas = CargarEtiquetas(filePath);
                NotificarObservadores();
            }
        }

        public void Suscribir(IIdiomaObserver observer)
        {
            _observers.Add(observer);
        }

        public CultureInfo CurrentCulture
        {
            get { return _currentCulture; }
            set
            {
                _currentCulture = value;
                Thread.CurrentThread.CurrentUICulture = value;
            }
        }

        private void NotificarObservadores()
        {
            foreach (var observer in _observers)
            {
                observer.ActualizarIdioma(_idiomaActual);
            }
        }

        public string ObtenerMensaje(string clave)
        {
            //return Services.Resources.Resource1.ResourceManager.GetString(clave, _currentCulture);
            if (Etiquetas.TryGetValue(clave, out string mensaje))
            {
                return mensaje;
            }
            return "";
        }

        private static Dictionary<string, string> CargarEtiquetas(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"El archivo no se encontró: {filePath}");
                }

                string jsonContent = File.ReadAllText(filePath);
                Dictionary<string, string> etiquetas = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

                if (etiquetas == null)
                {
                    throw new Exception("La deserialización del archivo JSON falló.");
                }

                return etiquetas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar etiquetas: {ex.Message}");
                return new Dictionary<string, string>();
            }
        }
    }
}
