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
            this.lbl_Datos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Datos
            // 
            this.lbl_Datos.AutoSize = true;
            this.lbl_Datos.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Datos.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Datos.ForeColor = System.Drawing.Color.White;
            this.lbl_Datos.Location = new System.Drawing.Point(37, 282);
            this.lbl_Datos.Name = "lbl_Datos";
            this.lbl_Datos.Padding = new System.Windows.Forms.Padding(4);
            this.lbl_Datos.Size = new System.Drawing.Size(158, 28);
            this.lbl_Datos.TabIndex = 2;
            this.lbl_Datos.Text = "Nombre del Usuario";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 319);
            this.Controls.Add(this.lbl_Datos);
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
        private Label lbl_Datos;
    }
}