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
    public partial class FrmConsultarAutopartes : Form
    {
        public FrmConsultarAutopartes()
        {
            InitializeComponent();
        }

        private async void FrmConsultarAutopartes_Load(object sender, EventArgs e)
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

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboTipoA.SelectedIndex == -1 || string.IsNullOrEmpty(txtStock.Text) ||
                !int.TryParse(txtStock.Text, out _))
            {

                MessageBox.Show("Debe completar bien todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            TipoAutoparte ta = (TipoAutoparte)cboTipoA.SelectedItem;
            int id_tipo_a = Convert.ToInt32(ta.IdTipoA);
            int stock = int.Parse(txtStock.Text);
            string url = string.Format("https://localhost:7282/api/Autoparte/Autopartes?stock={0}&tipoa={1}", stock, id_tipo_a);

            var result = await HttpHelper.GetInstance().GetAsync(url);
            List<Autoparte> lst = JsonConvert.DeserializeObject<List<Autoparte>>(result.Data);

            dgvAutopartes.Rows.Clear();
            if (lst != null)
            {
                foreach (Autoparte autoparte in lst)
                {
                    dgvAutopartes.Rows.Add(new object[] {
                    autoparte.IdAutoparte,
                    autoparte.NombreA,
                    ta,
                    autoparte.PrecioA,
                    autoparte.StockMin,
                    autoparte.StockAct,
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
            if (MessageBox.Show("Seguro que desea quitar la autoparte seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvAutopartes.CurrentRow != null)
                {
                    string nom = dgvAutopartes.CurrentRow.Cells[1].Value.ToString();
                    int nro = Convert.ToInt32(dgvAutopartes.CurrentRow.Cells[0].Value.ToString()); ;
                    string url = string.Format("https://localhost:7282/api/Autoparte/Delete?id={0}", nro);
                    var result = await HttpHelper.GetInstance().DeleteAsync(url);
                    if (result.Equals("Autoparte eliminada correctamente"))
                    {
                        MessageBox.Show("Autoparte " + nom + " dada de baja", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvAutopartes.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo elliminar la autoparte!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void dgvAutopartes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAutopartes.CurrentCell.ColumnIndex == 6)
            {
                int nro = int.Parse(dgvAutopartes.CurrentRow.Cells["colID"].Value.ToString());
                new FrmEditarAutoparte(nro).ShowDialog();

                dgvAutopartes.Rows.Clear();
            }
        }
    }
}
