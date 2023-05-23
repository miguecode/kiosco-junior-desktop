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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Productos = new System.Windows.Forms.DataGridView();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.lbl_Carrito = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.dtg_Carrito = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEnCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_VaciarCarrito = new System.Windows.Forms.Button();
            this.pan_Precio = new System.Windows.Forms.Panel();
            this.btn_Sacar = new System.Windows.Forms.Button();
            this.rad_Efectivo = new System.Windows.Forms.RadioButton();
            this.rad_MercadoPago = new System.Windows.Forms.RadioButton();
            this.pnl_MetodoDePago = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Carrito)).BeginInit();
            this.pan_Precio.SuspendLayout();
            this.pnl_MetodoDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Productos
            // 
            this.dtg_Productos.AllowUserToAddRows = false;
            this.dtg_Productos.AllowUserToDeleteRows = false;
            this.dtg_Productos.AllowUserToResizeColumns = false;
            this.dtg_Productos.AllowUserToResizeRows = false;
            this.dtg_Productos.AutoGenerateColumns = false;
            this.dtg_Productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dtg_Productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_Productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.Stock});
            this.dtg_Productos.DataSource = this.productoBindingSource;
            this.dtg_Productos.EnableHeadersVisualStyles = false;
            this.dtg_Productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.dtg_Productos.Location = new System.Drawing.Point(12, 42);
            this.dtg_Productos.MultiSelect = false;
            this.dtg_Productos.Name = "dtg_Productos";
            this.dtg_Productos.ReadOnly = true;
            this.dtg_Productos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_Productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Productos.RowTemplate.Height = 25;
            this.dtg_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Productos.Size = new System.Drawing.Size(418, 296);
            this.dtg_Productos.TabIndex = 0;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipoDataGridViewTextBoxColumn.Width = 90;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreDataGridViewTextBoxColumn.Width = 110;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0,00";
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Cantidad";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Stock.Width = 60;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Entidades.Producto);
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataSource = typeof(Entidades.Producto);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Menu.ForeColor = System.Drawing.Color.White;
            this.lbl_Menu.Location = new System.Drawing.Point(12, 8);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(76, 31);
            this.lbl_Menu.TabIndex = 2;
            this.lbl_Menu.Text = "Menú";
            // 
            // lbl_Carrito
            // 
            this.lbl_Carrito.AutoSize = true;
            this.lbl_Carrito.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Carrito.ForeColor = System.Drawing.Color.White;
            this.lbl_Carrito.Location = new System.Drawing.Point(484, 8);
            this.lbl_Carrito.Name = "lbl_Carrito";
            this.lbl_Carrito.Size = new System.Drawing.Size(88, 31);
            this.lbl_Carrito.TabIndex = 3;
            this.lbl_Carrito.Text = "Carrito";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(10, 13);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(157, 31);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "TOTAL: $ 0,00";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btn_Agregar.FlatAppearance.BorderSize = 5;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agregar.Location = new System.Drawing.Point(183, 344);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(247, 54);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "Agregar al carrito";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(24)))));
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Confirmar.FlatAppearance.BorderSize = 5;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_Confirmar.Location = new System.Drawing.Point(600, 337);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(188, 61);
            this.btn_Confirmar.TabIndex = 8;
            this.btn_Confirmar.Text = "Comprar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Error.Location = new System.Drawing.Point(265, 12);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(138, 21);
            this.lbl_Error.TabIndex = 9;
            this.lbl_Error.Text = "Mensaje de error";
            this.lbl_Error.Visible = false;
            // 
            // dtg_Carrito
            // 
            this.dtg_Carrito.AllowUserToAddRows = false;
            this.dtg_Carrito.AllowUserToDeleteRows = false;
            this.dtg_Carrito.AllowUserToResizeColumns = false;
            this.dtg_Carrito.AllowUserToResizeRows = false;
            this.dtg_Carrito.AutoGenerateColumns = false;
            this.dtg_Carrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dtg_Carrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Carrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_Carrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Carrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn1,
            this.CantidadEnCarrito});
            this.dtg_Carrito.DataSource = this.productoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Carrito.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Carrito.EnableHeadersVisualStyles = false;
            this.dtg_Carrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(24)))));
            this.dtg_Carrito.Location = new System.Drawing.Point(484, 41);
            this.dtg_Carrito.MultiSelect = false;
            this.dtg_Carrito.Name = "dtg_Carrito";
            this.dtg_Carrito.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Carrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtg_Carrito.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_Carrito.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtg_Carrito.RowTemplate.Height = 25;
            this.dtg_Carrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Carrito.Size = new System.Drawing.Size(304, 227);
            this.dtg_Carrito.TabIndex = 10;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreDataGridViewTextBoxColumn1.Width = 120;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0,00";
            this.precioDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioDataGridViewTextBoxColumn1.Width = 70;
            // 
            // CantidadEnCarrito
            // 
            this.CantidadEnCarrito.DataPropertyName = "CantidadEnCarrito";
            this.CantidadEnCarrito.HeaderText = "Cantidad";
            this.CantidadEnCarrito.Name = "CantidadEnCarrito";
            this.CantidadEnCarrito.ReadOnly = true;
            this.CantidadEnCarrito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CantidadEnCarrito.Width = 60;
            // 
            // btn_VaciarCarrito
            // 
            this.btn_VaciarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_VaciarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VaciarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.btn_VaciarCarrito.FlatAppearance.BorderSize = 0;
            this.btn_VaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VaciarCarrito.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VaciarCarrito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_VaciarCarrito.Location = new System.Drawing.Point(719, 12);
            this.btn_VaciarCarrito.Margin = new System.Windows.Forms.Padding(0);
            this.btn_VaciarCarrito.Name = "btn_VaciarCarrito";
            this.btn_VaciarCarrito.Size = new System.Drawing.Size(69, 29);
            this.btn_VaciarCarrito.TabIndex = 11;
            this.btn_VaciarCarrito.Text = "Vaciar";
            this.btn_VaciarCarrito.UseVisualStyleBackColor = false;
            this.btn_VaciarCarrito.Click += new System.EventHandler(this.btn_VaciarCarrito_Click);
            // 
            // pan_Precio
            // 
            this.pan_Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pan_Precio.Controls.Add(this.lbl_Total);
            this.pan_Precio.Location = new System.Drawing.Point(484, 274);
            this.pan_Precio.Name = "pan_Precio";
            this.pan_Precio.Size = new System.Drawing.Size(304, 57);
            this.pan_Precio.TabIndex = 12;
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_Sacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sacar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.btn_Sacar.FlatAppearance.BorderSize = 0;
            this.btn_Sacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sacar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sacar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sacar.Location = new System.Drawing.Point(650, 12);
            this.btn_Sacar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(69, 29);
            this.btn_Sacar.TabIndex = 15;
            this.btn_Sacar.Text = "Sacar";
            this.btn_Sacar.UseVisualStyleBackColor = false;
            this.btn_Sacar.Click += new System.EventHandler(this.btn_Sacar_Click);
            // 
            // rad_Efectivo
            // 
            this.rad_Efectivo.AutoSize = true;
            this.rad_Efectivo.Checked = true;
            this.rad_Efectivo.ForeColor = System.Drawing.Color.White;
            this.rad_Efectivo.Location = new System.Drawing.Point(10, 10);
            this.rad_Efectivo.Name = "rad_Efectivo";
            this.rad_Efectivo.Size = new System.Drawing.Size(67, 19);
            this.rad_Efectivo.TabIndex = 17;
            this.rad_Efectivo.TabStop = true;
            this.rad_Efectivo.Text = "Efectivo";
            this.rad_Efectivo.UseVisualStyleBackColor = true;
            this.rad_Efectivo.CheckedChanged += new System.EventHandler(this.rad_Efectivo_CheckedChanged);
            // 
            // rad_MercadoPago
            // 
            this.rad_MercadoPago.AutoSize = true;
            this.rad_MercadoPago.ForeColor = System.Drawing.Color.White;
            this.rad_MercadoPago.Location = new System.Drawing.Point(10, 35);
            this.rad_MercadoPago.Name = "rad_MercadoPago";
            this.rad_MercadoPago.Size = new System.Drawing.Size(99, 19);
            this.rad_MercadoPago.TabIndex = 17;
            this.rad_MercadoPago.Text = "MercadoPago";
            this.rad_MercadoPago.UseVisualStyleBackColor = true;
            this.rad_MercadoPago.CheckedChanged += new System.EventHandler(this.rad_MercadoPago_CheckedChanged);
            // 
            // pnl_MetodoDePago
            // 
            this.pnl_MetodoDePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnl_MetodoDePago.Controls.Add(this.rad_MercadoPago);
            this.pnl_MetodoDePago.Controls.Add(this.rad_Efectivo);
            this.pnl_MetodoDePago.Location = new System.Drawing.Point(484, 337);
            this.pnl_MetodoDePago.Name = "pnl_MetodoDePago";
            this.pnl_MetodoDePago.Size = new System.Drawing.Size(110, 61);
            this.pnl_MetodoDePago.TabIndex = 16;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_MetodoDePago);
            this.Controls.Add(this.btn_Sacar);
            this.Controls.Add(this.pan_Precio);
            this.Controls.Add(this.btn_VaciarCarrito);
            this.Controls.Add(this.dtg_Carrito);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Carrito);
            this.Controls.Add(this.lbl_Menu);
            this.Controls.Add(this.dtg_Productos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompras";
            this.Text = "Sistema de Compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Carrito)).EndInit();
            this.pan_Precio.ResumeLayout(false);
            this.pan_Precio.PerformLayout();
            this.pnl_MetodoDePago.ResumeLayout(false);
            this.pnl_MetodoDePago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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