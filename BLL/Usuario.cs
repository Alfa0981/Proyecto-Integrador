﻿using BE;
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
        BLL.Perfil gestorPerfil = new BLL.Perfil();
        BLL.GestionEventos gestionEventos = new BLL.GestionEventos();
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
                List<BE.Perfil> perfiles = gestorPerfil.obtenerTodosPerfiles();
                BE.Perfil perfilUsuario = perfiles.FirstOrDefault(p => p.ID == usuarioCargado.Perfil.ID);

                if (perfilUsuario != null)
                {
                    usuarioCargado.Perfil = perfilUsuario;
                }

                SessionManager.Login(usuarioCargado);
                gestionEventos.persistirEvento("Login", BE.Modulos.Users.ToString(), 3);

                if (!DV.Instance.VerificarIntegridad())
                {
                    throw new IntegrityException();
                }
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
            DV.Instance.Generar();
        }

        public void desbloquearUsuario(BE.Usuario usuarioCargado)
        {
            usuarioCargado.Bloqueo = false;
            string contraReseteada = usuarioCargado.Dni + usuarioCargado.Apellido;
            usuarioCargado.Pass = UserEncryption.HashSHA256(contraReseteada);
            mpUsuario.modificarUsuario(usuarioCargado);
            DV.Instance.Generar();
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
            DV.Instance.Generar();
        }

        public void logout()
        {
            gestionEventos.persistirEvento("Logout", BE.Modulos.Users.ToString(), 3);
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
            mpUsuario.crear(usuarioACargar);
            gestionEventos.persistirEvento("Nuevo usuario creado", BE.Modulos.Users.ToString(), 2);
            DV.Instance.Generar();
        }

        public List<BE.Usuario> mostrarTodos ()
        {
            List<BE.Perfil> perfiles = gestorPerfil.obtenerTodosPerfiles();
            List<BE.Usuario> usuarios = mpUsuario.buscarTodos();

            foreach (var usuario in usuarios)
            {
                BE.Perfil perfilUsuario = perfiles.FirstOrDefault(p => p.ID == usuario.Perfil.ID);

                if (perfilUsuario != null)
                {
                    usuario.Perfil = perfilUsuario;
                }
            }

            return usuarios;
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
            DV.Instance.Generar();
        }

        public void cambiarIdioma (BE.Usuario usuario, Idioma idioma)
        {
            usuario.Idioma = idioma;
            mpUsuario.modificarUsuario(usuario);
            DV.Instance.Generar();
        }

        public void modificarUsuario (BE.Usuario usuario)
        {
            mpUsuario.modificarUsuario(usuario);
            DV.Instance.Generar();
        }

    }
}
