namespace AutomotrizFront
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            autopartesToolStripMenuItem = new ToolStripMenuItem();
            grabarAutoparteToolStripMenuItem = new ToolStripMenuItem();
            consultarAutoparteToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            grabarVehiculoToolStripMenuItem = new ToolStripMenuItem();
            consultarVehiculoToolStripMenuItem = new ToolStripMenuItem();
            transaccionToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            nuevaFacturaToolStripMenuItem = new ToolStripMenuItem();
            consultarFacturaToolStripMenuItem = new ToolStripMenuItem();
            reporteToolStripMenuItem = new ToolStripMenuItem();
            acerdaDeToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, transaccionToolStripMenuItem, reporteToolStripMenuItem, acerdaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(770, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autopartesToolStripMenuItem, clientesToolStripMenuItem });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(76, 24);
            soporteToolStripMenuItem.Text = "Soporte";
            soporteToolStripMenuItem.Click += soporteToolStripMenuItem_Click;
            // 
            // autopartesToolStripMenuItem
            // 
            autopartesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grabarAutoparteToolStripMenuItem, consultarAutoparteToolStripMenuItem });
            autopartesToolStripMenuItem.Name = "autopartesToolStripMenuItem";
            autopartesToolStripMenuItem.Size = new Size(165, 26);
            autopartesToolStripMenuItem.Text = "Autopartes";
            autopartesToolStripMenuItem.Click += autopartesToolStripMenuItem_Click;
            // 
            // grabarAutoparteToolStripMenuItem
            // 
            grabarAutoparteToolStripMenuItem.Name = "grabarAutoparteToolStripMenuItem";
            grabarAutoparteToolStripMenuItem.Size = new Size(223, 26);
            grabarAutoparteToolStripMenuItem.Text = "Grabar autoparte";
            grabarAutoparteToolStripMenuItem.Click += grabarAutoparteToolStripMenuItem_Click;
            // 
            // consultarAutoparteToolStripMenuItem
            // 
            consultarAutoparteToolStripMenuItem.Name = "consultarAutoparteToolStripMenuItem";
            consultarAutoparteToolStripMenuItem.Size = new Size(223, 26);
            consultarAutoparteToolStripMenuItem.Text = "Consultar autoparte";
            consultarAutoparteToolStripMenuItem.Click += consultarAutoparteToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grabarVehiculoToolStripMenuItem, consultarVehiculoToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(165, 26);
            clientesToolStripMenuItem.Text = "Vehiculos";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // grabarVehiculoToolStripMenuItem
            // 
            grabarVehiculoToolStripMenuItem.Name = "grabarVehiculoToolStripMenuItem";
            grabarVehiculoToolStripMenuItem.Size = new Size(213, 26);
            grabarVehiculoToolStripMenuItem.Text = "Grabar vehiculo";
            grabarVehiculoToolStripMenuItem.Click += grabarVehiculoToolStripMenuItem_Click;
            // 
            // consultarVehiculoToolStripMenuItem
            // 
            consultarVehiculoToolStripMenuItem.Name = "consultarVehiculoToolStripMenuItem";
            consultarVehiculoToolStripMenuItem.Size = new Size(213, 26);
            consultarVehiculoToolStripMenuItem.Text = "Consultar vehiculo";
            consultarVehiculoToolStripMenuItem.Click += consultarVehiculoToolStripMenuItem_Click;
            // 
            // transaccionToolStripMenuItem
            // 
            transaccionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem });
            transaccionToolStripMenuItem.Name = "transaccionToolStripMenuItem";
            transaccionToolStripMenuItem.Size = new Size(100, 24);
            transaccionToolStripMenuItem.Text = "Transaccion";
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaFacturaToolStripMenuItem, consultarFacturaToolStripMenuItem });
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(139, 26);
            facturaToolStripMenuItem.Text = "Factura";
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            nuevaFacturaToolStripMenuItem.Size = new Size(211, 26);
            nuevaFacturaToolStripMenuItem.Text = "Nueva Factura";
            nuevaFacturaToolStripMenuItem.Click += nuevaFacturaToolStripMenuItem_Click;
            // 
            // consultarFacturaToolStripMenuItem
            // 
            consultarFacturaToolStripMenuItem.Name = "consultarFacturaToolStripMenuItem";
            consultarFacturaToolStripMenuItem.Size = new Size(211, 26);
            consultarFacturaToolStripMenuItem.Text = "Consultar Facturas";
            consultarFacturaToolStripMenuItem.Click += consultarFacturaToolStripMenuItem_Click;
            // 
            // reporteToolStripMenuItem
            // 
            reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            reporteToolStripMenuItem.Size = new Size(82, 24);
            reporteToolStripMenuItem.Text = "Reportes";
            // 
            // acerdaDeToolStripMenuItem
            // 
            acerdaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            acerdaDeToolStripMenuItem.Size = new Size(65, 24);
            acerdaDeToolStripMenuItem.Text = "Ayuda";
            acerdaDeToolStripMenuItem.Click += acerdaDeToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(158, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(300, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(770, 588);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem autopartesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem transaccionToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem nuevaFacturaToolStripMenuItem;
        private ToolStripMenuItem consultarFacturaToolStripMenuItem;
        private ToolStripMenuItem reporteToolStripMenuItem;
        private ToolStripMenuItem acerdaDeToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem grabarVehiculoToolStripMenuItem;
        private ToolStripMenuItem consultarVehiculoToolStripMenuItem;
        private ToolStripMenuItem grabarAutoparteToolStripMenuItem;
        private ToolStripMenuItem consultarAutoparteToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}