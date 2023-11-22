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
using Color = AutomotrizBack.Entidades.Color;

namespace AutomotrizFront
{
    public partial class FrmVehiculos : Form
    {
        private Vehiculo nuevo;

        public FrmVehiculos()
        {
            InitializeComponent();
            nuevo = new Vehiculo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void FrmVehiculos_Load(object sender, EventArgs e)
        {
            await CargarComboColorAsync();
            await CargarComboTipoVAsync();

        }
        private async Task CargarComboColorAsync()
        {
            string url = "https://localhost:7282/api/Vehiculo/Colores";
            var response = await HttpHelper.GetInstance().GetAsync(url);
            List<Color> list = JsonConvert.DeserializeObject<List<Color>>(response.Data);

            cboColor.DataSource = list;
            cboColor.ValueMember = "IdColor";
            cboColor.DisplayMember = "NombreColor";
            cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoV.SelectedIndex = -1;
        }
        private async Task CargarComboTipoVAsync()
        {
            string url = "https://localhost:7282/api/Vehiculo/TiposVehiculos";
            var response = await HttpHelper.GetInstance().GetAsync(url);
            List<TiposVehiculos> list = JsonConvert.DeserializeObject<List<TiposVehiculos>>(response.Data);

            cboTipoV.DataSource = list;
            cboTipoV.ValueMember = "IdTipoV";
            cboTipoV.DisplayMember = "NombreTipoV";
            cboTipoV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoV.SelectedIndex = -1;

        }
        private async void Crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del vehiculo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            if (cboTipoV.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de vehiculo!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipoV.Focus();
                return;
            }
            if (cboColor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un color!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboColor.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtModelo.Text) || !int.TryParse(txtModelo.Text, out _))
            {
                MessageBox.Show("Debe ingresar un modelo valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtModelo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text) || !decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("Debe ingresar un precio valido!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return;
            }
            Color color = (Color)cboColor.SelectedItem;
            TiposVehiculos tv = (TiposVehiculos)cboTipoV.SelectedItem;
            nuevo.Color = color;
            nuevo.TipoV = tv;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Modelo = int.Parse(txtModelo.Text);
            nuevo.Precio = decimal.Parse(txtPrecio.Text);

            await GrabarVehiculo();

        }

        private async Task GrabarVehiculo()
        {
            string json = JsonConvert.SerializeObject(nuevo);
            string url = "https://localhost:7282/api/Vehiculo/nuevoVehiculo";
            var resp = await HttpHelper.GetInstance().PostAsync(url, json);
            if (resp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("¡El vehiculo se cargo exitosamente!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Código: " + resp.StatusCode + "|" + resp.Data);
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void lblTipoV_Click(object sender, EventArgs e)
        {

        }
    }
}
