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

namespace AutomotrizFront
{
    public partial class frmLogin : Form
    {
        private string usuario;
        private string contraseña;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                this.Hide();
                frmPrincipal principal = new frmPrincipal();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña", "Mensaje del sistema",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtContraseña.Text = "";
                txtContraseña.Focus();
                return;
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            usuario = "TPIAUTOMOTRIZ";
            contraseña = "PROGII2023";
        }
    }
}
