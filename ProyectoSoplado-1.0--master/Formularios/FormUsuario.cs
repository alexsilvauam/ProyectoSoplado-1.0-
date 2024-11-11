using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoplado_1._0_
{
    public partial class frm_IniciarSesion : Form
    {
        public frm_IniciarSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtNombreUsuario.Text; 

            if (!string.IsNullOrEmpty(username))
            {
                MessageBox.Show($"Bienvenido, {username}!");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un nombre de usuario.");
            }
        }

      private void label1_Click_1(object sender, EventArgs e)
      {

      }

      private void label1_Click_2(object sender, EventArgs e)
      {

      }
   }
}
