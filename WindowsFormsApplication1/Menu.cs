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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            Entradas2 entradas = new Entradas2();
            entradas.Show();
            Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            Hide();

        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            Partidos partidos = new Partidos();
            partidos.Show();
            Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            Hide();
        }

        private void btnSector_Click(object sender, EventArgs e)
        {
            Sectores sectores = new Sectores();
            sectores.Show();
            Hide();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
            Hide();
        }
    }
}
