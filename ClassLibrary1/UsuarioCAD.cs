using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class UsuarioCAD
    {
        private ConexionCAD objConexionCAD;
        //private SqlDataReader nuevaTabla;
        private SqlCommand comando;
        private DataTable miTabla;
        private int aux;


        public UsuarioCAD()
        {
            objConexionCAD = new ConexionCAD();
            comando = new SqlCommand();
            miTabla = new DataTable();
        }

       public int validarUsuario(int idusuario, string contraseña)
        {
            int bandera = 0;
            comando.Connection = objConexionCAD.abrirConnecion();
            comando.CommandText = "validarUsuario4";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idUsuario", idusuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
           // nuevaTabla = comando.ExecuteReader();
            aux = comando.ExecuteNonQuery();
            Console.WriteLine(aux);

            if (aux == 1)
            {
                bandera = 1;
            }

            //nuevaTabla.Close();

            objConexionCAD.cerrarConexion();
            return bandera;
        }

       




    }

}