using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cabrera Fernando\r\nCrespo Facundo\r\nJoaquín Perotti\r\nSalgado Matias\r\nUbal Nahuel", "AUTOMOTRIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura nueva = new frmFactura();
            nueva.ShowDialog();
        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarFacturas consulta = new frmConsultarFacturas();
            consulta.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grabarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculos vehiculos = new FrmVehiculos();
            vehiculos.ShowDialog();
        }

        private void consultarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarVehiculos consulta = new FrmConsultarVehiculos();
            consulta.ShowDialog();
        }

        private void autopartesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grabarAutoparteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutopartes autoparte = new FrmAutopartes();
            autoparte.ShowDialog();
        }

        private void consultarAutoparteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAutopartes consultaAutoparte = new FrmConsultarAutopartes();
            consultaAutoparte.ShowDialog();
        }
    }
}
