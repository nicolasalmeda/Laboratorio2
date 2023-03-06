using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Pedidos : Form
    {
        private PedidosCLN objPedidosCLN;
        private EntradasCLN objEntradasCLN;
        private ClientesCLN objClientesCLN;
        private DataTable tablaPedidos, tablaEntradas, tablaClientes;
        private int indicePartidos, indiceUsuarios,id,indice;
        private object valorUltId;

        public Pedidos()
        {
            InitializeComponent();
            objPedidosCLN = new PedidosCLN();
            objEntradasCLN = new EntradasCLN();
            objClientesCLN = new ClientesCLN();
            tablaPedidos = new DataTable();
            tablaEntradas = new DataTable();
            tablaClientes = new DataTable();
            indicePartidos = 0;
            indiceUsuarios = 0;
            indice = 0;
            id = 0;
            valorUltId = new object();

        }

        public void cargarDataGridView()
        {
            tablaPedidos.Clear();
            tablaPedidos = objPedidosCLN.consultarPedidos();
            dgvPedidos.DataSource = tablaPedidos;
        }

        private void cboPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            indicePartidos = cboPartidos.SelectedIndex;
            int idAdd = Convert.ToInt32(tablaEntradas.Rows[indicePartidos].ItemArray[0]);
            //lblMostrar.Text = indicePartidos.ToString();
            lblMostrar.Text = tablaEntradas.Rows[indicePartidos].ItemArray[1].ToString();
            //lblId.Text = idAdd.ToString();
            lblId.Text = tablaEntradas.Rows[indicePartidos].ItemArray[2].ToString();
            txtIdEntrada.Text = cboPartidos.Text;
            txtTotal.Text = lblMostrar.Text;
        }

        


        public void cargarComboEntradas()
        {
            tablaEntradas.Clear();
            tablaEntradas = objEntradasCLN.consultarEntradas();
            cboPartidos.ValueMember = "id_entrada";
            cboPartidos.DisplayMember = "id_entrada";
            cboPartidos.DataSource = tablaEntradas;
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceUsuarios = cboCliente.SelectedIndex;
            int idAdd = Convert.ToInt32(tablaClientes.Rows[indiceUsuarios].ItemArray[0]);
            lblNombre.Text = tablaClientes.Rows[indiceUsuarios].ItemArray[1].ToString();
            lblApellido.Text = tablaClientes.Rows[indiceUsuarios].ItemArray[2].ToString();
            txtIdCliente.Text = cboCliente.Text;
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objPedidosCLN.agregarPedidos(valorUltId, txtTotal.Text, txtIdCliente.Text, txtIdEntrada.Text, txtCant.Text);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se agrego el registro");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objPedidosCLN.eliminarPedido(id);
            cargarDataGridView();
            limpiarTextBox();
            MessageBox.Show("Se borró el registro");
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            objPedidosCLN.actualizarPedido(id, txtTotal.Text, txtIdCliente.Text, txtIdEntrada.Text, txtCant.Text);
            cargarDataGridView();
            limpiarTextBox();

            MessageBox.Show("Se edito el registro");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            //valorUltId = dgvPedidos.Rows[indice].Cells[0].Value;

            id = Convert.ToInt32(dgvPedidos.Rows[indice].Cells[0].Value);
            txtIdPedido.Text = dgvPedidos.Rows[indice].Cells[0].Value.ToString();
            txtTotal.Text = dgvPedidos.Rows[indice].Cells[1].Value.ToString();
            txtIdCliente.Text = dgvPedidos.Rows[indice].Cells[2].Value.ToString();
            txtIdEntrada.Text = dgvPedidos.Rows[indice].Cells[3].Value.ToString();
            txtCant.Text = dgvPedidos.Rows[indice].Cells[4].Value.ToString();

        }


        public void cargarComboUsuarios()
        {
            tablaClientes.Clear();
            tablaClientes = objClientesCLN.consultarClientes();
            cboCliente.ValueMember = "id_cliente";
            cboCliente.DisplayMember = "id_cliente";
            cboCliente.DataSource = tablaClientes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            cargarComboEntradas();
            cargarComboUsuarios();

            int cantFilas = dgvPedidos.Rows.Count;
            int posicionUltFila = objPedidosCLN.getPosicionUltFilaPedidos(cantFilas);

            valorUltId = dgvPedidos.Rows[posicionUltFila - 1].Cells[0].Value;

            limpiarTextBox();
        }

        public void limpiarTextBox()
        {
            txtIdPedido.Clear();
            txtTotal.Clear();
            txtIdEntrada.Clear();
            txtIdCliente.Clear();
            txtCant.Clear();
        }








    }
}
