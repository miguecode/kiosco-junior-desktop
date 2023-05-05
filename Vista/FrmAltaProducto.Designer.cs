namespace Vista
{
    partial class FrmAltaProducto
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
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.rtb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.nud_Stock = new System.Windows.Forms.NumericUpDown();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.nud_Precio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(143)))), ((int)(((byte)(16)))));
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Confirmar.Location = new System.Drawing.Point(236, 182);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(123, 42);
            this.btn_Confirmar.TabIndex = 0;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(28, 41);
            this.txt_Nombre.MaxLength = 23;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(151, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(28, 93);
            this.txt_Marca.MaxLength = 23;
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(151, 23);
            this.txt_Marca.TabIndex = 2;
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Cigarrillo",
            "Snack",
            "Dulce",
            "Galletita",
            "Bebida",
            "Alfajor",
            "Otros"});
            this.cmb_Tipo.Location = new System.Drawing.Point(238, 41);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(121, 23);
            this.cmb_Tipo.TabIndex = 4;
            // 
            // rtb_Descripcion
            // 
            this.rtb_Descripcion.Location = new System.Drawing.Point(28, 150);
            this.rtb_Descripcion.MaxLength = 120;
            this.rtb_Descripcion.Name = "rtb_Descripcion";
            this.rtb_Descripcion.Size = new System.Drawing.Size(186, 74);
            this.rtb_Descripcion.TabIndex = 5;
            this.rtb_Descripcion.Text = "";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(236, 230);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(123, 39);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // nud_Stock
            // 
            this.nud_Stock.Location = new System.Drawing.Point(239, 93);
            this.nud_Stock.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_Stock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Stock.Name = "nud_Stock";
            this.nud_Stock.Size = new System.Drawing.Size(120, 23);
            this.nud_Stock.TabIndex = 7;
            this.nud_Stock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Nombre.Location = new System.Drawing.Point(28, 19);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(65, 19);
            this.lbl_Nombre.TabIndex = 8;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Marca.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Marca.Location = new System.Drawing.Point(28, 71);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(51, 19);
            this.lbl_Marca.TabIndex = 9;
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tipo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Tipo.Location = new System.Drawing.Point(239, 19);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(39, 19);
            this.lbl_Tipo.TabIndex = 10;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Stock.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Stock.Location = new System.Drawing.Point(239, 71);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(46, 19);
            this.lbl_Stock.TabIndex = 11;
            this.lbl_Stock.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(28, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripción";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(28, 240);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(124, 19);
            this.lbl_Error.TabIndex = 13;
            this.lbl_Error.Text = "Mensaje de error";
            this.lbl_Error.Visible = false;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Precio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Precio.Location = new System.Drawing.Point(238, 128);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(52, 19);
            this.lbl_Precio.TabIndex = 14;
            this.lbl_Precio.Text = "Precio";
            // 
            // nud_Precio
            // 
            this.nud_Precio.Location = new System.Drawing.Point(239, 150);
            this.nud_Precio.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_Precio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Precio.Name = "nud_Precio";
            this.nud_Precio.Size = new System.Drawing.Size(120, 23);
            this.nud_Precio.TabIndex = 15;
            this.nud_Precio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(384, 288);
            this.ControlBox = false;
            this.Controls.Add(this.nud_Precio);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.nud_Stock);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.rtb_Descripcion);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Producto";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Confirmar;
        private TextBox txt_Nombre;
        private TextBox txt_Marca;
        private ComboBox cmb_Tipo;
        private RichTextBox rtb_Descripcion;
        private Button btn_Cancelar;
        private NumericUpDown nud_Stock;
        private Label lbl_Nombre;
        private Label lbl_Marca;
        private Label lbl_Tipo;
        private Label lbl_Stock;
        private Label label5;
        private Label lbl_Error;
        private Label lbl_Precio;
        private NumericUpDown nud_Precio;
    }
}