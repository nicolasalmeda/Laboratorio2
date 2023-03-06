using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;
using System.Windows.Forms;

namespace CapaLogicaNegocio
{
    public class PartidosCLN
    {
        private DataTable miTabla;
        private PartidosCAD objPartidosCAD;
        private object valorUltId;

        public PartidosCLN()
        {
            miTabla = new DataTable();
            objPartidosCAD = new PartidosCAD();
            valorUltId = new object();
        }

        public DataTable consultarPartidos()
        {
            miTabla = objPartidosCAD.consultarPartidos();
            return miTabla;
        }

        public void agregarPartidos(object valorUltId, string fecha, string torneo)
        {
            if( valorUltId == null || fecha == "" || torneo == "")
            {
                MessageBox.Show("Debe completar los campos");
            }
            else
            {
            int id = Convert.ToInt32(valorUltId) + 1;
            DateTime fechaE = DateTime.Parse(fecha);
            objPartidosCAD.agregarPartidos(id, fechaE, torneo);

            }



        }

        public void eliminarPartido(int idpartido)
        {
            objPartidosCAD.eliminiarPartido(idpartido);
        }

        public void actualizarPartido(int idpartido, string partido, string fecha)
        {
            DateTime fechaE = DateTime.Parse(fecha);

            objPartidosCAD.actualizarPartidos(idpartido, partido, fechaE);
            
        }

        public int getPosicionUltFilaPartido(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }

    }
}
