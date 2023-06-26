namespace Vista
{
    partial class FrmInformes
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
            this.btn_ExportarCSV = new System.Windows.Forms.Button();
            this.lbl_Exportar = new System.Windows.Forms.Label();
            this.btn_ExportarJSON = new System.Windows.Forms.Button();
            this.pan_Exportar = new System.Windows.Forms.Panel();
            this.lbl_InfoExportar = new System.Windows.Forms.Label();
            this.pan_Importar = new System.Windows.Forms.Panel();
            this.lbl_InfoImportar = new System.Windows.Forms.Label();
            this.btn_ImportarCSV = new System.Windows.Forms.Button();
            this.lbl_Importar = new System.Windows.Forms.Label();
            this.btn_ImportarJSON = new System.Windows.Forms.Button();
            this.chk_ExportacionAutomatica = new System.Windows.Forms.CheckBox();
            this.lbl_ExpAutomatica = new System.Windows.Forms.Label();
            this.pan_ExpAutomatica = new System.Windows.Forms.Panel();
            this.pan_Exportar.SuspendLayout();
            this.pan_Importar.SuspendLayout();
            this.pan_ExpAutomatica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ExportarCSV
            // 
            this.btn_ExportarCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_ExportarCSV.BackgroundImage = global::Vista.Properties.Resources.csv;
            this.btn_ExportarCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ExportarCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExportarCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarCSV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ExportarCSV.Location = new System.Drawing.Point(38, 80);
            this.btn_ExportarCSV.Name = "btn_ExportarCSV";
            this.btn_ExportarCSV.Size = new System.Drawing.Size(129, 158);
            this.btn_ExportarCSV.TabIndex = 0;
            this.btn_ExportarCSV.UseVisualStyleBackColor = false;
            this.btn_ExportarCSV.Click += new System.EventHandler(this.btn_ExportarCSV_Click);
            // 
            // lbl_Exportar
            // 
            this.lbl_Exportar.AutoSize = true;
            this.lbl_Exportar.Font = new System.Drawing.Font("Gadugi", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Exportar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Exportar.Location = new System.Drawing.Point(54, 21);
            this.lbl_Exportar.Name = "lbl_Exportar";
            this.lbl_Exportar.Size = new System.Drawing.Size(245, 40);
            this.lbl_Exportar.TabIndex = 2;
            this.lbl_Exportar.Text = "Exportar datos";
            // 
            // btn_ExportarJSON
            // 
            this.btn_ExportarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_ExportarJSON.BackgroundImage = global::Vista.Properties.Resources.json;
            this.btn_ExportarJSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ExportarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExportarJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarJSON.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ExportarJSON.Location = new System.Drawing.Point(193, 80);
            this.btn_ExportarJSON.Name = "btn_ExportarJSON";
            this.btn_ExportarJSON.Size = new System.Drawing.Size(129, 158);
            this.btn_ExportarJSON.TabIndex = 3;
            this.btn_ExportarJSON.UseVisualStyleBackColor = false;
            this.btn_ExportarJSON.Click += new System.EventHandler(this.btn_ExportarJSON_Click);
            // 
            // pan_Exportar
            // 
            this.pan_Exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pan_Exportar.Controls.Add(this.lbl_InfoExportar);
            this.pan_Exportar.Controls.Add(this.btn_ExportarCSV);
            this.pan_Exportar.Controls.Add(this.lbl_Exportar);
            this.pan_Exportar.Controls.Add(this.btn_ExportarJSON);
            this.pan_Exportar.Location = new System.Drawing.Point(36, 19);
            this.pan_Exportar.Name = "pan_Exportar";
            this.pan_Exportar.Size = new System.Drawing.Size(358, 327);
            this.pan_Exportar.TabIndex = 4;
            // 
            // lbl_InfoExportar
            // 
            this.lbl_InfoExportar.AutoSize = true;
            this.lbl_InfoExportar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_InfoExportar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_InfoExportar.Location = new System.Drawing.Point(25, 255);
            this.lbl_InfoExportar.Name = "lbl_InfoExportar";
            this.lbl_InfoExportar.Size = new System.Drawing.Size(316, 60);
            this.lbl_InfoExportar.TabIndex = 6;
            this.lbl_InfoExportar.Text = "Esto actualizará los archivos correspondientes \r\ncon la información actual de los" +
                                             " usuarios, \r\nproductos y ventas.";
            // 
            // pan_Importar
            // 
            this.pan_Importar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pan_Importar.Controls.Add(this.lbl_InfoImportar);
            this.pan_Importar.Controls.Add(this.btn_ImportarCSV);
            this.pan_Importar.Controls.Add(this.lbl_Importar);
            this.pan_Importar.Controls.Add(this.btn_ImportarJSON);
            this.pan_Importar.Location = new System.Drawing.Point(400, 19);
            this.pan_Importar.Name = "pan_Importar";
            this.pan_Importar.Size = new System.Drawing.Size(357, 327);
            this.pan_Importar.TabIndex = 5;
            // 
            // lbl_InfoImportar
            // 
            this.lbl_InfoImportar.AutoSize = true;
            this.lbl_InfoImportar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_InfoImportar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_InfoImportar.Location = new System.Drawing.Point(38, 255);
            this.lbl_InfoImportar.Name = "lbl_InfoImportar";
            this.lbl_InfoImportar.Size = new System.Drawing.Size(295, 40);
            this.lbl_InfoImportar.TabIndex = 7;
            this.lbl_InfoImportar.Text = "Esto sobreescribirá la base de datos con la \r\ninformación recibida.";
            // 
            // btn_ImportarCSV
            // 
            this.btn_ImportarCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_ImportarCSV.BackgroundImage = global::Vista.Properties.Resources.csv;
            this.btn_ImportarCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ImportarCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImportarCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportarCSV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ImportarCSV.Location = new System.Drawing.Point(38, 80);
            this.btn_ImportarCSV.Name = "btn_ImportarCSV";
            this.btn_ImportarCSV.Size = new System.Drawing.Size(129, 158);
            this.btn_ImportarCSV.TabIndex = 0;
            this.btn_ImportarCSV.UseVisualStyleBackColor = false;
            this.btn_ImportarCSV.Click += new System.EventHandler(this.btn_ImportarCSV_Click);
            // 
            // lbl_Importar
            // 
            this.lbl_Importar.AutoSize = true;
            this.lbl_Importar.Font = new System.Drawing.Font("Gadugi", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Importar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Importar.Location = new System.Drawing.Point(55, 21);
            this.lbl_Importar.Name = "lbl_Importar";
            this.lbl_Importar.Size = new System.Drawing.Size(249, 40);
            this.lbl_Importar.TabIndex = 2;
            this.lbl_Importar.Text = "Importar datos";
            // 
            // btn_ImportarJSON
            // 
            this.btn_ImportarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_ImportarJSON.BackgroundImage = global::Vista.Properties.Resources.json;
            this.btn_ImportarJSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ImportarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImportarJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportarJSON.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ImportarJSON.Location = new System.Drawing.Point(193, 80);
            this.btn_ImportarJSON.Name = "btn_ImportarJSON";
            this.btn_ImportarJSON.Size = new System.Drawing.Size(129, 158);
            this.btn_ImportarJSON.TabIndex = 3;
            this.btn_ImportarJSON.UseVisualStyleBackColor = false;
            this.btn_ImportarJSON.Click += new System.EventHandler(this.btn_ImportarJSON_Click);
            // 
            // chk_ExportacionAutomatica
            // 
            this.chk_ExportacionAutomatica.AutoSize = true;
            this.chk_ExportacionAutomatica.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_ExportacionAutomatica.ForeColor = System.Drawing.SystemColors.Control;
            this.chk_ExportacionAutomatica.Location = new System.Drawing.Point(119, 3);
            this.chk_ExportacionAutomatica.Name = "chk_ExportacionAutomatica";
            this.chk_ExportacionAutomatica.Size = new System.Drawing.Size(434, 34);
            this.chk_ExportacionAutomatica.TabIndex = 6;
            this.chk_ExportacionAutomatica.Text = "Exportación Automática al cerrar aplicación";
            this.chk_ExportacionAutomatica.UseVisualStyleBackColor = true;
            this.chk_ExportacionAutomatica.CheckedChanged += new System.EventHandler(this.chk_ExportacionAutomatica_CheckedChanged);
            // 
            // lbl_ExpAutomatica
            // 
            this.lbl_ExpAutomatica.AutoSize = true;
            this.lbl_ExpAutomatica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExpAutomatica.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ExpAutomatica.Location = new System.Drawing.Point(548, 11);
            this.lbl_ExpAutomatica.Name = "lbl_ExpAutomatica";
            this.lbl_ExpAutomatica.Size = new System.Drawing.Size(90, 19);
            this.lbl_ExpAutomatica.TabIndex = 7;
            this.lbl_ExpAutomatica.Text = "(CSV y JSON)";
            // 
            // pan_ExpAutomatica
            // 
            this.pan_ExpAutomatica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pan_ExpAutomatica.Controls.Add(this.chk_ExportacionAutomatica);
            this.pan_ExpAutomatica.Controls.Add(this.lbl_ExpAutomatica);
            this.pan_ExpAutomatica.Location = new System.Drawing.Point(36, 352);
            this.pan_ExpAutomatica.Name = "pan_ExpAutomatica";
            this.pan_ExpAutomatica.Size = new System.Drawing.Size(721, 40);
            this.pan_ExpAutomatica.TabIndex = 8;
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(790, 407);
            this.ControlBox = false;
            this.Controls.Add(this.pan_ExpAutomatica);
            this.Controls.Add(this.pan_Importar);
            this.Controls.Add(this.pan_Exportar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInformes";
            this.ShowIcon = false;
            this.Text = "Informes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            this.pan_Exportar.ResumeLayout(false);
            this.pan_Exportar.PerformLayout();
            this.pan_Importar.ResumeLayout(false);
            this.pan_Importar.PerformLayout();
            this.pan_ExpAutomatica.ResumeLayout(false);
            this.pan_ExpAutomatica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_ExportarCSV;
        private Label lbl_Exportar;
        private Button btn_ExportarJSON;
        private Panel pan_Exportar;
        private Panel pan_Importar;
        private Button btn_ImportarCSV;
        private Label lbl_Importar;
        private Button btn_ImportarJSON;
        private CheckBox chk_ExportacionAutomatica;
        private Label lbl_ExpAutomatica;
        private Label lbl_InfoExportar;
        private Label lbl_InfoImportar;
        private Panel pan_ExpAutomatica;
    }
}