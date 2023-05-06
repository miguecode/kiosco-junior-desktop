namespace Vista
{
    partial class FrmProductos
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
            this.dtg_Productos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AltaProducto = new System.Windows.Forms.Button();
            this.btn_BajaProducto = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Detalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Productos
            // 
            this.dtg_Productos.AllowUserToAddRows = false;
            this.dtg_Productos.AllowUserToDeleteRows = false;
            this.dtg_Productos.AllowUserToResizeColumns = false;
            this.dtg_Productos.AllowUserToResizeRows = false;
            this.dtg_Productos.AutoGenerateColumns = false;
            this.dtg_Productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.Tipo,
            this.marcaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dtg_Productos.DataSource = this.productoBindingSource;
            this.dtg_Productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.dtg_Productos.Location = new System.Drawing.Point(132, 12);
            this.dtg_Productos.MultiSelect = false;
            this.dtg_Productos.Name = "dtg_Productos";
            this.dtg_Productos.ReadOnly = true;
            this.dtg_Productos.RowHeadersVisible = false;
            this.dtg_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtg_Productos.RowTemplate.Height = 25;
            this.dtg_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Productos.Size = new System.Drawing.Size(606, 342);
            this.dtg_Productos.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Frozen = true;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.Frozen = true;
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "STOCK";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Entidades.Producto);
            // 
            // btn_AltaProducto
            // 
            this.btn_AltaProducto.Location = new System.Drawing.Point(22, 62);
            this.btn_AltaProducto.Name = "btn_AltaProducto";
            this.btn_AltaProducto.Size = new System.Drawing.Size(81, 63);
            this.btn_AltaProducto.TabIndex = 2;
            this.btn_AltaProducto.Text = "Agregar";
            this.btn_AltaProducto.UseVisualStyleBackColor = true;
            this.btn_AltaProducto.Click += new System.EventHandler(this.btn_AltaProducto_Click);
            // 
            // btn_BajaProducto
            // 
            this.btn_BajaProducto.Location = new System.Drawing.Point(22, 131);
            this.btn_BajaProducto.Name = "btn_BajaProducto";
            this.btn_BajaProducto.Size = new System.Drawing.Size(81, 63);
            this.btn_BajaProducto.TabIndex = 3;
            this.btn_BajaProducto.Text = "Eliminar";
            this.btn_BajaProducto.UseVisualStyleBackColor = true;
            this.btn_BajaProducto.Click += new System.EventHandler(this.btn_BajaProducto_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(22, 200);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(81, 63);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Detalles
            // 
            this.btn_Detalles.Location = new System.Drawing.Point(22, 269);
            this.btn_Detalles.Name = "btn_Detalles";
            this.btn_Detalles.Size = new System.Drawing.Size(81, 63);
            this.btn_Detalles.TabIndex = 5;
            this.btn_Detalles.Text = "Detalles";
            this.btn_Detalles.UseVisualStyleBackColor = true;
            this.btn_Detalles.Click += new System.EventHandler(this.btn_Detalles_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(761, 366);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Detalles);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_BajaProducto);
            this.Controls.Add(this.btn_AltaProducto);
            this.Controls.Add(this.dtg_Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductos";
            this.ShowIcon = false;
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtg_Productos;
        private Button btn_AltaProducto;
        private Button btn_BajaProducto;
        private BindingSource productoBindingSource;
        private Button btn_Modificar;
        private Button btn_Detalles;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}