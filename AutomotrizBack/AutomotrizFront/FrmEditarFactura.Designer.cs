namespace AutomotrizFront
{
    partial class FrmEditarFactura
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
            cboClientes = new ComboBox();
            label5 = new Label();
            nudCantidad = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            dgvDetalles = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colAutoparte = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            ColSubtotal = new DataGridViewTextBoxColumn();
            acciones = new DataGridViewButtonColumn();
            btnAgregar = new Button();
            cboAutoparte = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(80, 103);
            cboClientes.Margin = new Padding(5, 4, 5, 4);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(323, 28);
            cboClientes.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(467, 151);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 53;
            label5.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(467, 173);
            nudCantidad.Margin = new Padding(2, 3, 2, 3);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(85, 27);
            nudCantidad.TabIndex = 52;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(80, 64);
            dtpFecha.Margin = new Padding(5, 4, 5, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(143, 27);
            dtpFecha.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(19, 64);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 49;
            label2.Text = "Fecha:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(351, 473);
            btnCancelar.Margin = new Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 36);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(246, 473);
            btnAceptar.Margin = new Padding(5, 4, 5, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(101, 36);
            btnAceptar.TabIndex = 47;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colId, colAutoparte, colPrecio, colCantidad, ColSubtotal, acciones });
            dgvDetalles.Location = new Point(15, 213);
            dgvDetalles.Margin = new Padding(5, 4, 5, 4);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new Size(674, 229);
            dgvDetalles.TabIndex = 48;
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
            // btnAgregar
            // 
            btnAgregar.Location = new Point(559, 169);
            btnAgregar.Margin = new Padding(5, 4, 5, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 36);
            btnAgregar.TabIndex = 46;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboAutoparte
            // 
            cboAutoparte.FormattingEnabled = true;
            cboAutoparte.Location = new Point(15, 173);
            cboAutoparte.Margin = new Padding(5, 4, 5, 4);
            cboAutoparte.Name = "cboAutoparte";
            cboAutoparte.Size = new Size(323, 28);
            cboAutoparte.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(19, 109);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 44;
            label3.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(15, 149);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 50;
            label1.Text = "Autoparte:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(202, 9);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(240, 37);
            label6.TabIndex = 55;
            label6.Text = "EDITAR FACTURA";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(559, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // FrmEditarFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(697, 540);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEditarFactura";
            Text = "FrmEditarFactura";
            Load += FrmEditarFactura_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboClientes;
        private Label label5;
        private NumericUpDown nudCantidad;
        private DateTimePicker dtpFecha;
        private Label label2;
        private Button btnCancelar;
        private Button btnAceptar;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colAutoparte;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn ColSubtotal;
        private DataGridViewButtonColumn acciones;
        private Button btnAgregar;
        private ComboBox cboAutoparte;
        private Label label3;
        private Label label1;
        private Label label6;
        private PictureBox pictureBox1;
    }
}