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
    public partial class FrmAutopartes : Form
    {
        private Autoparte nuevaA;
        public FrmAutopartes()
        {
            InitializeComponent();
            nuevaA = new Autoparte();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la autoparte!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            if (cboTipoA.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de autoparte!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipoA.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtStockMin.Text) || !int.TryParse(txtStockMin.Text, out _))
            {
                MessageBox.Show("Debe ingresar un stock minimo valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStockMin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtStockAct.Text) || !int.TryParse(txtStockAct.Text, out _))
            {
                MessageBox.Show("Debe ingresar un stock actual valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStockAct.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text) || !decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("Debe ingresar un precio valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return;
            }

            TipoAutoparte ta = (TipoAutoparte)cboTipoA.SelectedItem;
            nuevaA.TipoA = ta;
            nuevaA.NombreA = txtNombre.Text;
            nuevaA.StockAct = int.Parse(txtStockAct.Text);
            nuevaA.StockMin = int.Parse(txtStockMin.Text);
            nuevaA.PrecioA = decimal.Parse(txtPrecio.Text);

            await GrabarVehiculo();
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {
        }

        private void lblModelo_Click(object sender, EventArgs e)
        {
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
        }

        private void lblTipoV_Click(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void cboTipoV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void FrmAutopartes_Load(object sender, EventArgs e)
        {
            await CargarComboTipoAutoAsync();
        }
        private async Task CargarComboTipoAutoAsync()
        {
            string url = "https://localhost:7282/api/Autoparte/TiposAutopartes";
            var response = await HttpHelper.GetInstance().GetAsync(url);
            List<TipoAutoparte> list = JsonConvert.DeserializeObject<List<TipoAutoparte>>(response.Data);

            cboTipoA.DataSource = list;
            cboTipoA.ValueMember = "IdTipoA";
            cboTipoA.DisplayMember = "NombreAutoparte";
            cboTipoA.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoA.SelectedIndex = -1;

        }
        private async Task GrabarVehiculo()
        {
            string json = JsonConvert.SerializeObject(nuevaA);
            string url = "https://localhost:7282/api/Autoparte/nuevaAutoparte";
            var resp = await HttpHelper.GetInstance().PostAsync(url, json);
            if (resp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("¡La autoparte se cargo exitosamente!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Código: " + resp.StatusCode + "|" + resp.Data);
            };
        }

    }
}
