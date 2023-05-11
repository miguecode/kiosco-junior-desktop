namespace Vista
{
    partial class FrmPrincipal
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
            this.msp_Principal = new System.Windows.Forms.MenuStrip();
            this.smi_Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Producto = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Cuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.verDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Compras = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.sta_Datos = new System.Windows.Forms.StatusStrip();
            this.sbl_NombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbl_DniUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.msp_Principal.SuspendLayout();
            this.sta_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // msp_Principal
            // 
            this.msp_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(176)))));
            this.msp_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_Inicio,
            this.smi_Producto,
            this.smi_Cuenta,
            this.smi_Compras,
            this.smi_Usuarios,
            this.smi_Cerrar});
            this.msp_Principal.Location = new System.Drawing.Point(0, 0);
            this.msp_Principal.Name = "msp_Principal";
            this.msp_Principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msp_Principal.Size = new System.Drawing.Size(800, 40);
            this.msp_Principal.TabIndex = 4;
            this.msp_Principal.Text = "Menú Principal";
            // 
            // smi_Inicio
            // 
            this.smi_Inicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Inicio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Inicio.Name = "smi_Inicio";
            this.smi_Inicio.Size = new System.Drawing.Size(65, 36);
            this.smi_Inicio.Text = "Inicio";
            this.smi_Inicio.Click += new System.EventHandler(this.smi_Inicio_Click);
            // 
            // smi_Producto
            // 
            this.smi_Producto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosToolStripMenuItem,
            this.agregarProductosToolStripMenuItem});
            this.smi_Producto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Producto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Producto.Name = "smi_Producto";
            this.smi_Producto.Size = new System.Drawing.Size(92, 36);
            this.smi_Producto.Text = "Producto";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.verProductosToolStripMenuItem.Text = "Ver Productos";
            this.verProductosToolStripMenuItem.Click += new System.EventHandler(this.verProductosToolStripMenuItem_Click);
            // 
            // agregarProductosToolStripMenuItem
            // 
            this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            this.agregarProductosToolStripMenuItem.Click += new System.EventHandler(this.agregarProductosToolStripMenuItem_Click);
            // 
            // smi_Cuenta
            // 
            this.smi_Cuenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDatosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.smi_Cuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Cuenta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Cuenta.Name = "smi_Cuenta";
            this.smi_Cuenta.Size = new System.Drawing.Size(76, 36);
            this.smi_Cuenta.Text = "Cuenta";
            // 
            // verDatosToolStripMenuItem
            // 
            this.verDatosToolStripMenuItem.Name = "verDatosToolStripMenuItem";
            this.verDatosToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.verDatosToolStripMenuItem.Text = "Ver datos";
            this.verDatosToolStripMenuItem.Click += new System.EventHandler(this.verDatosToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // smi_Compras
            // 
            this.smi_Compras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Compras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.smi_Compras.Name = "smi_Compras";
            this.smi_Compras.Size = new System.Drawing.Size(89, 36);
            this.smi_Compras.Text = "Compras";
            this.smi_Compras.Visible = false;
            this.smi_Compras.Click += new System.EventHandler(this.smi_Compras_Click);
            // 
            // smi_Usuarios
            // 
            this.smi_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(202)))), ((int)(((byte)(51)))));
            this.smi_Usuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(202)))), ((int)(((byte)(51)))));
            this.smi_Usuarios.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.smi_Usuarios.Name = "smi_Usuarios";
            this.smi_Usuarios.Size = new System.Drawing.Size(150, 36);
            this.smi_Usuarios.Text = "Gestión Usuarios";
            this.smi_Usuarios.Visible = false;
            this.smi_Usuarios.Click += new System.EventHandler(this.smi_Usuarios_Click);
            // 
            // smi_Cerrar
            // 
            this.smi_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(44)))), ((int)(((byte)(13)))));
            this.smi_Cerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Cerrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Cerrar.Margin = new System.Windows.Forms.Padding(320, -2, 0, -2);
            this.smi_Cerrar.Name = "smi_Cerrar";
            this.smi_Cerrar.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.smi_Cerrar.Size = new System.Drawing.Size(90, 40);
            this.smi_Cerrar.Text = "Cerrar";
            this.smi_Cerrar.Click += new System.EventHandler(this.smi_Cerrar_Click);
            // 
            // sta_Datos
            // 
            this.sta_Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(176)))));
            this.sta_Datos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbl_NombreUsuario,
            this.sbl_DniUsuario});
            this.sta_Datos.Location = new System.Drawing.Point(0, 455);
            this.sta_Datos.Name = "sta_Datos";
            this.sta_Datos.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sta_Datos.Size = new System.Drawing.Size(800, 25);
            this.sta_Datos.SizingGrip = false;
            this.sta_Datos.TabIndex = 6;
            this.sta_Datos.Text = "Datos del usuario";
            // 
            // sbl_NombreUsuario
            // 
            this.sbl_NombreUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sbl_NombreUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sbl_NombreUsuario.Name = "sbl_NombreUsuario";
            this.sbl_NombreUsuario.Size = new System.Drawing.Size(139, 20);
            this.sbl_NombreUsuario.Text = "Nombre de Usuario";
            // 
            // sbl_DniUsuario
            // 
            this.sbl_DniUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sbl_DniUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sbl_DniUsuario.Margin = new System.Windows.Forms.Padding(25, 3, 0, 2);
            this.sbl_DniUsuario.Name = "sbl_DniUsuario";
            this.sbl_DniUsuario.Size = new System.Drawing.Size(101, 20);
            this.sbl_DniUsuario.Text = "DNI 00000000";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(234)))));
            this.BackgroundImage = global::Vista.Properties.Resources.inicioKiosco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.sta_Datos);
            this.Controls.Add(this.msp_Principal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msp_Principal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco Junior";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.msp_Principal.ResumeLayout(false);
            this.msp_Principal.PerformLayout();
            this.sta_Datos.ResumeLayout(false);
            this.sta_Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip msp_Principal;
        private ToolStripMenuItem smi_Producto;
        private ToolStripMenuItem smi_Inicio;
        private StatusStrip sta_Datos;
        private ToolStripStatusLabel sbl_NombreUsuario;
        private ToolStripMenuItem smi_Cerrar;
        private ToolStripMenuItem verProductosToolStripMenuItem;
        private ToolStripMenuItem agregarProductosToolStripMenuItem;
        private ToolStripMenuItem smi_Cuenta;
        private ToolStripMenuItem verDatosToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem smi_Usuarios;
        private ToolStripStatusLabel sbl_DniUsuario;
        private ToolStripMenuItem smi_Compras;
    }
}