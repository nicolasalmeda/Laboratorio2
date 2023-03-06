using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Sectores : Form
    {

        private SectoresCLN objSectoresCLN;
        private int id, indice;
        private DataTable miTabla;
        private object valorUltId;

        public Sectores()
        {
            InitializeComponent();
            objSectoresCLN = new SectoresCLN();
            id = 0;
            indice = 0;
            miTabla = new DataTable();
            valorUltId = new object();
        }

        public void cargarDataGridView()
        {
            miTabla.Clear();
            miTabla = objSectoresCLN.consultarSector();
            dgvSectores.DataSource = miTabla;
        }

        private void Sectores_Load(object sender, EventArgs e)
        {
            cargarDataGridView();

            int cantFilas = dgvSectores.Rows.Count;
            int posicionUltFila = objSectoresCLN.getPosicionUltFilaSectores(cantFilas);

            valorUltId = dgvSectores.Rows[posicionUltFila - 1].Cells[0].Value;

            limpiarTextBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objSectoresCLN.eliminarSector(id);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se borró el registro");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objSectoresCLN.agregarSectores(valorUltId, txtSector.Text);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se agrego el registro");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            objSectoresCLN.actualizarSectores(id, txtSector.Text);
            cargarDataGridView();
            limpiarTextBox();

            MessageBox.Show("Se edito el registro");
        }

        private void dgvSectores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indice = e.RowIndex;
           // valorUltId = dgvSectores.Rows[indice].Cells[0].Value;

            id = Convert.ToInt32(dgvSectores.Rows[indice].Cells[0].Value);
            txtIdSector.Text = dgvSectores.Rows[indice].Cells[0].Value.ToString();
            txtSector.Text = dgvSectores.Rows[indice].Cells[1].Value.ToString();
            

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            Hide();
        }

        public void limpiarTextBox()
        {
            txtIdSector.Clear();
            txtSector.Clear();
            


        }









    }
}
