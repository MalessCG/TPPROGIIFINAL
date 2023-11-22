using AutomotrizBack.Entidades;

using Newtonsoft.Json;
using ProduccionFront.Http;
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
    public partial class frmFactura : Form
    {
        private Factura nuevaFactura;

        public frmFactura()
        {
            InitializeComponent();
            nuevaFactura = new Factura();
        }

        private async void frmFactura_Load(object sender, EventArgs e)
        {
            await CargarComboAutoparteAsync();
            await CargarComboClienteAsync();
        }
        private async Task CargarComboAutoparteAsync()
        {
            string url = "https://localhost:7282/api/Factura/autopartes";
            var response = await HttpHelper.GetInstance().GetAsync(url);
            List<Autoparte> list = JsonConvert.DeserializeObject<List<Autoparte>>(response.Data);

            cboAutoparte.DataSource = list;
            cboAutoparte.ValueMember = "IdAutoparte";
            cboAutoparte.DisplayMember = "NombreA";
            cboAutoparte.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async Task CargarComboClienteAsync()
        {
            string url = "https://localhost:7282/api/Factura/clientes";
            var response = await HttpHelper.GetInstance().GetAsync(url);
            List<Cliente> list = JsonConvert.DeserializeObject<List<Cliente>>(response.Data);

            cboClientes.DataSource = list;
            cboClientes.ValueMember = "IdCliente";
            cboClientes.DisplayMember = "Apellido";
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private bool existeEnGrilla(string nombre)
        {
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["colAutoparte"].Value.ToString().Equals(nombre))
                {
                    return true;
                }
            }

            return false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Autoparte a = (Autoparte)cboAutoparte.SelectedItem;
            if (existeEnGrilla(a.NombreA))
            {
                MessageBox.Show("Este producto ya esta cargado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAutoparte.Focus();
                return;
            }
            if (cboAutoparte.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAutoparte.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nudCantidad.Text) || !int.TryParse(nudCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nudCantidad.Focus();
                return;
            }

            int cantidad = Convert.ToInt32(nudCantidad.Value);
            DetalleFactura det = new DetalleFactura(a, cantidad);
            int subtotal = Convert.ToInt32(det.Autoparte.PrecioA) * Convert.ToInt32(nudCantidad.Value);
            nuevaFactura.AgregarDetalle(det);
            dgvDetalles.Rows.Add(new object[] { det.Id, det.Autoparte.NombreA, det.Autoparte.PrecioA, det.Cantidad, subtotal, "Quitar" });

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value < DateTime.Today)
            {
                MessageBox.Show("Debe ingresar una fecha validad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFecha.Focus();
                return;
            }
            if (cboClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboClientes.Focus();
                return;
            }
            if (dgvDetalles.CurrentRow == null)
            {
                MessageBox.Show("Debe ingresar una carga para confirmar la orden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nuevaFactura.Cliente = Convert.ToInt32(cboClientes.SelectedValue);
            nuevaFactura.Fecha = dtpFecha.Value;

            string json = JsonConvert.SerializeObject(nuevaFactura);
            string url = "https://localhost:7282/api/Factura";
            var resp = await HttpHelper.GetInstance().PostAsync(url, json);
            if (resp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("¡La orden se cargo exitosamente!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Código: " + resp.StatusCode + "|" + resp.Data);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 5)
            {
                nuevaFactura.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);


            }
        }
    }
}
