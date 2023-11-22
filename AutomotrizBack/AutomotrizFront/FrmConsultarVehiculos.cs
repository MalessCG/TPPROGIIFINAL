using AutomotrizBack.Entidades;
using Newtonsoft.Json;
using ProduccionFront.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront
{
    public partial class FrmConsultarVehiculos : Form
    {
        public FrmConsultarVehiculos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void FrmConsultarVehiculos_Load(object sender, EventArgs e)
        {
            await CargarComboTipoVAsync();
        }
        private async Task CargarComboTipoVAsync()
        {
            string url = "https://localhost:7282/api/Vehiculo/TiposVehiculos";
            var response = await HttpHelper.GetInstance().GetAsync(url);
            List<TiposVehiculos> list = JsonConvert.DeserializeObject<List<TiposVehiculos>>(response.Data);

            cboTiposV.DataSource = list;
            cboTiposV.ValueMember = "IdTipoV";
            cboTiposV.DisplayMember = "NombreTipoV";
            cboTiposV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTiposV.SelectedIndex = -1;

        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboTiposV.SelectedIndex == -1 || string.IsNullOrEmpty(txtPrecioDesde.Text) ||
                !decimal.TryParse(txtPrecioDesde.Text, out _) || string.IsNullOrEmpty(txtPrecioHasta.Text)
                || !decimal.TryParse(txtPrecioHasta.Text, out _))
            {

                MessageBox.Show("Debe completar bien todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            TiposVehiculos tv = (TiposVehiculos)cboTiposV.SelectedItem;
            int id_tipo_v = Convert.ToInt32(tv.IdTipoV);
            decimal desde = decimal.Parse(txtPrecioDesde.Text);
            decimal hasta = decimal.Parse(txtPrecioHasta.Text);
            string url = string.Format("https://localhost:7282/api/Vehiculo/Vehiculos?desde={0}&hasta={1}&tipov={2}", desde, hasta, id_tipo_v);

            var result = await HttpHelper.GetInstance().GetAsync(url);
            List<Vehiculo> lst = JsonConvert.DeserializeObject<List<Vehiculo>>(result.Data);

            dgvVehiculos.Rows.Clear();
            if (lst != null)
            {
                foreach (Vehiculo vehiculo in lst)
                {
                    dgvVehiculos.Rows.Add(new object[] {
                    vehiculo.Id,
                    vehiculo.Nombre,
                    tv,
                    vehiculo.Precio,
                    vehiculo.Modelo,
                    "Editar"
                    });
                }
            }
            else
            {
                MessageBox.Show("Sin datos de vehiculos para los filtros ingresados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea quitar el vehiculo seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvVehiculos.CurrentRow != null)
                {
                    string nom = dgvVehiculos.CurrentRow.Cells[1].Value.ToString();
                    int nro = Convert.ToInt32(dgvVehiculos.CurrentRow.Cells[0].Value.ToString()); ;
                    string url = string.Format("https://localhost:7282/api/Vehiculo/Delete?id={0}", nro);
                    var result = await HttpHelper.GetInstance().DeleteAsync(url);
                    if (result.Equals("Vehiculo eliminado correctamente"))
                    {
                        MessageBox.Show("Vehiculo " + nom + " dado de baja", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvVehiculos.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo elimiar el vehiculo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehiculos.CurrentCell.ColumnIndex == 5)
            {
                int nro = int.Parse(dgvVehiculos.CurrentRow.Cells["colId"].Value.ToString());
                new FrmEditarVehiculo(nro).ShowDialog();

                dgvVehiculos.Rows.Clear();
            }
        }
    }
}
