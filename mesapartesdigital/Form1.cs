using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mesapartesdigital
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string contrasena = txtcontraseña.Text;

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Ingrese su usuario y contraseña.");
            }
            else if (usuario == "admin" && contrasena == "1234")
            {
                MessageBox.Show("Inicio de sesión correcto.");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }


        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
