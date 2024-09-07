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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            msp_Principal = new MenuStrip();
            smi_Inicio = new ToolStripMenuItem();
            smi_Producto = new ToolStripMenuItem();
            smi_Ventas = new ToolStripMenuItem();
            smi_Compras = new ToolStripMenuItem();
            smi_Usuarios = new ToolStripMenuItem();
            smi_Informes = new ToolStripMenuItem();
            smi_Registros = new ToolStripMenuItem();
            smi_Cuenta = new ToolStripMenuItem();
            tsm_VerDatos = new ToolStripMenuItem();
            tsm_CerrarSesion = new ToolStripMenuItem();
            smi_Cerrar = new ToolStripMenuItem();
            sta_Datos = new StatusStrip();
            sbl_NombreUsuario = new ToolStripStatusLabel();
            sbl_DniUsuario = new ToolStripStatusLabel();
            sbl_RolUsuario = new ToolStripStatusLabel();
            pan_Inicio = new Panel();
            lbl_Kiosco = new Label();
            lbl_Fecha = new Label();
            lbl_Horario = new Label();
            pic_ImagenPrincipal = new PictureBox();
            tim_HoraYFecha = new System.Windows.Forms.Timer(components);
            msp_Principal.SuspendLayout();
            sta_Datos.SuspendLayout();
            pan_Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ImagenPrincipal).BeginInit();
            SuspendLayout();
            // 
            // msp_Principal
            // 
            msp_Principal.BackColor = Color.FromArgb(24, 75, 171);
            msp_Principal.BackgroundImageLayout = ImageLayout.None;
            msp_Principal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            msp_Principal.GripMargin = new Padding(0);
            msp_Principal.Items.AddRange(new ToolStripItem[] { smi_Inicio, smi_Producto, smi_Ventas, smi_Compras, smi_Usuarios, smi_Informes, smi_Registros, smi_Cuenta, smi_Cerrar });
            msp_Principal.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            msp_Principal.Location = new Point(0, 0);
            msp_Principal.Name = "msp_Principal";
            msp_Principal.Padding = new Padding(6, 0, 0, 2);
            msp_Principal.RenderMode = ToolStripRenderMode.System;
            msp_Principal.Size = new Size(800, 39);
            msp_Principal.TabIndex = 4;
            msp_Principal.Text = "Menú Principal";
            // 
            // smi_Inicio
            // 
            smi_Inicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            smi_Inicio.ForeColor = SystemColors.HighlightText;
            smi_Inicio.Name = "smi_Inicio";
            smi_Inicio.Size = new Size(65, 37);
            smi_Inicio.Text = "Inicio";
            smi_Inicio.Click += smi_Inicio_Click;
            // 
            // smi_Producto
            // 
            smi_Producto.Checked = true;
            smi_Producto.CheckState = CheckState.Checked;
            smi_Producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            smi_Producto.ForeColor = SystemColors.HighlightText;
            smi_Producto.ImageScaling = ToolStripItemImageScaling.None;
            smi_Producto.Name = "smi_Producto";
            smi_Producto.RightToLeft = RightToLeft.No;
            smi_Producto.Size = new Size(99, 37);
            smi_Producto.Text = "Productos";
            smi_Producto.Click += smi_Producto_Click;
            // 
            // smi_Ventas
            // 
            smi_Ventas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            smi_Ventas.ForeColor = SystemColors.HighlightText;
            smi_Ventas.Name = "smi_Ventas";
            smi_Ventas.Padding = new Padding(0);
            smi_Ventas.Size = new Size(65, 37);
            smi_Ventas.Text = "Ventas";
            smi_Ventas.TextAlign = ContentAlignment.MiddleRight;
            smi_Ventas.Click += smi_Ventas_Click;
            // 
            // smi_Compras
            // 
            smi_Compras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            smi_Compras.ForeColor = SystemColors.HighlightText;
            smi_Compras.Name = "smi_Compras";
            smi_Compras.Size = new Size(89, 37);
            smi_Compras.Text = "Compras";
            smi_Compras.Visible = false;
            smi_Compras.Click += smi_Compras_Click;
            // 
            // smi_Usuarios
            // 
            smi_Usuarios.BackColor = Color.FromArgb(24, 75, 171);
            smi_Usuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            smi_Usuarios.ForeColor = SystemColors.HighlightText;
            smi_Usuarios.ImageTransparentColor = Color.MediumPurple;
            smi_Usuarios.Name = "smi_Usuarios";
            smi_Usuarios.Size = new Size(150, 37);
            smi_Usuarios.Text = "Gestión Usuarios";
            smi_Usuarios.Visible = false;
            smi_Usuarios.Click += smi_Usuarios_Click;
            // 
            // smi_Informes
            // 
            smi_Informes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            smi_Informes.ForeColor = SystemColors.HighlightText;
            smi_Informes.Name = "smi_Informes";
            smi_Informes.Size = new Size(90, 37);
            smi_Informes.Text = "Informes";
            smi_Informes.Visible = false;
            smi_Informes.Click += smi_Informes_Click;
            // 
            // smi_Registros
            // 
            smi_Registros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            smi_Registros.ForeColor = SystemColors.HighlightText;
            smi_Registros.Name = "smi_Registros";
            smi_Registros.Size = new Size(92, 37);
            smi_Registros.Text = "Registros";
            smi_Registros.Visible = false;
            smi_Registros.Click += smi_Registros_Click;
            // 
            // smi_Cuenta
            // 
            smi_Cuenta.DropDownItems.AddRange(new ToolStripItem[] { tsm_VerDatos, tsm_CerrarSesion });
            smi_Cuenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            smi_Cuenta.ForeColor = SystemColors.HighlightText;
            smi_Cuenta.Name = "smi_Cuenta";
            smi_Cuenta.Size = new Size(76, 37);
            smi_Cuenta.Text = "Cuenta";
            // 
            // tsm_VerDatos
            // 
            tsm_VerDatos.Name = "tsm_VerDatos";
            tsm_VerDatos.Size = new Size(178, 26);
            tsm_VerDatos.Text = "Ver datos";
            tsm_VerDatos.Click += tsm_VerDatos_Click;
            // 
            // tsm_CerrarSesion
            // 
            tsm_CerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tsm_CerrarSesion.Name = "tsm_CerrarSesion";
            tsm_CerrarSesion.Size = new Size(178, 26);
            tsm_CerrarSesion.Text = "Cerrar sesión";
            tsm_CerrarSesion.Click += tsm_CerrarSesion_Click;
            // 
            // smi_Cerrar
            // 
            smi_Cerrar.Alignment = ToolStripItemAlignment.Right;
            smi_Cerrar.BackColor = Color.FromArgb(24, 75, 171);
            smi_Cerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            smi_Cerrar.ForeColor = SystemColors.HighlightText;
            smi_Cerrar.Margin = new Padding(0, 0, 5, 0);
            smi_Cerrar.Name = "smi_Cerrar";
            smi_Cerrar.Padding = new Padding(0, 0, 0, 12);
            smi_Cerrar.Size = new Size(60, 37);
            smi_Cerrar.Text = "Cerrar";
            smi_Cerrar.Click += smi_Cerrar_Click;
            // 
            // sta_Datos
            // 
            sta_Datos.BackColor = Color.FromArgb(24, 75, 171);
            sta_Datos.Items.AddRange(new ToolStripItem[] { sbl_NombreUsuario, sbl_DniUsuario, sbl_RolUsuario });
            sta_Datos.Location = new Point(0, 455);
            sta_Datos.Name = "sta_Datos";
            sta_Datos.Size = new Size(800, 25);
            sta_Datos.SizingGrip = false;
            sta_Datos.TabIndex = 6;
            sta_Datos.Text = "Datos del usuario";
            // 
            // sbl_NombreUsuario
            // 
            sbl_NombreUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            sbl_NombreUsuario.ForeColor = SystemColors.HighlightText;
            sbl_NombreUsuario.Margin = new Padding(10, 3, 0, 2);
            sbl_NombreUsuario.Name = "sbl_NombreUsuario";
            sbl_NombreUsuario.Size = new Size(146, 20);
            sbl_NombreUsuario.Text = "Nombre de Usuario";
            // 
            // sbl_DniUsuario
            // 
            sbl_DniUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sbl_DniUsuario.ForeColor = SystemColors.HighlightText;
            sbl_DniUsuario.Margin = new Padding(25, 3, 0, 2);
            sbl_DniUsuario.Name = "sbl_DniUsuario";
            sbl_DniUsuario.Size = new Size(101, 20);
            sbl_DniUsuario.Text = "DNI 00000000";
            // 
            // sbl_RolUsuario
            // 
            sbl_RolUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sbl_RolUsuario.ForeColor = SystemColors.HighlightText;
            sbl_RolUsuario.Margin = new Padding(400, 3, 0, 2);
            sbl_RolUsuario.Name = "sbl_RolUsuario";
            sbl_RolUsuario.Size = new Size(106, 20);
            sbl_RolUsuario.Text = "Rol de Usuario";
            // 
            // pan_Inicio
            // 
            pan_Inicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pan_Inicio.BackColor = Color.FromArgb(26, 26, 26);
            pan_Inicio.Controls.Add(lbl_Kiosco);
            pan_Inicio.Controls.Add(lbl_Fecha);
            pan_Inicio.Controls.Add(lbl_Horario);
            pan_Inicio.Controls.Add(pic_ImagenPrincipal);
            pan_Inicio.Location = new Point(0, 42);
            pan_Inicio.Name = "pan_Inicio";
            pan_Inicio.Size = new Size(800, 410);
            pan_Inicio.TabIndex = 7;
            // 
            // lbl_Kiosco
            // 
            lbl_Kiosco.AutoSize = true;
            lbl_Kiosco.Font = new Font("Dosis", 35.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Kiosco.ForeColor = Color.White;
            lbl_Kiosco.Location = new Point(461, 43);
            lbl_Kiosco.Name = "lbl_Kiosco";
            lbl_Kiosco.Size = new Size(279, 61);
            lbl_Kiosco.TabIndex = 3;
            lbl_Kiosco.Text = "Kiosco Junior";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Fecha.ForeColor = Color.White;
            lbl_Fecha.Location = new Point(23, 149);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(437, 54);
            lbl_Fecha.TabIndex = 2;
            lbl_Fecha.Text = "28 de Septiembre 2024";
            // 
            // lbl_Horario
            // 
            lbl_Horario.AutoSize = true;
            lbl_Horario.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Horario.ForeColor = Color.White;
            lbl_Horario.Location = new Point(12, 43);
            lbl_Horario.Name = "lbl_Horario";
            lbl_Horario.Size = new Size(234, 106);
            lbl_Horario.TabIndex = 1;
            lbl_Horario.Text = "00:00";
            // 
            // pic_ImagenPrincipal
            // 
            pic_ImagenPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            pic_ImagenPrincipal.Image = Properties.Resources.tienda;
            pic_ImagenPrincipal.Location = new Point(451, 107);
            pic_ImagenPrincipal.Name = "pic_ImagenPrincipal";
            pic_ImagenPrincipal.Size = new Size(301, 246);
            pic_ImagenPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ImagenPrincipal.TabIndex = 0;
            pic_ImagenPrincipal.TabStop = false;
            // 
            // tim_HoraYFecha
            // 
            tim_HoraYFecha.Enabled = true;
            tim_HoraYFecha.Tick += tim_HoraYFecha_Tick;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 480);
            ControlBox = false;
            Controls.Add(pan_Inicio);
            Controls.Add(sta_Datos);
            Controls.Add(msp_Principal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msp_Principal;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiosco Junior";
            Load += FrmPrincipal_Load;
            msp_Principal.ResumeLayout(false);
            msp_Principal.PerformLayout();
            sta_Datos.ResumeLayout(false);
            sta_Datos.PerformLayout();
            pan_Inicio.ResumeLayout(false);
            pan_Inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ImagenPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip msp_Principal;
        private ToolStripMenuItem smi_Producto;
        private ToolStripMenuItem smi_Inicio;
        private StatusStrip sta_Datos;
        private ToolStripStatusLabel sbl_NombreUsuario;
        private ToolStripMenuItem smi_Cerrar;
        private ToolStripMenuItem smi_Cuenta;
        private ToolStripMenuItem tsm_CerrarSesion;
        private ToolStripMenuItem smi_Usuarios;
        private ToolStripStatusLabel sbl_DniUsuario;
        private ToolStripMenuItem smi_Compras;
        private Panel pan_Inicio;
        private PictureBox pic_ImagenPrincipal;
        private ToolStripMenuItem tsm_VerDatos;
        private ToolStripStatusLabel sbl_RolUsuario;
        private Label lbl_Fecha;
        private Label lbl_Horario;
        private Label lbl_Kiosco;
        private System.Windows.Forms.Timer tim_HoraYFecha;
        private ToolStripMenuItem smi_Ventas;
        private ToolStripMenuItem smi_Informes;
        private ToolStripMenuItem smi_Registros;
    }
}