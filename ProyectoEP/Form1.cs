using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEP
{
    public partial class MesaDePartesDigital : Form
    {
        public MesaDePartesDigital()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtboxusu.Text == "admin" && txtboxcontra.Text == "123456")
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                FrmPrincipal principal = new FrmPrincipal();
                this.Hide();
                principal.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }

        }

        private void txtboxusu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
