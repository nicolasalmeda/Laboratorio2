using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class SectoresCLN
    {
        private DataTable miTabla;
        private SectoresCAD objSectoresCAD;
        private object valorUltId;


        public SectoresCLN()
        {
            miTabla = new DataTable();
            objSectoresCAD = new SectoresCAD();
            valorUltId = new object();
        }

        public DataTable consultarSector()
        {
            miTabla = objSectoresCAD.consultarSector();
            return miTabla;
        }

        public void agregarSectores(object valorUltId, string sector)
        {
            int id = Convert.ToInt32(valorUltId) + 1;
            objSectoresCAD.agregarSectores(id, sector);
        }

        public void eliminarSector(int idsector)
        {
            objSectoresCAD.eliminarSectores(idsector);
        }

        public void actualizarSectores(int idsector,string sector)
        {
            objSectoresCAD.actualizarSectores(idsector, sector);
        }

        public int getPosicionUltFilaSectores(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }


    }
}
