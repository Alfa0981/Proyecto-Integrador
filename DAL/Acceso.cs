using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {
        private SqlConnection conn;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public void conectar()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.;Initial Catalog=ProyectoIntegrador;Integrated Security=True";
            conn.Open();
        }

        public void desconectar()
        {
            conn.Close();
            conn.Dispose();
        }

        public void escribir(string query, SqlParameter[] sqlParameters)
        {

            conectar();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddRange(sqlParameters);

            SqlTransaction sqlTransaction = conn.BeginTransaction();

            try
            {
                cmd.Transaction = sqlTransaction;
                cmd.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            catch (Exception e)
            {
                sqlTransaction.Rollback();
                throw new Exception("Error al escribir en la base de datos: " + e.GetBaseException());

            }
            finally {
                desconectar();
            }

        }


        public DataTable leer(string query, SqlParameter[] sqlParameters)
        {
            conectar();


            DataTable tabla = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand();
            sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;
            sqlDataAdapter.SelectCommand.CommandText = query;

            if (sqlParameters != null)
                sqlDataAdapter.SelectCommand.Parameters.AddRange(sqlParameters);

            sqlDataAdapter.SelectCommand.Connection = conn;

            sqlDataAdapter.Fill(tabla);
            desconectar();

            return tabla;

        }
    }
}
