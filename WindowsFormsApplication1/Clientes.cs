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
    public partial class Clientes : Form
    {
        private ClientesCLN objClientesCLN;
        private int id, indice;
        private DataTable miTabla;
        private object valorUltId;



        public Clientes()
        {
            InitializeComponent();
            objClientesCLN = new ClientesCLN();
            id = 0;
            indice = 0;
            miTabla = new DataTable();
            valorUltId = new object();


        }

        public void cargarDataGridView()
        {
            miTabla.Clear();
            miTabla = objClientesCLN.consultarClientes();
            dgvClientes.DataSource = miTabla;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            int cantFilas = dgvClientes.Rows.Count;
            int posicionUltFila = objClientesCLN.getPosicionUltFilaClientes(cantFilas);
             valorUltId = dgvClientes.Rows[posicionUltFila - 1].Cells[0].Value;
            Console.WriteLine(valorUltId + " VALORULTID CLIENTE");
            limpiarTextBox();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            objClientesCLN.actualizarCliente(id, txtNombre.Text, txtApellido.Text, txtContraseña.Text);
            cargarDataGridView();
            limpiarTextBox();

            MessageBox.Show("Se edito el registro");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objClientesCLN.eliminarCliente(id);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se borró el registro");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objClientesCLN.agregarClientes(valorUltId, txtNombre.Text, txtApellido.Text, txtContraseña.Text);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se agrego el registro");
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            //valorUltId = dgvClientes.Rows[indice].Cells[0].Value;

            id = Convert.ToInt32(dgvClientes.Rows[indice].Cells[0].Value);
            txtIdCliente.Text = dgvClientes.Rows[indice].Cells[0].Value.ToString();
            txtNombre.Text = dgvClientes.Rows[indice].Cells[1].Value.ToString();
            txtApellido.Text = dgvClientes.Rows[indice].Cells[2].Value.ToString();
            txtContraseña.Text = dgvClientes.Rows[indice].Cells[3].Value.ToString();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu frmenu = new Menu();
            frmenu.Show();
            Hide();
        }

        public void limpiarTextBox()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtContraseña.Clear();
            txtApellido.Clear();


        }



    }
}
