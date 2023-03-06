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
    public partial class Partidos : Form
    {
        private PartidosCLN objPartidosCLN;
        private int id, indice, cantFilas, posicionUltFila;
        private DataTable miTabla;
        private object valorUltId;

        public Partidos()
        {
            InitializeComponent();
            objPartidosCLN = new PartidosCLN();
            id = 0;
            indice = 0;
            cantFilas = 0;
            posicionUltFila = 0;
            miTabla = new DataTable();
            valorUltId = new object();
        }
        public void cargarDataGridView()
        {
            miTabla.Clear();
            miTabla = objPartidosCLN.consultarPartidos();
            dgvPartidos.DataSource = miTabla;
           
        }

        private void Partidos_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            cantFilas = dgvPartidos.Rows.Count;
            Console.WriteLine("cantFilas" + " " + cantFilas);
             posicionUltFila = objPartidosCLN.getPosicionUltFilaPartido(cantFilas);
            Console.WriteLine("posicionUltFila" + " " + posicionUltFila);

            valorUltId = dgvPartidos.Rows[posicionUltFila - 1].Cells[0].Value;
            int aux = Convert.ToInt32(valorUltId);
            Console.WriteLine("aux" + " " + aux);

            Console.WriteLine("valorUltId" + " " + Convert.ToInt32(valorUltId));



            limpiarTextBox();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            objPartidosCLN.actualizarPartido(id,txtTorneo.Text,txtFecha.Text);
            cargarDataGridView();
            limpiarTextBox();

            MessageBox.Show("Se edito el registro");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objPartidosCLN.eliminarPartido(id);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se borró el registro");
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objPartidosCLN.agregarPartidos(valorUltId, txtFecha.Text, txtTorneo.Text);
            Console.WriteLine(valorUltId + " Valor ULTID");
            Console.WriteLine(txtFecha.Text);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se agrego el registro");
        }

        private void dgvPartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            //Console.WriteLine("indice " + indice);
           // valorUltId = dgvPartidos.Rows[indice].Cells[0].Value;
            id = Convert.ToInt32(dgvPartidos.Rows[indice].Cells[0].Value);
            txtIdPartido.Text = dgvPartidos.Rows[indice].Cells[0].Value.ToString();
            txtFecha.Text = dgvPartidos.Rows[indice].Cells[1].Value.ToString();
            txtTorneo.Text = dgvPartidos.Rows[indice].Cells[2].Value.ToString();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
                menu.Show();
            Hide();

        }

        public void limpiarTextBox()
        {
            txtIdPartido.Clear();
            txtFecha.Clear();
            txtTorneo.Clear();
            
           
        }







    }
}
