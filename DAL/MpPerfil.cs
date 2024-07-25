using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpPerfil
    {
        Acceso acceso = new Acceso();
        public int CrearFamilia(Familia familia)
        {
            try
            {
                acceso.comenzarTransaccion();

                int familiaId = ObtenerOInsertarPerfil(familia, true);

                List<int> nuevasRelaciones = familia.ObtenerSubFamilias().Select(f => f.ID).ToList();

                EliminarRelacionesFamilia(familiaId, nuevasRelaciones);

                GuardarRelacionesFamilia(familia, familiaId, true);

                acceso.confirmarTransaccion();
                return familiaId;
            }
            catch (Exception)
            {
                acceso.revertirTransaccion();
                throw;
            }
        }

        public List<int> ObtenerRelacionesFamilia(int familiaId)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@FamiliaID", familiaId)
            };

            DataTable dt = acceso.leer(queries.PerfilQuery.ObtenerRelaciones, parametros);
            return dt.AsEnumerable().Select(row => Convert.ToInt32(row["RelacionadoID"])).ToList();
        }

        private void GuardarRelacionesFamilia(Familia familia, int familiaId, bool esRaiz)
        {
            foreach (var perfil in familia.ObtenerSubFamilias())
            {
                int perfilId = ObtenerOInsertarPerfil(perfil, false);

                if (esRaiz || perfil.EsFamilia)
                {
                    VerificarYGuardarRelacion(familiaId, perfilId);
                }

                if (perfil.EsFamilia)
                {
                    GuardarRelacionesFamilia((Familia)perfil, perfilId, false);
                }
            }
        }

        private void VerificarYGuardarRelacion(int familiaId, int perfilId)
        {
            SqlParameter[] parametrosRelacion = new SqlParameter[]
            {
                new SqlParameter("@PerfilID", familiaId),
                new SqlParameter("@RelacionadoID", perfilId)
            };

            DataTable resultado = acceso.leer(queries.PerfilQuery.VerificarExistenciaRelacion, parametrosRelacion);

            int count = resultado.Rows.Count > 0 ? Convert.ToInt32(resultado.Rows[0][0]) : 0;

            if (count == 0)
            {
                SqlParameter[] otrosParametros = new SqlParameter[]
                {
                    new SqlParameter("@PerfilID", familiaId),
                    new SqlParameter("@RelacionadoID", perfilId)
                };
                acceso.escribir(queries.PerfilQuery.InsertarRelacion, otrosParametros);
            }
        }

        private int ObtenerOInsertarPerfil(Perfil perfil, bool esFamilia)
        {
            SqlParameter[] parametrosObtenerPerfil = new SqlParameter[]
            {
            new SqlParameter("@Nombre", perfil.Nombre)
            };

            DataTable resultado = acceso.leer(queries.PerfilQuery.ObtenerPerfilPorNombre, parametrosObtenerPerfil);

            if (resultado.Rows.Count > 0)
            {
                perfil.ID = Convert.ToInt32(resultado.Rows[0]["ID"]);

                if (esFamilia)
                {
                    ActualizarPerfil(perfil);
                }
                return perfil.ID;
            }
            return InsertarPerfil(perfil);
        }

        private void ActualizarPerfil(Perfil perfil)
        {
            SqlParameter[] parametrosActualizarPerfil = new SqlParameter[]
            {
                new SqlParameter("@Nombre", perfil.Nombre),
                new SqlParameter("@ID", perfil.ID)
            };
            acceso.escribir(queries.PerfilQuery.ActualizarPerfil, parametrosActualizarPerfil);
        }

        private int InsertarPerfil(Perfil perfil)
        {
            if (perfil.Tipo == "Perfil")
            {

            }else if (perfil.Tipo == null)
            {
                perfil.Tipo = perfil.EsFamilia ? "Familia" : "Patente";
            }

            SqlParameter[] parametrosInsertarPerfil = new SqlParameter[]
            {
                new SqlParameter("@Nombre", perfil.Nombre),

                new SqlParameter("@Tipo", perfil.Tipo)
            };

            return Convert.ToInt32(acceso.leer(queries.PerfilQuery.InsertarPerfil, parametrosInsertarPerfil).Rows[0][0]);
        }

        private void EliminarRelacionesFamilia(int familiaId, List<int> nuevasRelaciones)
        {
            List<int> relacionesActuales = ObtenerRelacionesFamilia(familiaId);
            List<int> relacionesAEliminar = relacionesActuales.Except(nuevasRelaciones).ToList();

            foreach (int relacionId in relacionesAEliminar)
            {
                EliminarRelacionEspecifica(familiaId, relacionId);
            }
        }

        private void EliminarRelacionEspecifica(int familiaId, int relacionadoId)
        {
            SqlParameter[] parametrosEliminarRelaciones = new SqlParameter[]
            {
                new SqlParameter("@FamiliaID", familiaId),
                new SqlParameter("@RelacionadoID", relacionadoId)
            };
            acceso.escribir(queries.PerfilQuery.EliminarRelacionEspecifica, parametrosEliminarRelaciones);
        }

        public List<Familia> ObtenerTodasLasFamilias()
        {
            List<Familia> familias = new List<Familia>();
            DataTable resultado = acceso.leer(queries.PerfilQuery.ObtenerTodasFamilias, null);

            Dictionary<int, Familia> familiasPorID = new Dictionary<int, Familia>();

            foreach (DataRow row in resultado.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string nombre = row["Nombre"].ToString();
                string tipo = row["Tipo"].ToString();

                if (tipo == "Familia" && !familiasPorID.ContainsKey(id))
                {
                    Familia familia = new Familia(nombre);
                    familia.ID = id;
                    familiasPorID[id] = familia;
                }
            }

            foreach (DataRow row in resultado.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string nombre = row["Nombre"].ToString();
                string tipo = row["Tipo"].ToString();
                int? parentId = row["ParentID"] as int?;

                if (parentId.HasValue && familiasPorID.ContainsKey(parentId.Value))
                {
                    Familia parentFamilia = familiasPorID[parentId.Value];

                    if (tipo == "Patente")
                    {
                        Patente patente = new Patente(nombre);
                        parentFamilia.Agregar(patente);
                    }
                    else if (tipo == "Familia" && familiasPorID.ContainsKey(id))
                    {
                        Familia childFamilia = familiasPorID[id];
                        parentFamilia.Agregar(childFamilia);
                    }
                }
            }

            familias.AddRange(familiasPorID.Values);

            return familias;
        }

        public List<Perfil> ObtenerTodosPerfiles()
        {
            List<Perfil> perfiles = new List<Perfil>();
            DataTable resultado = acceso.leer(queries.PerfilQuery.ObtenerTodosPerfilesConRelaciones, null);

            Dictionary<int, Familia> perfilesPorID = new Dictionary<int, Familia>();

            foreach (DataRow row in resultado.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string nombre = row["Nombre"].ToString();
                string tipo = row["Tipo"].ToString();

                if ((tipo == "Perfil" || tipo == "Familia") && !perfilesPorID.ContainsKey(id))
                {
                    Familia perfil = new Familia(nombre) { Tipo = tipo };
                    perfil.ID = id;
                    perfilesPorID[id] = perfil;
                }
            }

            foreach (DataRow row in resultado.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                int? parentId = row["ParentID"] as int?;
                string tipo = row["Tipo"].ToString();
                string nombre = row["Nombre"].ToString();

                if (parentId.HasValue && perfilesPorID.ContainsKey(parentId.Value))
                {
                    Familia parentPerfil = perfilesPorID[parentId.Value];

                    if (tipo == "Patente")
                    {
                        Patente patente = new Patente(nombre);
                        parentPerfil.Agregar(patente);
                    }
                    else if ((tipo == "Familia" || tipo == "Perfil") && perfilesPorID.ContainsKey(id))
                    {
                        Familia childFamilia = perfilesPorID[id];
                        parentPerfil.Agregar(childFamilia);
                    }
                }
            }

            perfiles.AddRange(perfilesPorID.Values);

            return perfiles.Where(p => p.Tipo == "Perfil").ToList();
        }

        public void CrearPerfil(Familia familia)
        {
            try
            {
                acceso.comenzarTransaccion();

                int familiaId = ObtenerOInsertarPerfil(familia, true);

                List<int> nuevasRelaciones = familia.ObtenerSubFamilias().Select(f => f.ID).ToList();

                EliminarRelacionesFamilia(familiaId, nuevasRelaciones);

                GuardarRelacionesFamilia(familia, familiaId, true);

                acceso.confirmarTransaccion();
            }
            catch (Exception)
            {
                acceso.revertirTransaccion();
                throw;
            }
        }

        public void eliminarFamilia(int familiaId)
        {
            try
            {
                acceso.comenzarTransaccion();

                EliminarRelacionesFamilia(familiaId);
                EliminarFamiliaPorId(familiaId);

                acceso.confirmarTransaccion();
            }
            catch (Exception)
            {
                acceso.revertirTransaccion();
                throw;
            }
        }

        private void EliminarRelacionesFamilia(int familiaId)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@FamiliaID", familiaId)
            };
            acceso.escribir(queries.PerfilQuery.EliminarRelacionesPorFamilia, parametros);
        }

        private void EliminarFamiliaPorId(int familiaId)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@FamiliaID", familiaId)

            };
            acceso.escribir(queries.PerfilQuery.EliminarFamiliaId, parametros);
        }

        public void eliminarPerfil(int id)
        {
            try
            {
                acceso.comenzarTransaccion();

                EliminarRelacionesFamilia(id);
                EliminarPerfilPorId(id);

                acceso.confirmarTransaccion();
            }
            catch (Exception)
            {
                acceso.revertirTransaccion();
                throw;
            }
        }

        private void EliminarPerfilPorId(int familiaId)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@FamiliaID", familiaId)

            };
            acceso.escribir(queries.PerfilQuery.EliminarPerfilId, parametros);
        }
    }
}
