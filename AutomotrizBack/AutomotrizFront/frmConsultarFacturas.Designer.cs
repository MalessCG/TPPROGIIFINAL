namespace AutomotrizFront
{
    partial class frmConsultarFacturas
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
            btnSalir = new Button();
            dgvFacturas = new DataGridView();
            colNro = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            cboClientes = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            btnConsultar = new Button();
            btnBorrar = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(360, 529);
            btnSalir.Margin = new Padding(5, 4, 5, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 36);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Columns.AddRange(new DataGridViewColumn[] { colNro, colFecha, colCliente, ColAcciones });
            dgvFacturas.Location = new Point(15, 185);
            dgvFacturas.Margin = new Padding(5, 4, 5, 4);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.ReadOnly = true;
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.Size = new Size(586, 336);
            dgvFacturas.TabIndex = 3;
            dgvFacturas.CellContentClick += dgvFacturas_CellContentClick;
            // 
            // colNro
            // 
            colNro.HeaderText = "Factura N°";
            colNro.MinimumWidth = 6;
            colNro.Name = "colNro";
            colNro.ReadOnly = true;
            colNro.Width = 125;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 115;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            colCliente.Width = 160;
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
            groupBox1.Controls.Add(cboClientes);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpHasta);
            groupBox1.Controls.Add(dtpDesde);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.ForeColor = Color.Orange;
            groupBox1.Location = new Point(15, 73);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(497, 104);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(77, 60);
            cboClientes.Margin = new Padding(5, 4, 5, 4);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(217, 28);
            cboClientes.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 69);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 21);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 3;
            label1.Text = "Fecha Desde:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(362, 21);
            dtpHasta.Margin = new Padding(5, 4, 5, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(109, 27);
            dtpHasta.TabIndex = 2;
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(107, 21);
            dtpDesde.Margin = new Padding(5, 4, 5, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(94, 27);
            dtpDesde.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.ForeColor = SystemColors.ActiveCaptionText;
            btnConsultar.Location = new Point(336, 68);
            btnConsultar.Margin = new Padding(5, 4, 5, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(136, 36);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(15, 529);
            btnBorrar.Margin = new Padding(5, 4, 5, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(112, 36);
            btnBorrar.TabIndex = 5;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(137, 29);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(317, 37);
            label4.TabIndex = 47;
            label4.Text = "CONSULTAR FACTURAS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(529, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // frmConsultarFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(638, 596);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnBorrar);
            Controls.Add(btnSalir);
            Controls.Add(dgvFacturas);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmConsultarFacturas";
            Text = "frmConsultarFacturas";
            Load += frmConsultarFacturas_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private DataGridView dgvFacturas;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Button btnConsultar;
        private ComboBox cboClientes;
        private Button btnBorrar;
        private DataGridViewTextBoxColumn colNro;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewButtonColumn ColAcciones;
        private Label label4;
        private PictureBox pictureBox1;
    }
}