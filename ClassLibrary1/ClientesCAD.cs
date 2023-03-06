using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ClientesCAD
    {

        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public ClientesCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }

        public DataTable consultarClientes()
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "ConsultarTodoCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;

        }

        public void agregarClientes(int idcliente,  string nombre, string apellido, string contraseña)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "agregarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@contraseña", contraseña);

            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarCliente(int idcliente, string nombre, string apellido, string contraseña)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "actualizarNombre";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminiarCliente(int idcliente)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "eliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }




    }
}
