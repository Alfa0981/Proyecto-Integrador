﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Services
{
    public class IdiomaManager
    {
        private static IdiomaManager _instance;
        private readonly List<IIdiomaObserver> _observers = new List<IIdiomaObserver>();
        private Idioma _idiomaActual;

        private ResourceManager _resourceManager;
        private CultureInfo _currentCulture;

        public static IdiomaManager Instance => _instance ?? (_instance = new IdiomaManager());

        private IdiomaManager()
        {
            _resourceManager = new ResourceManager("MyProject.Properties.Messages", typeof(IdiomaManager).Assembly);
        }

        public void Inicializar(Usuario usuario)
        {
            _idiomaActual = usuario.Idioma;
            NotificarObservadores();
            switch (_idiomaActual)
            {
                case Idioma.Spanish:
                    _currentCulture = new CultureInfo("es");
                    break;
                case Idioma.English:
                    _currentCulture = new CultureInfo("en");
                    break;
            }
        }

        public Idioma IdiomaActual
        {
            get => _idiomaActual;
            set
            {
                _idiomaActual = value;
                NotificarObservadores();
            }
        }

        public void Suscribir(IIdiomaObserver observer)
        {
            _observers.Add(observer);
        }

        public void Desuscribir(IIdiomaObserver observer)
        {
            _observers.Remove(observer);
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
            return _resourceManager.GetString(clave, _currentCulture);
        }
    }
}