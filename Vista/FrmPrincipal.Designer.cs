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
            this.btn_VerProductos = new System.Windows.Forms.Button();
            this.btn_AltaProducto = new System.Windows.Forms.Button();
            this.lbl_Datos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_VerProductos
            // 
            this.btn_VerProductos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VerProductos.Location = new System.Drawing.Point(12, 51);
            this.btn_VerProductos.Name = "btn_VerProductos";
            this.btn_VerProductos.Size = new System.Drawing.Size(272, 46);
            this.btn_VerProductos.TabIndex = 0;
            this.btn_VerProductos.Text = "Ver Productos";
            this.btn_VerProductos.UseVisualStyleBackColor = true;
            // 
            // btn_AltaProducto
            // 
            this.btn_AltaProducto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AltaProducto.Location = new System.Drawing.Point(303, 51);
            this.btn_AltaProducto.Name = "btn_AltaProducto";
            this.btn_AltaProducto.Size = new System.Drawing.Size(276, 46);
            this.btn_AltaProducto.TabIndex = 1;
            this.btn_AltaProducto.Text = "Agregar/Eliminar Productos";
            this.btn_AltaProducto.UseVisualStyleBackColor = true;
            // 
            // lbl_Datos
            // 
            this.lbl_Datos.AutoSize = true;
            this.lbl_Datos.BackColor = System.Drawing.Color.Orange;
            this.lbl_Datos.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Datos.ForeColor = System.Drawing.Color.Black;
            this.lbl_Datos.Location = new System.Drawing.Point(29, 9);
            this.lbl_Datos.Name = "lbl_Datos";
            this.lbl_Datos.Size = new System.Drawing.Size(143, 20);
            this.lbl_Datos.TabIndex = 2;
            this.lbl_Datos.Text = "Nombre del Usuario";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 319);
            this.Controls.Add(this.lbl_Datos);
            this.Controls.Add(this.btn_AltaProducto);
            this.Controls.Add(this.btn_VerProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_VerProductos;
        private Button btn_AltaProducto;
        private Label lbl_Datos;
    }
}