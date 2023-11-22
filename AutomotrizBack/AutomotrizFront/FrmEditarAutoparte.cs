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
    public partial class FrmEditarAutoparte : Form
    {
        private int Codigo;
        private Autoparte autoparte;
        public FrmEditarAutoparte(int nro)
        {
            InitializeComponent();
            Codigo = nro;
            autoparte = new Autoparte();
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
        private async void FrmEditarAutoparte_Load(object sender, EventArgs e)
        {
            await CargarComboTipoAutoAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
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
            autoparte.TipoA = ta;
            autoparte.NombreA = txtNombre.Text;
            autoparte.StockAct = int.Parse(txtStockAct.Text);
            autoparte.StockMin = int.Parse(txtStockMin.Text);
            autoparte.PrecioA = decimal.Parse(txtPrecio.Text);
            autoparte.IdAutoparte = Codigo;
            string json = JsonConvert.SerializeObject(autoparte);
            string url = "https://localhost:7282/api/Autoparte/Modificar";
            var result = await HttpHelper.GetInstance().PutAsync(url, json);

            if (result.Equals("Autoparte modificada"))
            {
                MessageBox.Show("Autoparte modificada", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la autoparte", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
