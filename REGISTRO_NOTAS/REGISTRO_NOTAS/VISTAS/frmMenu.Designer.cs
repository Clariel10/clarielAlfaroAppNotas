namespace REGISTRO_NOTAS.VISTAS
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.pbMinimizar);
            this.panel1.Controls.Add(this.pbCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 35);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::REGISTRO_NOTAS.Properties.Resources.reloj;
            this.pictureBox2.Location = new System.Drawing.Point(143, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(50, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "label1";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::REGISTRO_NOTAS.Properties.Resources.calendario;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(184, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 16);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "label1";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Image = global::REGISTRO_NOTAS.Properties.Resources.minimizar;
            this.pbMinimizar.Location = new System.Drawing.Point(985, 12);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(35, 10);
            this.pbMinimizar.TabIndex = 1;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Image = global::REGISTRO_NOTAS.Properties.Resources.cerrar;
            this.pbCerrar.Location = new System.Drawing.Point(1037, 2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(30, 30);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeEstudiantesToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.registroDeNotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoDeEstudiantesToolStripMenuItem
            // 
            this.ingresoDeEstudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeEstudiantesToolStripMenuItem});
            this.ingresoDeEstudiantesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoDeEstudiantesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.ingresoDeEstudiantesToolStripMenuItem.Name = "ingresoDeEstudiantesToolStripMenuItem";
            this.ingresoDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ingresoDeEstudiantesToolStripMenuItem.Text = "Registro de Estudiantes";
            this.ingresoDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeEstudiantesToolStripMenuItem_Click);
            // 
            // datosDeEstudiantesToolStripMenuItem
            // 
            this.datosDeEstudiantesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.datosDeEstudiantesToolStripMenuItem.Name = "datosDeEstudiantesToolStripMenuItem";
            this.datosDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.datosDeEstudiantesToolStripMenuItem.Text = "Datos de Estudiantes";
            this.datosDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.datosDeEstudiantesToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.materiasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiasToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // registroDeNotasToolStripMenuItem
            // 
            this.registroDeNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notasDeEstudiantesToolStripMenuItem});
            this.registroDeNotasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroDeNotasToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.registroDeNotasToolStripMenuItem.Name = "registroDeNotasToolStripMenuItem";
            this.registroDeNotasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.registroDeNotasToolStripMenuItem.Text = "Ingreso de Notas";
            // 
            // notasDeEstudiantesToolStripMenuItem
            // 
            this.notasDeEstudiantesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkCyan;
            this.notasDeEstudiantesToolStripMenuItem.Name = "notasDeEstudiantesToolStripMenuItem";
            this.notasDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.notasDeEstudiantesToolStripMenuItem.Text = "Notas de Estudiantes";
            this.notasDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.notasDeEstudiantesToolStripMenuItem_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.Location = new System.Drawing.Point(0, 67);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1059, 633);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 698);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}