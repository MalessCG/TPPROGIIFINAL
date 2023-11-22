namespace AutomotrizFront
{
    partial class FrmAutopartes
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
            btnCrear = new Button();
            txtStockAct = new TextBox();
            txtStockMin = new TextBox();
            label6 = new Label();
            lblPrecio = new Label();
            lblStockMax = new Label();
            lblStockMin = new Label();
            lblTipoA = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnCancelar = new Button();
            cboTipoA = new ComboBox();
            txtPrecio = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(270, 313);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(101, 47);
            btnCrear.TabIndex = 27;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtStockAct
            // 
            txtStockAct.Location = new Point(147, 256);
            txtStockAct.Margin = new Padding(3, 4, 3, 4);
            txtStockAct.Name = "txtStockAct";
            txtStockAct.Size = new Size(252, 27);
            txtStockAct.TabIndex = 26;
            txtStockAct.TextChanged += txtPrecio_TextChanged;
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new Point(147, 217);
            txtStockMin.Margin = new Padding(3, 4, 3, 4);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.Size = new Size(252, 27);
            txtStockMin.TabIndex = 24;
            txtStockMin.TextChanged += txtModelo_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(129, 12);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(270, 37);
            label6.TabIndex = 23;
            label6.Text = "NUEVA AUTOPARTE";
            label6.Click += label6_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.ForeColor = Color.Orange;
            lblPrecio.Location = new Point(26, 185);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 22;
            lblPrecio.Text = "Precio:";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // lblStockMax
            // 
            lblStockMax.AutoSize = true;
            lblStockMax.BackColor = Color.Transparent;
            lblStockMax.ForeColor = Color.Orange;
            lblStockMax.Location = new Point(26, 263);
            lblStockMax.Name = "lblStockMax";
            lblStockMax.Size = new Size(98, 20);
            lblStockMax.TabIndex = 21;
            lblStockMax.Text = "Stock  Actual:";
            lblStockMax.Click += lblModelo_Click;
            // 
            // lblStockMin
            // 
            lblStockMin.AutoSize = true;
            lblStockMin.BackColor = Color.Transparent;
            lblStockMin.ForeColor = Color.Orange;
            lblStockMin.Location = new Point(26, 224);
            lblStockMin.Name = "lblStockMin";
            lblStockMin.Size = new Size(103, 20);
            lblStockMin.TabIndex = 20;
            lblStockMin.Text = "Stock Minimo:";
            lblStockMin.Click += lblColor_Click;
            // 
            // lblTipoA
            // 
            lblTipoA.AutoSize = true;
            lblTipoA.BackColor = Color.Transparent;
            lblTipoA.ForeColor = Color.Orange;
            lblTipoA.Location = new Point(23, 140);
            lblTipoA.Name = "lblTipoA";
            lblTipoA.Size = new Size(113, 20);
            lblTipoA.TabIndex = 19;
            lblTipoA.Text = "Tipo Autoparte:";
            lblTipoA.Click += lblTipoV_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 95);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 18;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.Orange;
            lblNombre.Location = new Point(23, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(23, 313);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 47);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboTipoA
            // 
            cboTipoA.FormattingEnabled = true;
            cboTipoA.Location = new Point(147, 133);
            cboTipoA.Margin = new Padding(3, 4, 3, 4);
            cboTipoA.Name = "cboTipoA";
            cboTipoA.Size = new Size(252, 28);
            cboTipoA.TabIndex = 15;
            cboTipoA.SelectedIndexChanged += cboTipoV_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(147, 178);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(252, 27);
            txtPrecio.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(420, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // FrmAutopartes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(527, 427);
            Controls.Add(pictureBox1);
            Controls.Add(txtPrecio);
            Controls.Add(btnCrear);
            Controls.Add(txtStockAct);
            Controls.Add(txtStockMin);
            Controls.Add(label6);
            Controls.Add(lblPrecio);
            Controls.Add(lblStockMax);
            Controls.Add(lblStockMin);
            Controls.Add(lblTipoA);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(cboTipoA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAutopartes";
            Text = "FrmAutopartes";
            Load += FrmAutopartes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private TextBox txtStockAct;
        private TextBox txtStockMin;
        private Label label6;
        private Label lblPrecio;
        private Label lblStockMax;
        private Label lblStockMin;
        private Label lblTipoA;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnCancelar;
        private ComboBox cboTipoA;
        private TextBox txtPrecio;
        private PictureBox pictureBox1;
    }
}