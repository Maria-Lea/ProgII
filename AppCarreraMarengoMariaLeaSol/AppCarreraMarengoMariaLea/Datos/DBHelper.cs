using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AppCarreraMarengoMariaLea.Datos
{
    internal class DBHelper
    {
        private SqlConnection conexion;
        private string cadenaConexion = "Data Source=DESKTOP-KQDVDBG\\MYSQLSERVER19;Initial Catalog=Carrera1;Integrated Security=True";


        public DBHelper()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public int ProximaCarrera()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "Sp_ProximaCarrera";
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();

            return (int)parametro.Value;
        }

        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());
            conexion.Close();
            return dt;
        }

        public bool ConfirmarCarrera(Carrera carrera)
        {
            bool resultado = true;
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";

                comando.Parameters.AddWithValue("@nom_carrera", "HELPER");

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_carrera";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;

                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();

                int idCarrera = (int)parametro.Value;

                SqlCommand cmdDetalle;
                foreach (DetalleCarrera dc in carrera.ListaDetalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@id_carrera", idCarrera);
                    cmdDetalle.Parameters.AddWithValue("@año_cursado", dc.AñoCursado);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", dc.Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@id_asignatura", dc.Asignatura.IdAsignatura);

                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch
            {
                t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }





    }
}
