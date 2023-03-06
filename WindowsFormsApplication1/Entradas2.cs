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
    public partial class Entradas2 : Form
    {

        private EntradasCLN objEntradasCLN;
        private PartidosCLN objPartidosCLN;
        private SectoresCLN objSectoresCLN;
        private int id, indice,indicePartidos, indiceSectores;
        private DataTable miTabla ,tablaPartidos,tablaSectores;
        private object valorUltId;

        public Entradas2()
        {
            InitializeComponent();
            objEntradasCLN = new EntradasCLN();
            objPartidosCLN = new PartidosCLN();
            objSectoresCLN = new SectoresCLN();
            indicePartidos = 0;
            indiceSectores = 0;
            id = 0;
            indice = 0;
            tablaPartidos = new DataTable();
            tablaSectores = new DataTable();
            miTabla = new DataTable();
            valorUltId = new object();
        }


        public void cargarDataGridView()
        {
            miTabla.Clear();
            miTabla = objEntradasCLN.consultarEntradas();
            dvgEntradas.DataSource = miTabla;
        }


        private void Entradas2_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            cargarComboPartidos();
            cargarComboSecotres();
            int cantFilas = dvgEntradas.Rows.Count;
            int posicionUltFila = objEntradasCLN.getPosicionUltFila(cantFilas);

            valorUltId = dvgEntradas.Rows[posicionUltFila - 1].Cells[0].Value;

            limpiarTextBox();
            
        }

        private void cboPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            indicePartidos = cboPartidos.SelectedIndex;
            Console.WriteLine(indicePartidos);
            lblFecha.Text = tablaPartidos.Rows[indicePartidos].ItemArray[1].ToString();
            lblTorneo.Text = tablaPartidos.Rows[indicePartidos].ItemArray[2].ToString();
            txtIdPartido.Text = cboPartidos.Text;
            
        }

        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceSectores = cboSector.SelectedIndex;
            Console.WriteLine(indiceSectores);
            lblSector.Text = tablaSectores.Rows[indiceSectores].ItemArray[1].ToString();
            txtIdSector.Text = cboSector.Text;
        }

        public void cargarComboPartidos()
        {
            tablaPartidos.Clear();
            tablaPartidos = objPartidosCLN.consultarPartidos();
            cboPartidos.ValueMember = "id_partido";
            cboPartidos.DisplayMember = "id_partido";
            cboPartidos.DataSource = tablaPartidos;
        }

        public void cargarComboSecotres()
        {
            tablaSectores.Clear();
            tablaSectores = objSectoresCLN.consultarSector();
            cboSector.ValueMember = "id_sector";
            cboSector.DisplayMember = "id_sector";
            cboSector.DataSource = tablaSectores;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objEntradasCLN.agregarEntradas(valorUltId, txtPrecio.Text, txtStock.Text, txtIdSector.Text, txtIdPartido.Text);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se agrego el registro");
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            objEntradasCLN.actualizarEntrada(id, txtPrecio.Text, txtStock.Text);
            cargarDataGridView();
            limpiarTextBox();
           
            MessageBox.Show("Se edito el registro");
        }


        private void btnElimiinar_Click(object sender, EventArgs e)
        {
            objEntradasCLN.eliminarEntrada(id);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se borró el registro");
        }

        private void dvgEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
           // valorUltId = dvgEntradas.Rows[indice].Cells[0].Value;

            id = Convert.ToInt32(dvgEntradas.Rows[indice].Cells[0].Value);
            txtIdEntrada.Text = dvgEntradas.Rows[indice].Cells[0].Value.ToString();
            txtPrecio.Text = dvgEntradas.Rows[indice].Cells[1].Value.ToString();
            txtStock.Text = dvgEntradas.Rows[indice].Cells[2].Value.ToString();
            txtIdSector.Text = dvgEntradas.Rows[indice].Cells[3].Value.ToString();
            txtIdPartido.Text = dvgEntradas.Rows[indice].Cells[4].Value.ToString();
             
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
