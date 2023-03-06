using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
  public  class PedidosCLN
    {
        private DataTable miTabla;
        private PedidosCAD objPedidosCAD;
        private object valorUltId;

        public PedidosCLN()
        {
            miTabla = new DataTable();
            objPedidosCAD = new PedidosCAD();
            valorUltId = new object();
        }

        public DataTable consultarPedidos()
        {
            miTabla = objPedidosCAD.consultarPedidos();
            return miTabla;
        }

        public void agregarPedidos(object valorUltId, string total, string idcliente, string identrada, string cant)
        {
            int id = Convert.ToInt32(valorUltId) + 1;
            float totalE = Convert.ToSingle(total) * Convert.ToInt32(cant);
            Console.WriteLine(totalE);
            int idclienteE = Convert.ToInt32(idcliente);
            int identradaE = Convert.ToInt32(identrada);
            int cantE= Convert.ToInt32(cant);
            

            objPedidosCAD.agregarPedidos(id, totalE, idclienteE, identradaE, cantE);
        }

        public void eliminarPedido(int idpedido)
        {
            objPedidosCAD.eliminiarPedido(idpedido);
        }

        public void actualizarPedido(int idpedido, string total, string idcliente, string identrada, string cant)
        {

            float totalE = Convert.ToSingle(total);
            int idclienteE = Convert.ToInt32(idcliente);
            int identradaE = Convert.ToInt32(identrada);
            int cantE = Convert.ToInt32(cant);
            objPedidosCAD.actualizarPedido(idpedido, totalE, idclienteE, identradaE, cantE);
        }

        public int getPosicionUltFilaPedidos(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }
    }
}
