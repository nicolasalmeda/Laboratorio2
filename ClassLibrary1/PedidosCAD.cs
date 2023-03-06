using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class PedidosCAD
    {
        private ConexionCAD objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;

        public PedidosCAD()
        {
            objConexionCAD = new ConexionCAD();
            miTabla = new DataTable();
            comando = new SqlCommand();

        }


        public DataTable consultarPedidos()
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "consultarTodoPedidos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            leerTabla = comando.ExecuteReader();
            miTabla.Load(leerTabla);

            objConexionCAD.cerrarConexion();
            return miTabla;
        }

        public void agregarPedidos(int idpedido, float total, int idcliente, int identrada, int cant)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "agregarPedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idpedido", idpedido);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.Parameters.AddWithValue("@identrada", identrada);
            comando.Parameters.AddWithValue("@cant", cant);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void actualizarPedido(int idPedido, float total, int idcliente, int identrada, int cant)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "actualizarPedidos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idPedido", idPedido);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.Parameters.AddWithValue("@identrada", identrada);
            comando.Parameters.AddWithValue("@cant", cant);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

        public void eliminiarPedido(int idpedido)
        {
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "eliminarpedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idpedido", idpedido);
            comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }

    }
}
