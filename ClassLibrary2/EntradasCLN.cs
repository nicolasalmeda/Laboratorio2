using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CapaAccesoDatos;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaLogicaNegocio
{
   public class EntradasCLN
    {
        private DataTable miTabla;
        private EntradasCAD objEntradasCAD;
        private object valorUltId;

        public EntradasCLN()
        {
            miTabla = new DataTable();
            objEntradasCAD = new EntradasCAD();
            valorUltId = new object();

        }

        public DataTable consultarEntradas()
        {
            miTabla = objEntradasCAD.consultarEntradas();
            return miTabla;
        }

        

        

        /*public void agregarEntradas(int identrada,float precio,int stock,int idsector, int idpartido)
        {
            objEntradasCAD.agregarEntradas(identrada + 1, precio, stock, idsector, idpartido);
        }*/

        public void agregarEntradas(object valorUltId, string precio, string stock,string idsector, string idpartido)
        {
            int id = Convert.ToInt32(valorUltId) + 1;
            float precioE = Convert.ToSingle(precio);
            int stockE = Convert.ToInt32(stock);
            int idsectorE = Convert.ToInt32(idsector);
            int idpartidoE = Convert.ToInt32(idpartido);

            objEntradasCAD.agregarEntradas(id, precioE, stockE, idsectorE, idpartidoE);
        }

        public void eliminarEntrada(int identrada)
        {
            objEntradasCAD.eliminiarEntrada(identrada);
        }

        public void actualizarEntrada(int identrada, string precio,string stock)
        {
            float precioE = Convert.ToSingle(precio);
            int stockE = Convert.ToInt32(stock);
            objEntradasCAD.actualizarEntradas(identrada, precioE, stockE);
        }

        public int getPosicionUltFila(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }

    }
}
