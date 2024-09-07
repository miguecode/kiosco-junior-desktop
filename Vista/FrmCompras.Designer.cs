namespace Vista
{
    partial class FrmCompras
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            dtg_Productos = new DataGridView();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            productoBindingSource = new BindingSource(components);
            productoBindingSource1 = new BindingSource(components);
            lbl_Menu = new Label();
            lbl_Carrito = new Label();
            lbl_Total = new Label();
            btn_Agregar = new Button();
            btn_Confirmar = new Button();
            lbl_Error = new Label();
            dtg_Carrito = new DataGridView();
            nombreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CantidadEnCarrito = new DataGridViewTextBoxColumn();
            btn_VaciarCarrito = new Button();
            pan_Precio = new Panel();
            btn_Sacar = new Button();
            rad_Efectivo = new RadioButton();
            rad_MercadoPago = new RadioButton();
            pnl_MetodoDePago = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtg_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Carrito).BeginInit();
            pan_Precio.SuspendLayout();
            pnl_MetodoDePago.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_Productos
            // 
            dtg_Productos.AllowUserToAddRows = false;
            dtg_Productos.AllowUserToDeleteRows = false;
            dtg_Productos.AllowUserToResizeColumns = false;
            dtg_Productos.AllowUserToResizeRows = false;
            dtg_Productos.AutoGenerateColumns = false;
            dtg_Productos.BackgroundColor = Color.FromArgb(26, 26, 26);
            dtg_Productos.BorderStyle = BorderStyle.None;
            dtg_Productos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_Productos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Productos.Columns.AddRange(new DataGridViewColumn[] { tipoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, Stock });
            dtg_Productos.DataSource = productoBindingSource;
            dtg_Productos.EnableHeadersVisualStyles = false;
            dtg_Productos.GridColor = Color.FromArgb(24, 75, 171);
            dtg_Productos.Location = new Point(12, 42);
            dtg_Productos.MultiSelect = false;
            dtg_Productos.Name = "dtg_Productos";
            dtg_Productos.ReadOnly = true;
            dtg_Productos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(24, 75, 171);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dtg_Productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtg_Productos.RowTemplate.Height = 25;
            dtg_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Productos.Size = new Size(418, 296);
            dtg_Productos.TabIndex = 0;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            tipoDataGridViewTextBoxColumn.Width = 90;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            nombreDataGridViewTextBoxColumn.Width = 110;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0,00";
            precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            precioDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Cantidad";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Resizable = DataGridViewTriState.False;
            Stock.Width = 60;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Entidades.Producto);
            // 
            // productoBindingSource1
            // 
            productoBindingSource1.DataSource = typeof(Entidades.Producto);
            // 
            // lbl_Menu
            // 
            lbl_Menu.AutoSize = true;
            lbl_Menu.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Menu.ForeColor = Color.White;
            lbl_Menu.Location = new Point(12, 8);
            lbl_Menu.Name = "lbl_Menu";
            lbl_Menu.Size = new Size(76, 31);
            lbl_Menu.TabIndex = 2;
            lbl_Menu.Text = "Menú";
            // 
            // lbl_Carrito
            // 
            lbl_Carrito.AutoSize = true;
            lbl_Carrito.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Carrito.ForeColor = Color.White;
            lbl_Carrito.Location = new Point(484, 8);
            lbl_Carrito.Name = "lbl_Carrito";
            lbl_Carrito.Size = new Size(88, 31);
            lbl_Carrito.TabIndex = 3;
            lbl_Carrito.Text = "Carrito";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.BackColor = Color.FromArgb(26, 26, 26);
            lbl_Total.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Total.ForeColor = Color.White;
            lbl_Total.Location = new Point(10, 13);
            lbl_Total.Margin = new Padding(0);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(157, 31);
            lbl_Total.TabIndex = 6;
            lbl_Total.Text = "TOTAL: $ 0,00";
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(26, 26, 26);
            btn_Agregar.Cursor = Cursors.Hand;
            btn_Agregar.FlatAppearance.BorderColor = SystemColors.Desktop;
            btn_Agregar.FlatAppearance.BorderSize = 5;
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Agregar.ForeColor = Color.WhiteSmoke;
            btn_Agregar.Location = new Point(183, 344);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(247, 54);
            btn_Agregar.TabIndex = 7;
            btn_Agregar.Text = "Agregar al carrito";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.FromArgb(50, 139, 24);
            btn_Confirmar.Cursor = Cursors.Hand;
            btn_Confirmar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btn_Confirmar.FlatAppearance.BorderSize = 5;
            btn_Confirmar.FlatStyle = FlatStyle.Flat;
            btn_Confirmar.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirmar.ForeColor = Color.White;
            btn_Confirmar.Location = new Point(600, 337);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(188, 61);
            btn_Confirmar.TabIndex = 8;
            btn_Confirmar.Text = "Comprar";
            btn_Confirmar.UseVisualStyleBackColor = false;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // lbl_Error
            // 
            lbl_Error.AutoSize = true;
            lbl_Error.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Error.ForeColor = Color.FromArgb(172, 0, 0);
            lbl_Error.Location = new Point(265, 12);
            lbl_Error.Name = "lbl_Error";
            lbl_Error.Size = new Size(138, 21);
            lbl_Error.TabIndex = 9;
            lbl_Error.Text = "Mensaje de error";
            lbl_Error.Visible = false;
            // 
            // dtg_Carrito
            // 
            dtg_Carrito.AllowUserToAddRows = false;
            dtg_Carrito.AllowUserToDeleteRows = false;
            dtg_Carrito.AllowUserToResizeColumns = false;
            dtg_Carrito.AllowUserToResizeRows = false;
            dtg_Carrito.AutoGenerateColumns = false;
            dtg_Carrito.BackgroundColor = Color.FromArgb(26, 26, 26);
            dtg_Carrito.BorderStyle = BorderStyle.None;
            dtg_Carrito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_Carrito.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtg_Carrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtg_Carrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Carrito.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn1, precioDataGridViewTextBoxColumn1, CantidadEnCarrito });
            dtg_Carrito.DataSource = productoBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtg_Carrito.DefaultCellStyle = dataGridViewCellStyle6;
            dtg_Carrito.EnableHeadersVisualStyles = false;
            dtg_Carrito.GridColor = Color.FromArgb(50, 139, 24);
            dtg_Carrito.Location = new Point(484, 41);
            dtg_Carrito.MultiSelect = false;
            dtg_Carrito.Name = "dtg_Carrito";
            dtg_Carrito.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtg_Carrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtg_Carrito.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(50, 139, 24);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dtg_Carrito.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dtg_Carrito.RowTemplate.Height = 25;
            dtg_Carrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Carrito.Size = new Size(304, 227);
            dtg_Carrito.TabIndex = 10;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            nombreDataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            nombreDataGridViewTextBoxColumn1.Width = 120;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0,00";
            precioDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            precioDataGridViewTextBoxColumn1.ReadOnly = true;
            precioDataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            precioDataGridViewTextBoxColumn1.Width = 70;
            // 
            // CantidadEnCarrito
            // 
            CantidadEnCarrito.DataPropertyName = "CantidadEnCarrito";
            CantidadEnCarrito.HeaderText = "Cantidad";
            CantidadEnCarrito.Name = "CantidadEnCarrito";
            CantidadEnCarrito.ReadOnly = true;
            CantidadEnCarrito.Resizable = DataGridViewTriState.False;
            CantidadEnCarrito.Width = 60;
            // 
            // btn_VaciarCarrito
            // 
            btn_VaciarCarrito.BackColor = Color.FromArgb(26, 26, 26);
            btn_VaciarCarrito.Cursor = Cursors.Hand;
            btn_VaciarCarrito.FlatAppearance.BorderColor = Color.FromArgb(45, 50, 61);
            btn_VaciarCarrito.FlatAppearance.BorderSize = 0;
            btn_VaciarCarrito.FlatStyle = FlatStyle.Flat;
            btn_VaciarCarrito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_VaciarCarrito.ForeColor = SystemColors.ButtonHighlight;
            btn_VaciarCarrito.Location = new Point(719, 12);
            btn_VaciarCarrito.Margin = new Padding(0);
            btn_VaciarCarrito.Name = "btn_VaciarCarrito";
            btn_VaciarCarrito.Size = new Size(69, 29);
            btn_VaciarCarrito.TabIndex = 11;
            btn_VaciarCarrito.Text = "Vaciar";
            btn_VaciarCarrito.UseVisualStyleBackColor = false;
            btn_VaciarCarrito.Click += btn_VaciarCarrito_Click;
            // 
            // pan_Precio
            // 
            pan_Precio.BackColor = Color.FromArgb(26, 26, 26);
            pan_Precio.Controls.Add(lbl_Total);
            pan_Precio.Location = new Point(484, 274);
            pan_Precio.Name = "pan_Precio";
            pan_Precio.Size = new Size(304, 57);
            pan_Precio.TabIndex = 12;
            // 
            // btn_Sacar
            // 
            btn_Sacar.BackColor = Color.FromArgb(26, 26, 26);
            btn_Sacar.Cursor = Cursors.Hand;
            btn_Sacar.FlatAppearance.BorderColor = Color.FromArgb(45, 50, 61);
            btn_Sacar.FlatAppearance.BorderSize = 0;
            btn_Sacar.FlatStyle = FlatStyle.Flat;
            btn_Sacar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sacar.ForeColor = SystemColors.ButtonHighlight;
            btn_Sacar.Location = new Point(650, 12);
            btn_Sacar.Margin = new Padding(0);
            btn_Sacar.Name = "btn_Sacar";
            btn_Sacar.Size = new Size(69, 29);
            btn_Sacar.TabIndex = 15;
            btn_Sacar.Text = "Sacar";
            btn_Sacar.UseVisualStyleBackColor = false;
            btn_Sacar.Click += btn_Sacar_Click;
            // 
            // rad_Efectivo
            // 
            rad_Efectivo.AutoSize = true;
            rad_Efectivo.Checked = true;
            rad_Efectivo.ForeColor = Color.White;
            rad_Efectivo.Location = new Point(10, 10);
            rad_Efectivo.Name = "rad_Efectivo";
            rad_Efectivo.Size = new Size(67, 19);
            rad_Efectivo.TabIndex = 17;
            rad_Efectivo.TabStop = true;
            rad_Efectivo.Text = "Efectivo";
            rad_Efectivo.UseVisualStyleBackColor = true;
            rad_Efectivo.CheckedChanged += rad_Efectivo_CheckedChanged;
            // 
            // rad_MercadoPago
            // 
            rad_MercadoPago.AutoSize = true;
            rad_MercadoPago.ForeColor = Color.White;
            rad_MercadoPago.Location = new Point(10, 35);
            rad_MercadoPago.Name = "rad_MercadoPago";
            rad_MercadoPago.Size = new Size(99, 19);
            rad_MercadoPago.TabIndex = 17;
            rad_MercadoPago.Text = "MercadoPago";
            rad_MercadoPago.UseVisualStyleBackColor = true;
            rad_MercadoPago.CheckedChanged += rad_MercadoPago_CheckedChanged;
            // 
            // pnl_MetodoDePago
            // 
            pnl_MetodoDePago.BackColor = Color.FromArgb(26, 26, 26);
            pnl_MetodoDePago.Controls.Add(rad_MercadoPago);
            pnl_MetodoDePago.Controls.Add(rad_Efectivo);
            pnl_MetodoDePago.Location = new Point(484, 337);
            pnl_MetodoDePago.Name = "pnl_MetodoDePago";
            pnl_MetodoDePago.Size = new Size(110, 61);
            pnl_MetodoDePago.TabIndex = 16;
            // 
            // FrmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(800, 414);
            ControlBox = false;
            Controls.Add(pnl_MetodoDePago);
            Controls.Add(btn_Sacar);
            Controls.Add(pan_Precio);
            Controls.Add(btn_VaciarCarrito);
            Controls.Add(dtg_Carrito);
            Controls.Add(lbl_Error);
            Controls.Add(btn_Confirmar);
            Controls.Add(btn_Agregar);
            Controls.Add(lbl_Carrito);
            Controls.Add(lbl_Menu);
            Controls.Add(dtg_Productos);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCompras";
            Text = "Sistema de Compras";
            Load += FrmCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Carrito).EndInit();
            pan_Precio.ResumeLayout(false);
            pan_Precio.PerformLayout();
            pnl_MetodoDePago.ResumeLayout(false);
            pnl_MetodoDePago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_Productos;
        private BindingSource productoBindingSource;
        private Label lbl_Menu;
        private Label lbl_Carrito;
        private BindingSource productoBindingSource1;
        private Label lbl_Total;
        private Button btn_Agregar;
        private Button btn_Confirmar;
        private Label lbl_Error;
        private DataGridView dtg_Carrito;
        private Button btn_VaciarCarrito;
        private Panel pan_Precio;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CantidadEnCarrito;
        private Button btn_Sacar;
        private RadioButton rad_Efectivo;
        private RadioButton rad_MercadoPago;
        private Panel pnl_MetodoDePago;
    }
}