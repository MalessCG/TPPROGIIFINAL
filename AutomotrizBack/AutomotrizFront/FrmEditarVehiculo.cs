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
    public partial class FrmEditarVehiculo : Form
    {
        private int Codigo;
        private Vehiculo vehiculo;
        public FrmEditarVehiculo(int nro)
        {
            InitializeComponent();
            Codigo = nro;
            vehiculo = new Vehiculo();
        }

        private async void FrmEditarVehiculo_Load(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
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
            vehiculo.Color = color;
            vehiculo.TipoV = tv;
            vehiculo.Nombre = txtNombre.Text;
            vehiculo.Modelo = int.Parse(txtModelo.Text);
            vehiculo.Precio = decimal.Parse(txtPrecio.Text);
            vehiculo.Id = Codigo;
            string json = JsonConvert.SerializeObject(vehiculo);
            string url = "https://localhost:7282/api/Vehiculo/Modificar";
            var result = await HttpHelper.GetInstance().PutAsync(url, json);

            if (result.Equals("Vehiculo modificado"))
            {
                MessageBox.Show("Vehiculo modificado!", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el vehiculo!", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
