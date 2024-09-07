namespace Vista
{
    partial class FrmErrorConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmErrorConexion));
            lbl_Titulo = new Label();
            lbl_Mensaje = new Label();
            btn_readme = new Button();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Lato", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Titulo.ForeColor = SystemColors.ControlLightLight;
            lbl_Titulo.Location = new Point(198, 31);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(193, 51);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Atención";
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.AutoSize = true;
            lbl_Mensaje.Font = new Font("Lato", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Mensaje.ForeColor = SystemColors.ControlLightLight;
            lbl_Mensaje.Location = new Point(62, 99);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new Size(489, 203);
            lbl_Mensaje.TabIndex = 1;
            lbl_Mensaje.Text = resources.GetString("lbl_Mensaje.Text");
            // 
            // btn_readme
            // 
            btn_readme.BackColor = Color.FromArgb(26, 26, 26);
            btn_readme.Cursor = Cursors.Hand;
            btn_readme.FlatAppearance.BorderColor = Color.FromArgb(26, 26, 26);
            btn_readme.FlatStyle = FlatStyle.Flat;
            btn_readme.Font = new Font("Lato", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btn_readme.ForeColor = Color.FromArgb(71, 99, 207);
            btn_readme.Location = new Point(145, 337);
            btn_readme.Name = "btn_readme";
            btn_readme.Size = new Size(306, 43);
            btn_readme.TabIndex = 2;
            btn_readme.Text = "Ir al README";
            btn_readme.UseVisualStyleBackColor = false;
            btn_readme.Click += btn_readme_Click;
            // 
            // FrmErrorConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(579, 414);
            Controls.Add(btn_readme);
            Controls.Add(lbl_Mensaje);
            Controls.Add(lbl_Titulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmErrorConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiosco Junior";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
        private Label lbl_Mensaje;
        private Button btn_readme;
    }
}