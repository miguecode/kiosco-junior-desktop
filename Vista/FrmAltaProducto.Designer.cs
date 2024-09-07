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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaProducto));
            btn_Confirmar = new Button();
            txt_Nombre = new TextBox();
            txt_Marca = new TextBox();
            cmb_Tipo = new ComboBox();
            rtb_Descripcion = new RichTextBox();
            btn_Cancelar = new Button();
            nud_Stock = new NumericUpDown();
            lbl_Nombre = new Label();
            lbl_Marca = new Label();
            lbl_Tipo = new Label();
            lbl_Stock = new Label();
            label5 = new Label();
            lbl_Error = new Label();
            lbl_Precio = new Label();
            nud_Precio = new NumericUpDown();
            pan_Nombre = new Panel();
            pan_Marca = new Panel();
            pan_Stock = new Panel();
            pan_Precio = new Panel();
            ((System.ComponentModel.ISupportInitialize)nud_Stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Precio).BeginInit();
            SuspendLayout();
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.FromArgb(67, 143, 16);
            btn_Confirmar.Cursor = Cursors.Hand;
            btn_Confirmar.FlatAppearance.BorderSize = 0;
            btn_Confirmar.FlatStyle = FlatStyle.Flat;
            btn_Confirmar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirmar.ForeColor = SystemColors.ButtonHighlight;
            btn_Confirmar.Location = new Point(52, 278);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(163, 42);
            btn_Confirmar.TabIndex = 0;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = false;
            btn_Confirmar.Click += btn_Agregar_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.FromArgb(26, 26, 26);
            txt_Nombre.BorderStyle = BorderStyle.None;
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(54, 46);
            txt_Nombre.MaxLength = 23;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(161, 16);
            txt_Nombre.TabIndex = 1;
            // 
            // txt_Marca
            // 
            txt_Marca.BackColor = Color.FromArgb(26, 26, 26);
            txt_Marca.BorderStyle = BorderStyle.None;
            txt_Marca.ForeColor = Color.White;
            txt_Marca.Location = new Point(54, 110);
            txt_Marca.MaxLength = 23;
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(161, 16);
            txt_Marca.TabIndex = 2;
            // 
            // cmb_Tipo
            // 
            cmb_Tipo.BackColor = Color.FromArgb(26, 26, 26);
            cmb_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Tipo.ForeColor = Color.White;
            cmb_Tipo.FormattingEnabled = true;
            cmb_Tipo.Items.AddRange(new object[] { "Cigarrillos", "Bebidas", "Snacks", "Galletitas", "Dulces", "Comidas", "Otros" });
            cmb_Tipo.Location = new Point(271, 46);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(121, 23);
            cmb_Tipo.TabIndex = 4;
            // 
            // rtb_Descripcion
            // 
            rtb_Descripcion.BackColor = Color.FromArgb(26, 26, 26);
            rtb_Descripcion.BorderStyle = BorderStyle.FixedSingle;
            rtb_Descripcion.ForeColor = Color.White;
            rtb_Descripcion.Location = new Point(54, 177);
            rtb_Descripcion.MaxLength = 120;
            rtb_Descripcion.Name = "rtb_Descripcion";
            rtb_Descripcion.Size = new Size(161, 74);
            rtb_Descripcion.TabIndex = 5;
            rtb_Descripcion.Text = "";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(164, 45, 0);
            btn_Cancelar.Cursor = Cursors.Hand;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cancelar.Location = new Point(52, 326);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(163, 39);
            btn_Cancelar.TabIndex = 6;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // nud_Stock
            // 
            nud_Stock.BackColor = Color.FromArgb(26, 26, 26);
            nud_Stock.BorderStyle = BorderStyle.None;
            nud_Stock.ForeColor = Color.White;
            nud_Stock.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nud_Stock.Location = new Point(271, 111);
            nud_Stock.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nud_Stock.Name = "nud_Stock";
            nud_Stock.Size = new Size(120, 19);
            nud_Stock.TabIndex = 7;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.ForeColor = SystemColors.HighlightText;
            lbl_Nombre.Location = new Point(52, 24);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(65, 19);
            lbl_Nombre.TabIndex = 8;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Marca
            // 
            lbl_Marca.AutoSize = true;
            lbl_Marca.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Marca.ForeColor = SystemColors.HighlightText;
            lbl_Marca.Location = new Point(52, 89);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(51, 19);
            lbl_Marca.TabIndex = 9;
            lbl_Marca.Text = "Marca";
            // 
            // lbl_Tipo
            // 
            lbl_Tipo.AutoSize = true;
            lbl_Tipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tipo.ForeColor = SystemColors.HighlightText;
            lbl_Tipo.Location = new Point(272, 24);
            lbl_Tipo.Name = "lbl_Tipo";
            lbl_Tipo.Size = new Size(39, 19);
            lbl_Tipo.TabIndex = 10;
            lbl_Tipo.Text = "Tipo";
            // 
            // lbl_Stock
            // 
            lbl_Stock.AutoSize = true;
            lbl_Stock.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Stock.ForeColor = SystemColors.HighlightText;
            lbl_Stock.Location = new Point(271, 89);
            lbl_Stock.Name = "lbl_Stock";
            lbl_Stock.Size = new Size(106, 19);
            lbl_Stock.TabIndex = 11;
            lbl_Stock.Text = "Stock (1-2000)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(52, 155);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 12;
            label5.Text = "Descripción";
            // 
            // lbl_Error
            // 
            lbl_Error.AutoSize = true;
            lbl_Error.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Error.ForeColor = Color.FromArgb(172, 0, 0);
            lbl_Error.Location = new Point(272, 232);
            lbl_Error.Name = "lbl_Error";
            lbl_Error.Size = new Size(124, 19);
            lbl_Error.TabIndex = 13;
            lbl_Error.Text = "Mensaje de error";
            lbl_Error.Visible = false;
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Precio.ForeColor = SystemColors.HighlightText;
            lbl_Precio.Location = new Point(271, 155);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(112, 19);
            lbl_Precio.TabIndex = 14;
            lbl_Precio.Text = "Precio (1-5000)";
            // 
            // nud_Precio
            // 
            nud_Precio.BackColor = Color.FromArgb(26, 26, 26);
            nud_Precio.BorderStyle = BorderStyle.None;
            nud_Precio.DecimalPlaces = 2;
            nud_Precio.ForeColor = Color.White;
            nud_Precio.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nud_Precio.Location = new Point(272, 177);
            nud_Precio.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nud_Precio.Name = "nud_Precio";
            nud_Precio.Size = new Size(120, 19);
            nud_Precio.TabIndex = 15;
            // 
            // pan_Nombre
            // 
            pan_Nombre.BackColor = Color.White;
            pan_Nombre.Location = new Point(52, 68);
            pan_Nombre.Name = "pan_Nombre";
            pan_Nombre.Size = new Size(163, 1);
            pan_Nombre.TabIndex = 16;
            // 
            // pan_Marca
            // 
            pan_Marca.BackColor = Color.White;
            pan_Marca.Location = new Point(52, 133);
            pan_Marca.Name = "pan_Marca";
            pan_Marca.Size = new Size(163, 1);
            pan_Marca.TabIndex = 17;
            // 
            // pan_Stock
            // 
            pan_Stock.BackColor = Color.White;
            pan_Stock.Location = new Point(271, 127);
            pan_Stock.Name = "pan_Stock";
            pan_Stock.Size = new Size(103, 1);
            pan_Stock.TabIndex = 18;
            // 
            // pan_Precio
            // 
            pan_Precio.BackColor = Color.White;
            pan_Precio.Location = new Point(271, 195);
            pan_Precio.Name = "pan_Precio";
            pan_Precio.Size = new Size(103, 1);
            pan_Precio.TabIndex = 19;
            // 
            // FrmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(452, 399);
            Controls.Add(pan_Precio);
            Controls.Add(pan_Stock);
            Controls.Add(pan_Marca);
            Controls.Add(pan_Nombre);
            Controls.Add(nud_Precio);
            Controls.Add(lbl_Precio);
            Controls.Add(lbl_Error);
            Controls.Add(label5);
            Controls.Add(lbl_Stock);
            Controls.Add(lbl_Tipo);
            Controls.Add(lbl_Marca);
            Controls.Add(lbl_Nombre);
            Controls.Add(nud_Stock);
            Controls.Add(btn_Cancelar);
            Controls.Add(rtb_Descripcion);
            Controls.Add(cmb_Tipo);
            Controls.Add(txt_Marca);
            Controls.Add(txt_Nombre);
            Controls.Add(btn_Confirmar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAltaProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del Producto";
            Load += FrmAltaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nud_Stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Precio).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel pan_Nombre;
        private Panel pan_Marca;
        private Panel pan_Stock;
        private Panel pan_Precio;
    }
}