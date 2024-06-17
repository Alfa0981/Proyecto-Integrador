using BE;
using Services;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {

        MpUsuario mpUsuario = new MpUsuario();
        int contador = 0;

        public bool login (BE.Usuario usuarioALoguear)
        {
            
            usuarioALoguear.Pass = UserEncryption.HashSHA256(usuarioALoguear.Pass);
            BE.Usuario usuarioCargado = mpUsuario.buscarPorUsername(usuarioALoguear.User);

            if (contador > 3)
            {
                bloquearUsuario(usuarioCargado);
                contador = 0;
                throw new Exception(IdiomaManager.Instance.ObtenerMensaje("BlockingUser"));
            }
            else if (validarUsuario(usuarioALoguear, usuarioCargado))
            {
                SessionManager.Login(usuarioCargado);
                return validarPrimerLogin(usuarioCargado);
            }
            else
            {
                contador++;
                throw new Exception(IdiomaManager.Instance.ObtenerMensaje("CredencialesInvalidas"));
            }
        }

        private void bloquearUsuario(BE.Usuario usuarioCargado)
        {
            usuarioCargado.Bloqueo = true;
            mpUsuario.modificarUsuario(usuarioCargado);
        }

        public void desbloquearUsuario(BE.Usuario usuarioCargado)
        {
            usuarioCargado.Bloqueo = false;
            mpUsuario.modificarUsuario(usuarioCargado);
        }

        private bool validarPrimerLogin(BE.Usuario usuarioCargado)
        {
            string contraDefault = UserEncryption.HashSHA256(usuarioCargado.Dni + usuarioCargado.Apellido);

            return contraDefault == usuarioCargado.Pass;
        }

        public void cambiarContra (BE.Usuario usuario, string nuevaContra)
        {
            usuario.Pass = UserEncryption.HashSHA256(nuevaContra);
            mpUsuario.modificarUsuario (usuario);
        }

        public void logout()
        {
            SessionManager.Logout();
        }

        public void cargarUsuario(BE.Usuario usuarioACargar)
        {
            usuarioACargar.Pass = UserEncryption.HashSHA256(usuarioACargar.Pass);
            BE.Usuario usuario = mpUsuario.buscarPorUsername(usuarioACargar.User);
            if (usuario != null)
            {
                throw new Exception(IdiomaManager.Instance.ObtenerMensaje("UsuarioExisteException"));
            }
            usuario = mpUsuario.buscarPorDni(usuarioACargar.Dni);
            if (usuario != null)
            {
                throw new Exception(IdiomaManager.Instance.ObtenerMensaje("UsuarioExisteException"));
            }
            mpUsuario.crear(usuario);
        }

        public List<BE.Usuario> mostrarTodos ()
        {
            return mpUsuario.buscarTodos();
        }

        public List<BE.Rol> mostrarTodosRoles()
        {
            return mpUsuario.buscarTodosRoles();
        }

        private bool validarUsuario (BE.Usuario usuarioALoguear, BE.Usuario usuarioCargado)
        {
            if (usuarioCargado.Bloqueo)
                throw new Exception(IdiomaManager.Instance.ObtenerMensaje("UserIsBlocked"));
            else if (!usuarioCargado.Activo)
                throw new Exception(IdiomaManager.Instance.ObtenerMensaje("UserIsNotActive"));
            else if (usuarioCargado.Pass == usuarioALoguear.Pass)
                return true;
            else
                return false;
        }

        public void eliminar (BE.Usuario usuario)
        {
            usuario.Activo = false;
            mpUsuario.modificarUsuario(usuario);
        }

        public void cambiarIdioma (BE.Usuario usuario, Idioma idioma)
        {
            usuario.Idioma = idioma;
            mpUsuario.modificarUsuario(usuario);
        }

        public void modificarUsuario (BE.Usuario usuario)
        {
            mpUsuario.modificarUsuario(usuario);
        }

    }
}
