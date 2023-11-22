namespace AutomotrizFront
{
    partial class FrmEditarVehiculo
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
            btnEditar = new Button();
            txtPrecio = new TextBox();
            cboColor = new ComboBox();
            txtModelo = new TextBox();
            label6 = new Label();
            lblPrecio = new Label();
            lblModelo = new Label();
            lblColor = new Label();
            lblTipoV = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnCancelar = new Button();
            cboTipoV = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(262, 313);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 47);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(110, 259);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(252, 27);
            txtPrecio.TabIndex = 26;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(110, 181);
            cboColor.Margin = new Padding(3, 4, 3, 4);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(252, 28);
            cboColor.TabIndex = 25;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(110, 220);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(252, 27);
            txtModelo.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(141, 12);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(250, 37);
            label6.TabIndex = 23;
            label6.Text = "EDITAR VEHICULO";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.ForeColor = Color.Orange;
            lblPrecio.Location = new Point(16, 263);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 22;
            lblPrecio.Text = "Precio:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.BackColor = Color.Transparent;
            lblModelo.ForeColor = Color.Orange;
            lblModelo.Location = new Point(15, 224);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(64, 20);
            lblModelo.TabIndex = 21;
            lblModelo.Text = "Modelo:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.BackColor = Color.Transparent;
            lblColor.ForeColor = Color.Orange;
            lblColor.Location = new Point(15, 185);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(48, 20);
            lblColor.TabIndex = 20;
            lblColor.Text = "Color:";
            // 
            // lblTipoV
            // 
            lblTipoV.AutoSize = true;
            lblTipoV.BackColor = Color.Transparent;
            lblTipoV.ForeColor = Color.Orange;
            lblTipoV.Location = new Point(15, 140);
            lblTipoV.Name = "lblTipoV";
            lblTipoV.Size = new Size(101, 20);
            lblTipoV.TabIndex = 19;
            lblTipoV.Text = "Tipo vehiculo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 97);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 18;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.Orange;
            lblNombre.Location = new Point(15, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(15, 313);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 47);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboTipoV
            // 
            cboTipoV.FormattingEnabled = true;
            cboTipoV.Location = new Point(110, 136);
            cboTipoV.Margin = new Padding(3, 4, 3, 4);
            cboTipoV.Name = "cboTipoV";
            cboTipoV.Size = new Size(252, 28);
            cboTipoV.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(397, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // FrmEditarVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(519, 383);
            Controls.Add(pictureBox1);
            Controls.Add(btnEditar);
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
            Name = "FrmEditarVehiculo";
            Text = "FrmEditarVehiculo";
            Load += FrmEditarVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private TextBox txtPrecio;
        private ComboBox cboColor;
        private TextBox txtModelo;
        private Label label6;
        private Label lblPrecio;
        private Label lblModelo;
        private Label lblColor;
        private Label lblTipoV;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnCancelar;
        private ComboBox cboTipoV;
        private PictureBox pictureBox1;
    }
}