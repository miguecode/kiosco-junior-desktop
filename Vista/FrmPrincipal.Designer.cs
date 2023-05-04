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
            this.smi_Cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.sta_Datos = new System.Windows.Forms.StatusStrip();
            this.sbl_NombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.smi_Cerrar});
            this.msp_Principal.Location = new System.Drawing.Point(0, 0);
            this.msp_Principal.Name = "msp_Principal";
            this.msp_Principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msp_Principal.Size = new System.Drawing.Size(800, 38);
            this.msp_Principal.TabIndex = 4;
            this.msp_Principal.Text = "Menú Principal";
            // 
            // smi_Inicio
            // 
            this.smi_Inicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Inicio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Inicio.Name = "smi_Inicio";
            this.smi_Inicio.Size = new System.Drawing.Size(57, 34);
            this.smi_Inicio.Text = "Inicio";
            this.smi_Inicio.Click += new System.EventHandler(this.smi_Inicio_Click);
            // 
            // smi_Producto
            // 
            this.smi_Producto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosToolStripMenuItem,
            this.agregarProductosToolStripMenuItem});
            this.smi_Producto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Producto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Producto.Name = "smi_Producto";
            this.smi_Producto.Size = new System.Drawing.Size(83, 34);
            this.smi_Producto.Text = "Producto";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.verProductosToolStripMenuItem.Text = "Ver Productos";
            this.verProductosToolStripMenuItem.Click += new System.EventHandler(this.verProductosToolStripMenuItem_Click);
            // 
            // agregarProductosToolStripMenuItem
            // 
            this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            this.agregarProductosToolStripMenuItem.Click += new System.EventHandler(this.agregarProductosToolStripMenuItem_Click);
            // 
            // smi_Cerrar
            // 
            this.smi_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(44)))), ((int)(((byte)(13)))));
            this.smi_Cerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.smi_Cerrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.smi_Cerrar.Margin = new System.Windows.Forms.Padding(531, -2, 0, -2);
            this.smi_Cerrar.Name = "smi_Cerrar";
            this.smi_Cerrar.Padding = new System.Windows.Forms.Padding(15, 0, 4, 15);
            this.smi_Cerrar.Size = new System.Drawing.Size(75, 38);
            this.smi_Cerrar.Text = "Cerrar";
            this.smi_Cerrar.Click += new System.EventHandler(this.smi_Cerrar_Click);
            // 
            // sta_Datos
            // 
            this.sta_Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(176)))));
            this.sta_Datos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbl_NombreUsuario});
            this.sta_Datos.Location = new System.Drawing.Point(0, 433);
            this.sta_Datos.Name = "sta_Datos";
            this.sta_Datos.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sta_Datos.Size = new System.Drawing.Size(800, 22);
            this.sta_Datos.SizingGrip = false;
            this.sta_Datos.TabIndex = 6;
            this.sta_Datos.Text = "statusStrip1";
            // 
            // sbl_NombreUsuario
            // 
            this.sbl_NombreUsuario.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sbl_NombreUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sbl_NombreUsuario.Name = "sbl_NombreUsuario";
            this.sbl_NombreUsuario.Size = new System.Drawing.Size(110, 17);
            this.sbl_NombreUsuario.Text = "Nombre de Usuario";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.ControlBox = false;
            this.Controls.Add(this.sta_Datos);
            this.Controls.Add(this.msp_Principal);
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
    }
}