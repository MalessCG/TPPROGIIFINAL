namespace AutomotrizFront
{
    partial class FrmVehiculos
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
            cboTipoV = new ComboBox();
            btnCancelar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTipoV = new Label();
            lblColor = new Label();
            lblModelo = new Label();
            lblPrecio = new Label();
            label6 = new Label();
            txtModelo = new TextBox();
            cboColor = new ComboBox();
            txtPrecio = new TextBox();
            btnCrear = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cboTipoV
            // 
            cboTipoV.FormattingEnabled = true;
            cboTipoV.Location = new Point(107, 132);
            cboTipoV.Margin = new Padding(3, 4, 3, 4);
            cboTipoV.Name = "cboTipoV";
            cboTipoV.Size = new Size(252, 28);
            cboTipoV.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(13, 309);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 47);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.Orange;
            lblNombre.Location = new Point(13, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 93);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblTipoV
            // 
            lblTipoV.AutoSize = true;
            lblTipoV.BackColor = Color.Transparent;
            lblTipoV.ForeColor = Color.Orange;
            lblTipoV.Location = new Point(13, 136);
            lblTipoV.Name = "lblTipoV";
            lblTipoV.Size = new Size(101, 20);
            lblTipoV.TabIndex = 4;
            lblTipoV.Text = "Tipo vehiculo:";
            lblTipoV.Click += lblTipoV_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.BackColor = Color.Transparent;
            lblColor.ForeColor = Color.Orange;
            lblColor.Location = new Point(13, 181);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(48, 20);
            lblColor.TabIndex = 5;
            lblColor.Text = "Color:";
            lblColor.Click += label2_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Transparent;
            lblModelo.ForeColor = Color.Orange;
            lblModelo.Location = new Point(13, 220);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(64, 20);
            lblModelo.TabIndex = 6;
            lblModelo.Text = "Modelo:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.ForeColor = Color.Orange;
            lblPrecio.Location = new Point(14, 259);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(138, 8);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(249, 37);
            label6.TabIndex = 9;
            label6.Text = "NUEVO VEHICULO";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(107, 216);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(252, 27);
            txtModelo.TabIndex = 11;
            txtModelo.TextChanged += textBox1_TextChanged;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(107, 177);
            cboColor.Margin = new Padding(3, 4, 3, 4);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(252, 28);
            cboColor.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 255);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(252, 27);
            txtPrecio.TabIndex = 13;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(259, 309);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(101, 47);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += Crear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(411, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // FrmVehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 377);
            Controls.Add(pictureBox1);
            Controls.Add(btnCrear);
            Controls.Add(txtPrecio);
            Controls.Add(cboColor);
            Controls.Add(txtModelo);
            Controls.Add(label6);
            Controls.Add(lblPrecio);
            Controls.Add(lblModelo);
            Controls.Add(lblColor);
            Controls.Add(lblTipoV);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(cboTipoV);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVehiculos";
            Text = "FrmVehiculos";
            Load += FrmVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTipoV;
        private Button btnCancelar;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTipoV;
        private Label lblColor;
        private Label lblModelo;
        private Label lblPrecio;
        private Label label6;
        private TextBox txtModelo;
        private ComboBox cboColor;
        private TextBox txtPrecio;
        private Button btnCrear;
        private PictureBox pictureBox1;
    }
}