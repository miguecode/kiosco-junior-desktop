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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Productos = new System.Windows.Forms.DataGridView();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.lbl_Carrito = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.dtg_Carrito = new System.Windows.Forms.DataGridView();
            this.btn_VaciarCarrito = new System.Windows.Forms.Button();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Productos
            // 
            this.dtg_Productos.AllowUserToAddRows = false;
            this.dtg_Productos.AllowUserToDeleteRows = false;
            this.dtg_Productos.AllowUserToResizeColumns = false;
            this.dtg_Productos.AllowUserToResizeRows = false;
            this.dtg_Productos.AutoGenerateColumns = false;
            this.dtg_Productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(84)))));
            this.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.Stock});
            this.dtg_Productos.DataSource = this.productoBindingSource;
            this.dtg_Productos.GridColor = System.Drawing.Color.Black;
            this.dtg_Productos.Location = new System.Drawing.Point(12, 50);
            this.dtg_Productos.MultiSelect = false;
            this.dtg_Productos.Name = "dtg_Productos";
            this.dtg_Productos.ReadOnly = true;
            this.dtg_Productos.RowHeadersVisible = false;
            this.dtg_Productos.RowTemplate.Height = 25;
            this.dtg_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Productos.Size = new System.Drawing.Size(404, 300);
            this.dtg_Productos.TabIndex = 0;
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
            this.lbl_Menu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Menu.ForeColor = System.Drawing.Color.White;
            this.lbl_Menu.Location = new System.Drawing.Point(12, 10);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(90, 37);
            this.lbl_Menu.TabIndex = 2;
            this.lbl_Menu.Text = "Menú";
            // 
            // lbl_Carrito
            // 
            this.lbl_Carrito.AutoSize = true;
            this.lbl_Carrito.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Carrito.ForeColor = System.Drawing.Color.White;
            this.lbl_Carrito.Location = new System.Drawing.Point(484, 9);
            this.lbl_Carrito.Name = "lbl_Carrito";
            this.lbl_Carrito.Size = new System.Drawing.Size(107, 37);
            this.lbl_Carrito.TabIndex = 3;
            this.lbl_Carrito.Text = "Carrito";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(484, 279);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Padding = new System.Windows.Forms.Padding(20, 20, 50, 20);
            this.lbl_Total.Size = new System.Drawing.Size(300, 71);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "Precio TOTAL: $ 0,00";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(84)))));
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 5;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agregar.Location = new System.Drawing.Point(113, 356);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(303, 52);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "Agregar al carrito";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(24)))));
            this.btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Confirmar.FlatAppearance.BorderSize = 5;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_Confirmar.Location = new System.Drawing.Point(482, 352);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(304, 56);
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
            this.lbl_Error.Location = new System.Drawing.Point(263, 26);
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
            this.dtg_Carrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Carrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn1});
            this.dtg_Carrito.DataSource = this.productoBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Carrito.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Carrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtg_Carrito.Location = new System.Drawing.Point(484, 49);
            this.dtg_Carrito.MultiSelect = false;
            this.dtg_Carrito.Name = "dtg_Carrito";
            this.dtg_Carrito.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Carrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Carrito.RowHeadersVisible = false;
            this.dtg_Carrito.RowTemplate.Height = 25;
            this.dtg_Carrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Carrito.Size = new System.Drawing.Size(302, 227);
            this.dtg_Carrito.TabIndex = 10;
            // 
            // btn_VaciarCarrito
            // 
            this.btn_VaciarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(23)))), ((int)(((byte)(12)))));
            this.btn_VaciarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_VaciarCarrito.FlatAppearance.BorderSize = 0;
            this.btn_VaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VaciarCarrito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VaciarCarrito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_VaciarCarrito.Location = new System.Drawing.Point(715, 17);
            this.btn_VaciarCarrito.Margin = new System.Windows.Forms.Padding(0);
            this.btn_VaciarCarrito.Name = "btn_VaciarCarrito";
            this.btn_VaciarCarrito.Size = new System.Drawing.Size(69, 29);
            this.btn_VaciarCarrito.TabIndex = 11;
            this.btn_VaciarCarrito.Text = "Vaciar";
            this.btn_VaciarCarrito.UseVisualStyleBackColor = false;
            this.btn_VaciarCarrito.Click += new System.EventHandler(this.btn_VaciarCarrito_Click);
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0,00";
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Cantidad restante";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0,00";
            this.precioDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.ControlBox = false;
            this.Controls.Add(this.btn_VaciarCarrito);
            this.Controls.Add(this.dtg_Carrito);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Total);
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
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
    }
}