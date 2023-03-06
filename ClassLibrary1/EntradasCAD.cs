using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class EntradasCAD
    {
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public EntradasCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public void agregarEntradas(int identrada, float precio, int stock, int idsector, int idpartido)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "agregarEntradas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@identrada", identrada);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@idsector", idsector);
            comando.Parameters.AddWithValue("@idpartido", idpartido);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarEntradas(int identrada, float precio, int stock)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "actualizarEntradas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@identrada", identrada);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminiarEntrada(int identrada)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "eliminarEntrada";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@identrada", identrada);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public DataTable consultarEntradas()
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "consultarTodoEntrada";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }

        

        


    }
}
