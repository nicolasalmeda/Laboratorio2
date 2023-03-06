using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;

namespace CapaLogicaNegocio
{
   public class ClientesCLN
    {
        private ClientesCAD objClientesCAD;
        private DataTable miTabla;
        private object valorUltId;


        public ClientesCLN()
        {
            objClientesCAD = new ClientesCAD();
            miTabla = new DataTable();
            valorUltId = new object();
        }


        public DataTable consultarClientes()
        {
            miTabla = objClientesCAD.consultarClientes();
            return miTabla;
        }


        public void agregarClientes(object valorUltId, string nombre, string apellido, string contraseña)
        {
            int id = Convert.ToInt32(valorUltId) + 1;
            objClientesCAD.agregarClientes(id, nombre, apellido, contraseña);
        }

        public void eliminarCliente(int idcliente)
        {
            objClientesCAD.eliminiarCliente(idcliente);
        }

        public void actualizarCliente(int idcliente, string nombre, string apellido, string contraseña)
        {

            objClientesCAD.actualizarCliente(idcliente, nombre, apellido, contraseña);

        }

        public int getPosicionUltFilaClientes(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }
    }


}
