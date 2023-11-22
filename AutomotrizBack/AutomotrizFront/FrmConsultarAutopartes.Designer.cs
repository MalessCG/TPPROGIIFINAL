namespace AutomotrizFront
{
    partial class FrmConsultarAutopartes
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
            btnConsultar = new Button();
            btnBorrar = new Button();
            btnSalir = new Button();
            dgvAutopartes = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipoAutoparte = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colStockMin = new DataGridViewTextBoxColumn();
            colStockAct = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtStock = new TextBox();
            cboTipoA = new ComboBox();
            lblTipoA = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAutopartes).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(669, 111);
            btnConsultar.Margin = new Padding(5, 4, 5, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(136, 36);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(24, 499);
            btnBorrar.Margin = new Padding(5, 4, 5, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(112, 36);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 499);
            btnSalir.Margin = new Padding(5, 4, 5, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 36);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvAutopartes
            // 
            dgvAutopartes.AllowUserToAddRows = false;
            dgvAutopartes.AllowUserToDeleteRows = false;
            dgvAutopartes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutopartes.Columns.AddRange(new DataGridViewColumn[] { colID, colNombre, colTipoAutoparte, colPrecio, colStockMin, colStockAct, ColAcciones });
            dgvAutopartes.Location = new Point(24, 155);
            dgvAutopartes.Margin = new Padding(5, 4, 5, 4);
            dgvAutopartes.Name = "dgvAutopartes";
            dgvAutopartes.ReadOnly = true;
            dgvAutopartes.RowHeadersWidth = 51;
            dgvAutopartes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutopartes.Size = new Size(781, 336);
            dgvAutopartes.TabIndex = 12;
            dgvAutopartes.CellContentClick += dgvAutopartes_CellContentClick;
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
            // colTipoAutoparte
            // 
            colTipoAutoparte.HeaderText = "Tipo autoparte";
            colTipoAutoparte.MinimumWidth = 6;
            colTipoAutoparte.Name = "colTipoAutoparte";
            colTipoAutoparte.ReadOnly = true;
            colTipoAutoparte.Width = 125;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 125;
            // 
            // colStockMin
            // 
            colStockMin.HeaderText = "Stock minimo";
            colStockMin.MinimumWidth = 6;
            colStockMin.Name = "colStockMin";
            colStockMin.ReadOnly = true;
            colStockMin.Width = 125;
            // 
            // colStockAct
            // 
            colStockAct.HeaderText = "Stock actual";
            colStockAct.MinimumWidth = 6;
            colStockAct.Name = "colStockAct";
            colStockAct.ReadOnly = true;
            colStockAct.Width = 65;
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
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(cboTipoA);
            groupBox1.Controls.Add(lblTipoA);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, -3);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(529, 149);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(179, 12);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(350, 37);
            label3.TabIndex = 46;
            label3.Text = "CONSULTAR AUTOPARTES";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(135, 63);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(220, 27);
            txtStock.TabIndex = 44;
            // 
            // cboTipoA
            // 
            cboTipoA.FormattingEnabled = true;
            cboTipoA.Location = new Point(135, 101);
            cboTipoA.Margin = new Padding(5, 4, 5, 4);
            cboTipoA.Name = "cboTipoA";
            cboTipoA.Size = new Size(220, 28);
            cboTipoA.TabIndex = 43;
            // 
            // lblTipoA
            // 
            lblTipoA.AutoSize = true;
            lblTipoA.ForeColor = Color.Orange;
            lblTipoA.Location = new Point(16, 105);
            lblTipoA.Margin = new Padding(5, 0, 5, 0);
            lblTipoA.Name = "lblTipoA";
            lblTipoA.Size = new Size(132, 20);
            lblTipoA.TabIndex = 5;
            lblTipoA.Text = "Tipo de autoparte:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(16, 67);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 3;
            label1.Text = "Stock requerido:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(648, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultarAutopartes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(819, 589);
            Controls.Add(pictureBox1);
            Controls.Add(btnConsultar);
            Controls.Add(btnBorrar);
            Controls.Add(btnSalir);
            Controls.Add(dgvAutopartes);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConsultarAutopartes";
            Text = "FrmConsultarAutopartes";
            Load += FrmConsultarAutopartes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAutopartes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsultar;
        private Button btnBorrar;
        private Button btnSalir;
        private DataGridView dgvAutopartes;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipoAutoparte;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colStockMin;
        private DataGridViewTextBoxColumn colStockAct;
        private DataGridViewButtonColumn ColAcciones;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtStock;
        private ComboBox cboTipoA;
        private Label lblTipoA;
        private Label label1;
        private PictureBox pictureBox1;
    }
}