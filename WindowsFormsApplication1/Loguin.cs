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
    public partial class Loguin : Form
    {

        private UsuarioCLN objUsuarioCLN;
        private Validar validar;

        public Loguin()
        {
            InitializeComponent();
            objUsuarioCLN = new UsuarioCLN();
            validar = new Validar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            bandera = objUsuarioCLN.validarUsuario(txtIdUsuario.Text, txtContraseña.Text);

            if(bandera == 1)
            {
                 MessageBox.Show("usuario registrado");
                Menu frmMenu = new Menu();
                frmMenu.Show();
                
                Hide();
            } 
            if(bandera == 0)
            {
                MessageBox.Show("Usuario no registrado");
                Application.Exit();
            }
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
