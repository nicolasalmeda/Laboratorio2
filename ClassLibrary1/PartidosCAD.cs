using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{

    public class PartidosCAD
    {
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public PartidosCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarPartidos()
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "consultarTodoPartidos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }

        public void agregarPartidos(int idpartido, DateTime fecha, string torneo)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "agregarPartidos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idpartido", idpartido);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@torneo", torneo);
            
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarPartidos(int idpartido, string partido, DateTime fecha)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "actualizarPartidos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idpartido", idpartido);
            comando.Parameters.AddWithValue("@partido", partido);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminiarPartido(int idpartido)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "eliminarPartidos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idpartido", idpartido);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

    }
}
