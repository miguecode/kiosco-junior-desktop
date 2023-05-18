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
            this.smi_Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Compras = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Cuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.verDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.sta_Datos = new System.Windows.Forms.StatusStrip();
            this.sbl_NombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbl_DniUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl_Imagen = new System.Windows.Forms.Panel();
            this.pic_ImagenPrincipal = new System.Windows.Forms.PictureBox();
            this.msp_Principal.SuspendLayout();
            this.sta_Datos.SuspendLayout();
            this.pnl_Imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagenPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // msp_Principal
            // 
            this.msp_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.msp_Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.msp_Principal.GripMargin = new System.Windows.Forms.Padding(0);
            this.msp_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_Inicio,
            this.smi_Producto,
            this.smi_Ventas,
            this.smi_Compras,
            this.smi_Usuarios,
            this.smi_Cuenta,
            this.smi_Cerrar});
            this.msp_Principal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msp_Principal.Location = new System.Drawing.Point(0, 0);
            this.msp_Principal.Name = "msp_Principal";
            this.msp_Principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msp_Principal.Size = new System.Drawing.Size(800, 41);
            this.msp_Principal.TabIndex = 4;
            this.msp_Principal.Text = "Menú Principal";
            // 
            // smi_Inicio
            // 
            this.smi_Inicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Inicio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Inicio.Name = "smi_Inicio";
            this.smi_Inicio.Size = new System.Drawing.Size(65, 37);
            this.smi_Inicio.Text = "Inicio";
            this.smi_Inicio.Click += new System.EventHandler(this.smi_Inicio_Click);
            // 
            // smi_Producto
            // 
            this.smi_Producto.Checked = true;
            this.smi_Producto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smi_Producto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Producto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Producto.Name = "smi_Producto";
            this.smi_Producto.Size = new System.Drawing.Size(99, 37);
            this.smi_Producto.Text = "Productos";
            this.smi_Producto.Click += new System.EventHandler(this.smi_Producto_Click);
            // 
            // smi_Ventas
            // 
            this.smi_Ventas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Ventas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Ventas.Name = "smi_Ventas";
            this.smi_Ventas.Padding = new System.Windows.Forms.Padding(0);
            this.smi_Ventas.Size = new System.Drawing.Size(65, 37);
            this.smi_Ventas.Text = "Ventas";
            this.smi_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.smi_Ventas.Click += new System.EventHandler(this.smi_Ventas_Click);
            // 
            // smi_Compras
            // 
            this.smi_Compras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Compras.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Compras.Name = "smi_Compras";
            this.smi_Compras.Size = new System.Drawing.Size(89, 37);
            this.smi_Compras.Text = "Compras";
            this.smi_Compras.Visible = false;
            this.smi_Compras.Click += new System.EventHandler(this.smi_Compras_Click);
            // 
            // smi_Usuarios
            // 
            this.smi_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.smi_Usuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Usuarios.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Usuarios.ImageTransparentColor = System.Drawing.Color.MediumPurple;
            this.smi_Usuarios.Name = "smi_Usuarios";
            this.smi_Usuarios.Size = new System.Drawing.Size(150, 37);
            this.smi_Usuarios.Text = "Gestión Usuarios";
            this.smi_Usuarios.Visible = false;
            this.smi_Usuarios.Click += new System.EventHandler(this.smi_Usuarios_Click);
            // 
            // smi_Cuenta
            // 
            this.smi_Cuenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDatosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.smi_Cuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Cuenta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Cuenta.Name = "smi_Cuenta";
            this.smi_Cuenta.Size = new System.Drawing.Size(76, 37);
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
            // smi_Cerrar
            // 
            this.smi_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.smi_Cerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Cerrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Cerrar.Name = "smi_Cerrar";
            this.smi_Cerrar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.smi_Cerrar.Size = new System.Drawing.Size(60, 37);
            this.smi_Cerrar.Text = "Cerrar";
            this.smi_Cerrar.Click += new System.EventHandler(this.smi_Cerrar_Click);
            // 
            // sta_Datos
            // 
            this.sta_Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.sta_Datos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbl_NombreUsuario,
            this.sbl_DniUsuario});
            this.sta_Datos.Location = new System.Drawing.Point(0, 455);
            this.sta_Datos.Name = "sta_Datos";
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
            // pnl_Imagen
            // 
            this.pnl_Imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnl_Imagen.Controls.Add(this.pic_ImagenPrincipal);
            this.pnl_Imagen.Location = new System.Drawing.Point(0, 38);
            this.pnl_Imagen.Name = "pnl_Imagen";
            this.pnl_Imagen.Size = new System.Drawing.Size(800, 417);
            this.pnl_Imagen.TabIndex = 7;
            // 
            // pic_ImagenPrincipal
            // 
            this.pic_ImagenPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_ImagenPrincipal.Image = global::Vista.Properties.Resources.mercado;
            this.pic_ImagenPrincipal.Location = new System.Drawing.Point(120, 65);
            this.pic_ImagenPrincipal.Name = "pic_ImagenPrincipal";
            this.pic_ImagenPrincipal.Size = new System.Drawing.Size(564, 282);
            this.pic_ImagenPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ImagenPrincipal.TabIndex = 0;
            this.pic_ImagenPrincipal.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Imagen);
            this.Controls.Add(this.sta_Datos);
            this.Controls.Add(this.msp_Principal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.pnl_Imagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagenPrincipal)).EndInit();
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
        private ToolStripMenuItem smi_Cuenta;
        private ToolStripMenuItem verDatosToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem smi_Usuarios;
        private ToolStripStatusLabel sbl_DniUsuario;
        private ToolStripMenuItem smi_Compras;
        private ToolStripMenuItem smi_Ventas;
        private Panel pnl_Imagen;
        private PictureBox pic_ImagenPrincipal;
    }
}