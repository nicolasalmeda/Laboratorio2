using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaAccesoDatos
{
   public class SectoresCAD
    {
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public SectoresCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarSector()
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "consultarTodoSectores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }

        public void agregarSectores(int idsector, string sector)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "agregarSector";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idsector", idsector);
            comando.Parameters.AddWithValue("@sector", sector);
            

            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarSectores(int idsector, string sector)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "actualizarSectoreS";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idsector", idsector);
            comando.Parameters.AddWithValue("@sector", sector);


            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminarSectores(int idsectores)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "eliminarSectores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idsectores", idsectores);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
    }
}
