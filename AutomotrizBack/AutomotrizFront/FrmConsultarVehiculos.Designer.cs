namespace AutomotrizFront
{
    partial class FrmConsultarVehiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBorrar = new Button();
            btnSalir = new Button();
            dgvVehiculos = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipoVehiculo = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtPrecioHasta = new TextBox();
            txtPrecioDesde = new TextBox();
            cboTiposV = new ComboBox();
            lblTipoV = new Label();
            label2 = new Label();
            label1 = new Label();
            btnConsultar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(48, 517);
            btnBorrar.Margin = new Padding(5, 4, 5, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(112, 36);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(557, 517);
            btnSalir.Margin = new Padding(5, 4, 5, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 36);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AllowUserToAddRows = false;
            dgvVehiculos.AllowUserToDeleteRows = false;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Columns.AddRange(new DataGridViewColumn[] { colID, colNombre, colTipoVehiculo, colPrecio, colModelo, ColAcciones });
            dgvVehiculos.Location = new Point(48, 173);
            dgvVehiculos.Margin = new Padding(5, 4, 5, 4);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ReadOnly = true;
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculos.Size = new Size(662, 336);
            dgvVehiculos.TabIndex = 7;
            dgvVehiculos.CellContentClick += dgvVehiculos_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 40;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 130;
            // 
            // colTipoVehiculo
            // 
            colTipoVehiculo.HeaderText = "Tipo vehiculo";
            colTipoVehiculo.MinimumWidth = 6;
            colTipoVehiculo.Name = "colTipoVehiculo";
            colTipoVehiculo.ReadOnly = true;
            colTipoVehiculo.Width = 125;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 125;
            // 
            // colModelo
            // 
            colModelo.HeaderText = "Modelo";
            colModelo.MinimumWidth = 6;
            colModelo.Name = "colModelo";
            colModelo.ReadOnly = true;
            colModelo.Width = 65;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "Acciones";
            ColAcciones.MinimumWidth = 6;
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Resizable = DataGridViewTriState.True;
            ColAcciones.SortMode = DataGridViewColumnSortMode.Automatic;
            ColAcciones.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrecioHasta);
            groupBox1.Controls.Add(txtPrecioDesde);
            groupBox1.Controls.Add(cboTiposV);
            groupBox1.Controls.Add(lblTipoV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Orange;
            groupBox1.Location = new Point(31, 16);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(529, 149);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(175, 10);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(327, 37);
            label3.TabIndex = 46;
            label3.Text = "CONSULTAR VEHICULOS";
            // 
            // txtPrecioHasta
            // 
            txtPrecioHasta.Location = new Point(368, 63);
            txtPrecioHasta.Margin = new Padding(3, 4, 3, 4);
            txtPrecioHasta.Name = "txtPrecioHasta";
            txtPrecioHasta.Size = new Size(153, 27);
            txtPrecioHasta.TabIndex = 45;
            // 
            // txtPrecioDesde
            // 
            txtPrecioDesde.Location = new Point(135, 63);
            txtPrecioDesde.Margin = new Padding(3, 4, 3, 4);
            txtPrecioDesde.Name = "txtPrecioDesde";
            txtPrecioDesde.Size = new Size(153, 27);
            txtPrecioDesde.TabIndex = 44;
            // 
            // cboTiposV
            // 
            cboTiposV.FormattingEnabled = true;
            cboTiposV.Location = new Point(135, 101);
            cboTiposV.Margin = new Padding(5, 4, 5, 4);
            cboTiposV.Name = "cboTiposV";
            cboTiposV.Size = new Size(134, 28);
            cboTiposV.TabIndex = 43;
            // 
            // lblTipoV
            // 
            lblTipoV.AutoSize = true;
            lblTipoV.Location = new Point(15, 105);
            lblTipoV.Margin = new Padding(5, 0, 5, 0);
            lblTipoV.Name = "lblTipoV";
            lblTipoV.Size = new Size(122, 20);
            lblTipoV.TabIndex = 5;
            lblTipoV.Text = "Tipo de vehiculo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 67);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 67);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 3;
            label1.Text = "Precio desde:";
            label1.Click += label1_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(562, 129);
            btnConsultar.Margin = new Padding(5, 4, 5, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(136, 36);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(576, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultarVehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(721, 584);
            Controls.Add(pictureBox1);
            Controls.Add(btnConsultar);
            Controls.Add(btnBorrar);
            Controls.Add(btnSalir);
            Controls.Add(dgvVehiculos);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConsultarVehiculos";
            Text = "FrmConsultarVehiculos";
            Load += FrmConsultarVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrar;
        private Button btnSalir;
        private DataGridView dgvVehiculos;
        private GroupBox groupBox1;
        private ComboBox cboTiposV;
        private Label lblTipoV;
        private Label label2;
        private Label label1;
        private Button btnConsultar;
        private TextBox txtPrecioHasta;
        private TextBox txtPrecioDesde;
        private Label label3;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipoVehiculo;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewButtonColumn ColAcciones;
        private PictureBox pictureBox1;
    }
}