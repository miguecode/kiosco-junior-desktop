namespace Vista
{
    partial class FrmLogs
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
            this.rtb_Logs = new System.Windows.Forms.RichTextBox();
            this.pan_Logs = new System.Windows.Forms.Panel();
            this.btn_Vaciar = new System.Windows.Forms.Button();
            this.pan_Logs.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Logs
            // 
            this.rtb_Logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.rtb_Logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Logs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_Logs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.rtb_Logs.Location = new System.Drawing.Point(22, 14);
            this.rtb_Logs.Name = "rtb_Logs";
            this.rtb_Logs.ReadOnly = true;
            this.rtb_Logs.Size = new System.Drawing.Size(723, 307);
            this.rtb_Logs.TabIndex = 0;
            this.rtb_Logs.Text = "Logs";
            // 
            // pan_Logs
            // 
            this.pan_Logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pan_Logs.Controls.Add(this.rtb_Logs);
            this.pan_Logs.Location = new System.Drawing.Point(24, 12);
            this.pan_Logs.Name = "pan_Logs";
            this.pan_Logs.Size = new System.Drawing.Size(748, 345);
            this.pan_Logs.TabIndex = 1;
            // 
            // btn_Vaciar
            // 
            this.btn_Vaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vaciar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Vaciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Vaciar.Location = new System.Drawing.Point(653, 363);
            this.btn_Vaciar.Name = "btn_Vaciar";
            this.btn_Vaciar.Size = new System.Drawing.Size(119, 35);
            this.btn_Vaciar.TabIndex = 2;
            this.btn_Vaciar.Text = "Vaciar";
            this.btn_Vaciar.UseVisualStyleBackColor = true;
            this.btn_Vaciar.Click += new System.EventHandler(this.btn_Vaciar_Click);
            // 
            // FrmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(796, 422);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Vaciar);
            this.Controls.Add(this.pan_Logs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogs";
            this.ShowIcon = false;
            this.Text = "FrmLogs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLogs_Load);
            this.pan_Logs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtb_Logs;
        private Panel pan_Logs;
        private Button btn_Vaciar;
    }
}