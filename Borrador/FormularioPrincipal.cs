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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnAccesoUsuario_Click(object sender, EventArgs e)
        {
            frm_IniciarSesion userForm = new frm_IniciarSesion();

            userForm.Show();

        }


        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
