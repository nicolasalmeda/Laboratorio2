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
    public partial class Entradas : Form
    {

        private EntradasCLN objEntradasCLN;
        private int id, indice;
        private DataTable miTabla;
        private object valorUltId;


        public Entradas()
        {
            InitializeComponent();
            objEntradasCLN = new EntradasCLN();
            id = 0;
            indice = 0;
            miTabla = new DataTable();
            valorUltId = new object();
        }


        public void cargarDataGridView()
        {
            miTabla.Clear();
            miTabla = objEntradasCLN.consultarEntradas();
            dvgEntradas.DataSource = miTabla;
        }

        private void Entradas_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            int cantFilas = dvgEntradas.Rows.Count;
            int posicionUltFila = objEntradasCLN.getPosicionUltFila(cantFilas);

            valorUltId = dvgEntradas.Rows[posicionUltFila].Cells[0].Value;

            limpiarTextBox();
            btnEditar.Visible = false;
            btnElimiinar.Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        
            objEntradasCLN.agregarEntradas(valorUltId, txtPrecio.Text, txtStock.Text, txtIdSector.Text, txtIdPartido.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            objEntradasCLN.actualizarEntrada(id, txtPrecio.Text, txtStock.Text);
            cargarDataGridView();
            limpiarTextBox();
            btnEditar.Visible = false;
            MessageBox.Show("Se edito el registro");
        }

        private void btnElimiinar_Click(object sender, EventArgs e)
        {
            objEntradasCLN.eliminarEntrada(id);
            cargarDataGridView();
            limpiarTextBox();
            
            
        }

        private void dvgEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            valorUltId = dvgEntradas.Rows[indice].Cells[0].Value;

            id = Convert.ToInt32(dvgEntradas.Rows[indice].Cells[0].Value);
            txtIdEntrada.Text = dvgEntradas.Rows[indice].Cells[0].Value.ToString();
            txtPrecio.Text = dvgEntradas.Rows[indice].Cells[1].Value.ToString();
            txtStock.Text = dvgEntradas.Rows[indice].Cells[2].Value.ToString();
            txtIdSector.Text = dvgEntradas.Rows[indice].Cells[3].Value.ToString();

        }

        public void limpiarTextBox()
        {
            txtIdEntrada.Clear();
            txtIdPartido.Clear();
            txtIdSector.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

    }
}
