using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIALPROYECTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {

            if (txtboxusu.Text == "admin" && txtboxcontra.Text == "123456" )
            {
                MessageBox.Show("Inicio de sesion exitoso");

                FrmPrincipal principal = new FrmPrincipal();
                this.Hide();
                principal.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
