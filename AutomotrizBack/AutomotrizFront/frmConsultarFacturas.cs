using AutomotrizBack.Entidades;
using AutomotrizBack.Fachada.Implementacion;
using AutomotrizBack.Fachada.Interfaz;
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
    public partial class frmConsultarFacturas : Form
    {
        private IAplicacion servicio = null;
        public frmConsultarFacturas()
        {
            InitializeComponent();
        }

        private void frmConsultarFacturas_Load(object sender, EventArgs e)
        {
            servicio = new Aplicacion();
        }

        private async void frmConsultarFacturas_Load_1(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-7);
            dtpHasta.Value = DateTime.Now;
            await CargarComboAsync();
        }

        private async Task CargarComboAsync()
        {
            string url = "https://localhost:7282/api/Factura/clientes";
            var response = await HttpHelper.GetInstance().GetAsync(url);
            List<Cliente> list = JsonConvert.DeserializeObject<List<Cliente>>(response.Data);

            cboClientes.DataSource = list;
            cboClientes.ValueMember = "IdCliente";
            cboClientes.DisplayMember = "Apellido";
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList; ;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("Periodo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Para enviar parámetros por URL de manera correcta, salvando (escapando)
            //caracteres especiales y blancos se utiliza el método **Uri.EscapeDataString**
            String fecDesde, fecHasta;
            fecDesde = Uri.EscapeDataString(dtpDesde.Value.ToString("yyyy/MM/dd"));
            fecHasta = Uri.EscapeDataString(dtpHasta.Value.ToString("yyyy/MM/dd"));
            int cliente = Convert.ToInt32(cboClientes.SelectedValue);
            CargarFacturas(fecDesde, fecHasta, cliente);
        }
        private async void CargarFacturas(string desde, string hasta, int cliente)
        {
            string url = string.Format("https://localhost:7282/api/Factura/facturas?desde={0}&hasta={1}&cliente={2}", desde, hasta, cliente);

            var result = await HttpHelper.GetInstance().GetAsync(url);
            List<Factura> lst = JsonConvert.DeserializeObject<List<Factura>>(result.Data);

            dgvFacturas.Rows.Clear();
            if (lst != null)
            {
                foreach (Factura factura in lst)
                {
                    dgvFacturas.Rows.Add(new object[] {
                    factura.Nro,
                    factura.Fecha.ToString("dd/MM/yyyy"),
                    factura.Cliente,
                    "Editar"
                    });
                }
            }
            else
            {
                MessageBox.Show("Sin datos de facturas para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturas.CurrentCell.ColumnIndex == 3)
            {
                int nro = int.Parse(dgvFacturas.CurrentRow.Cells["colNro"].Value.ToString());
                new FrmEditarFactura(nro).ShowDialog();

                dgvFacturas.Rows.Clear();
            }
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea quitar la factura seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvFacturas.CurrentRow != null)
                {
                    int nro = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[0].Value.ToString()); ;
                    string url = string.Format("https://localhost:7282/api/Factura/Delete?id={0}", nro);
                    var result = await HttpHelper.GetInstance().DeleteAsync(url);
                    if (result.Equals("factura eliminada correctamente"))
                    {
                        MessageBox.Show("Factura " + nro + " dada de baja", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvFacturas.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo dar de baja la factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
