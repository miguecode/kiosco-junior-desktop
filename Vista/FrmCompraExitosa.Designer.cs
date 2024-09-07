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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompraExitosa));
            lbl_CompraExitosa = new Label();
            pnl_Bordes = new Panel();
            rtb_Mensaje = new RichTextBox();
            btn_Aceptar = new Button();
            pnl_Bordes.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_CompraExitosa
            // 
            lbl_CompraExitosa.AutoSize = true;
            lbl_CompraExitosa.Font = new Font("Dosis", 37F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CompraExitosa.ForeColor = Color.FromArgb(55, 170, 61);
            lbl_CompraExitosa.Location = new Point(130, 9);
            lbl_CompraExitosa.Name = "lbl_CompraExitosa";
            lbl_CompraExitosa.Size = new Size(193, 64);
            lbl_CompraExitosa.TabIndex = 0;
            lbl_CompraExitosa.Text = "¡Gracias!";
            // 
            // pnl_Bordes
            // 
            pnl_Bordes.BackColor = Color.FromArgb(10, 10, 10);
            pnl_Bordes.Controls.Add(rtb_Mensaje);
            pnl_Bordes.Location = new Point(23, 89);
            pnl_Bordes.Name = "pnl_Bordes";
            pnl_Bordes.Size = new Size(408, 278);
            pnl_Bordes.TabIndex = 2;
            // 
            // rtb_Mensaje
            // 
            rtb_Mensaje.BackColor = Color.FromArgb(10, 10, 10);
            rtb_Mensaje.BorderStyle = BorderStyle.None;
            rtb_Mensaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_Mensaje.ForeColor = SystemColors.HighlightText;
            rtb_Mensaje.Location = new Point(20, 17);
            rtb_Mensaje.Name = "rtb_Mensaje";
            rtb_Mensaje.ReadOnly = true;
            rtb_Mensaje.Size = new Size(369, 244);
            rtb_Mensaje.TabIndex = 0;
            rtb_Mensaje.TabStop = false;
            rtb_Mensaje.Text = "Datos de la compra";
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Cursor = Cursors.Hand;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Font = new Font("Dosis", 22F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Aceptar.ForeColor = Color.FromArgb(55, 170, 61);
            btn_Aceptar.Location = new Point(130, 373);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(193, 55);
            btn_Aceptar.TabIndex = 3;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // FrmCompraExitosa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(452, 440);
            Controls.Add(btn_Aceptar);
            Controls.Add(pnl_Bordes);
            Controls.Add(lbl_CompraExitosa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCompraExitosa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiosco Junior";
            pnl_Bordes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_CompraExitosa;
        private Panel pnl_Bordes;
        private RichTextBox rtb_Mensaje;
        private Button btn_Aceptar;
    }
}