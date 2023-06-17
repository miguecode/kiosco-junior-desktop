namespace Vista
{
    partial class FrmCompraExitosa
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
            this.lbl_CompraExitosa = new System.Windows.Forms.Label();
            this.pnl_Bordes = new System.Windows.Forms.Panel();
            this.rtb_Mensaje = new System.Windows.Forms.RichTextBox();
            this.pnl_Bordes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CompraExitosa
            // 
            this.lbl_CompraExitosa.AutoSize = true;
            this.lbl_CompraExitosa.Font = new System.Drawing.Font("Dosis", 37F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CompraExitosa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(170)))), ((int)(((byte)(61)))));
            this.lbl_CompraExitosa.Location = new System.Drawing.Point(130, 9);
            this.lbl_CompraExitosa.Name = "lbl_CompraExitosa";
            this.lbl_CompraExitosa.Size = new System.Drawing.Size(193, 64);
            this.lbl_CompraExitosa.TabIndex = 0;
            this.lbl_CompraExitosa.Text = "¡Gracias!";
            // 
            // pnl_Bordes
            // 
            this.pnl_Bordes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pnl_Bordes.Controls.Add(this.rtb_Mensaje);
            this.pnl_Bordes.Location = new System.Drawing.Point(23, 89);
            this.pnl_Bordes.Name = "pnl_Bordes";
            this.pnl_Bordes.Size = new System.Drawing.Size(408, 278);
            this.pnl_Bordes.TabIndex = 2;
            // 
            // rtb_Mensaje
            // 
            this.rtb_Mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.rtb_Mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Mensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_Mensaje.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rtb_Mensaje.Location = new System.Drawing.Point(20, 17);
            this.rtb_Mensaje.Name = "rtb_Mensaje";
            this.rtb_Mensaje.ReadOnly = true;
            this.rtb_Mensaje.Size = new System.Drawing.Size(369, 244);
            this.rtb_Mensaje.TabIndex = 0;
            this.rtb_Mensaje.TabStop = false;
            this.rtb_Mensaje.Text = "Datos de la compra";
            // 
            // FrmCompraExitosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(452, 384);
            this.Controls.Add(this.pnl_Bordes);
            this.Controls.Add(this.lbl_CompraExitosa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompraExitosa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco Junior";
            this.Load += new System.EventHandler(this.FrmCompraExitosa_Load);
            this.pnl_Bordes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_CompraExitosa;
        private Panel pnl_Bordes;
        private RichTextBox rtb_Mensaje;
    }
}