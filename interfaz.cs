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
    public partial class gestionar : Form
    {
        public gestionar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvExpedientes.Rows.Clear();

            if (System.IO.File.Exists("expedientes.txt"))
            {
                string[] datos = System.IO.File.ReadAllLines("expedientes.txt");

                foreach (string linea in datos)
                {
                    dgvExpedientes.Rows.Add(linea.Split('|'));
                }
            }
            else
            {
                if (System.IO.File.Exists("expedientes.txt"))
                {
                    string[] datos = System.IO.File.ReadAllLines("expedientes.txt");

                    dgvExpedientes.Rows.Clear();

                    for (int i = 0; i < datos.Length; i++)
                    {
                        dgvExpedientes.Rows.Add(datos[i].Split('|'));
                    }
                }
                else
                {
                    MessageBox.Show("No hay expedientes registrados.");
                }
            }

        }

        
    }
}
