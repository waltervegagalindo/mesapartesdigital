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
            string usuario = txtusuario.Text;
            string contrasena = txtcontraseña.Text;

            // 2. Validar que no estén vacías
            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Faltan datos obligatorios");
            }
            else
            {
                // 3. Validar usuario y contraseña
                if (usuario == "admin" && contrasena == "1234")
                {
                    MessageBox.Show("Bienvenido al sistema");

                    // Abrir la ventana principal si existe
                    // FrmMenuPrincipal ventana = new FrmMenuPrincipal();
                    // ventana.Show();
                    // this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");

                    // Limpiar las cajas
                    txtusuario.Text = "";
                    txtcontraseña.Text = "";
                }
            }
          }
        

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
