using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaAccesoDatos
{
    public class ConexionCAD
    {
        private string cadena;
        private SqlConnection conectarDB;

        public ConexionCAD()
        {
            cadena = "Data Source=NICOLÁS\\SQL;Initial Catalog = ventasEntradas; User ID = sa; Password = colegioprivado ";
            conectarDB = new SqlConnection(cadena);
            conectarDB.ConnectionString = cadena;
        }
        ~ConexionCAD()
        {
            Console.WriteLine("Out...");
        }

        public void abrirConexion()
        {
            try
            {
                conectarDB.Open();
                MessageBox.Show("La conexion esta abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexion no se pudo abrir " + ex.Message);
                Console.WriteLine(ex);
            }
        }
        public SqlConnection abrirConnecion()
        {
            try
            {
                conectarDB.Open();
                return conectarDB;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return conectarDB;
            }


        }
        public void cerrarConexion()
        {
            conectarDB.Close();
        }

        public SqlConnection getConexion()
        {
            return conectarDB;
        }
    }
}
