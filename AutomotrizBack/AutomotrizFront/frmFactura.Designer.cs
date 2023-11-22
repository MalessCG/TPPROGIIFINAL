namespace AutomotrizFront
{
    partial class frmFactura
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
            label3 = new Label();
            cboAutoparte = new ComboBox();
            btnAgregar = new Button();
            dgvDetalles = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colAutoparte = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            ColSubtotal = new DataGridViewTextBoxColumn();
            acciones = new DataGridViewButtonColumn();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            nudCantidad = new NumericUpDown();
            label5 = new Label();
            cboClientes = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(19, 97);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 30;
            label3.Text = "Cliente:";
            // 
            // cboAutoparte
            // 
            cboAutoparte.FormattingEnabled = true;
            cboAutoparte.Location = new Point(15, 192);
            cboAutoparte.Margin = new Padding(5, 4, 5, 4);
            cboAutoparte.Name = "cboAutoparte";
            cboAutoparte.Size = new Size(323, 28);
            cboAutoparte.TabIndex = 28;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(551, 192);
            btnAgregar.Margin = new Padding(5, 4, 5, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 36);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colId, colAutoparte, colPrecio, colCantidad, ColSubtotal, acciones });
            dgvDetalles.Location = new Point(7, 236);
            dgvDetalles.Margin = new Padding(5, 4, 5, 4);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new Size(674, 229);
            dgvDetalles.TabIndex = 35;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 10;
            // 
            // colAutoparte
            // 
            colAutoparte.HeaderText = "Autoparte";
            colAutoparte.MinimumWidth = 6;
            colAutoparte.Name = "colAutoparte";
            colAutoparte.ReadOnly = true;
            colAutoparte.Width = 150;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 125;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 75;
            // 
            // ColSubtotal
            // 
            ColSubtotal.HeaderText = "Subtotal";
            ColSubtotal.MinimumWidth = 6;
            ColSubtotal.Name = "ColSubtotal";
            ColSubtotal.ReadOnly = true;
            ColSubtotal.Width = 125;
            // 
            // acciones
            // 
            acciones.HeaderText = "Acciones";
            acciones.MinimumWidth = 6;
            acciones.Name = "acciones";
            acciones.ReadOnly = true;
            acciones.Text = "Quitar";
            acciones.UseColumnTextForButtonValue = true;
            acciones.Width = 110;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(238, 496);
            btnAceptar.Margin = new Padding(5, 4, 5, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(101, 36);
            btnAceptar.TabIndex = 34;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(343, 496);
            btnCancelar.Margin = new Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 36);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(19, 52);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 36;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(15, 173);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 37;
            label1.Text = "Autoparte:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(80, 52);
            dtpFecha.Margin = new Padding(5, 4, 5, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(143, 27);
            dtpFecha.TabIndex = 39;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(459, 196);
            nudCantidad.Margin = new Padding(2, 3, 2, 3);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(85, 27);
            nudCantidad.TabIndex = 40;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(459, 173);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 41;
            label5.Text = "Cantidad:";
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(80, 91);
            cboClientes.Margin = new Padding(5, 4, 5, 4);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(323, 28);
            cboClientes.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(551, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(691, 552);
            Controls.Add(pictureBox1);
            Controls.Add(cboClientes);
            Controls.Add(label5);
            Controls.Add(nudCantidad);
            Controls.Add(dtpFecha);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvDetalles);
            Controls.Add(btnAgregar);
            Controls.Add(cboAutoparte);
            Controls.Add(label3);
            Controls.Add(label1);
            Cursor = Cursors.Default;
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFactura";
            Text = "    ";
            Load += frmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cboAutoparte;
        private Button btnAgregar;
        private DataGridView dgvDetalles;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFecha;
        private NumericUpDown nudCantidad;
        private Label label5;
        private ComboBox cboClientes;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colAutoparte;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn ColSubtotal;
        private DataGridViewButtonColumn acciones;
        private PictureBox pictureBox1;
    }
}