namespace Vista
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Ventas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.lbl_TituloIngresos = new System.Windows.Forms.Label();
            this.lbl_IngresosTotales = new System.Windows.Forms.Label();
            this.lbl_TituloVentasTotales = new System.Windows.Forms.Label();
            this.lbl_VentasTotales = new System.Windows.Forms.Label();
            this.lbl_TituloComprador = new System.Windows.Forms.Label();
            this.lbl_CompradorFrecuente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Ventas
            // 
            this.dtg_Ventas.AllowUserToAddRows = false;
            this.dtg_Ventas.AllowUserToDeleteRows = false;
            this.dtg_Ventas.AllowUserToResizeColumns = false;
            this.dtg_Ventas.AllowUserToResizeRows = false;
            this.dtg_Ventas.AutoGenerateColumns = false;
            this.dtg_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dtg_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dtg_Ventas.DataSource = this.ventaBindingSource;
            this.dtg_Ventas.Location = new System.Drawing.Point(12, 12);
            this.dtg_Ventas.MultiSelect = false;
            this.dtg_Ventas.Name = "dtg_Ventas";
            this.dtg_Ventas.ReadOnly = true;
            this.dtg_Ventas.RowHeadersVisible = false;
            this.dtg_Ventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtg_Ventas.RowTemplate.Height = 25;
            this.dtg_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Ventas.Size = new System.Drawing.Size(308, 350);
            this.dtg_Ventas.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Comprador";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreClienteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreClienteDataGridViewTextBoxColumn.Width = 170;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0,00";
            this.valorTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Ingreso";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valorTotalDataGridViewTextBoxColumn.Width = 80;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(Entidades.Venta);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Borrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Borrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Borrar.Location = new System.Drawing.Point(12, 368);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(145, 33);
            this.btn_Borrar.TabIndex = 1;
            this.btn_Borrar.Text = "Borrar historial";
            this.btn_Borrar.UseVisualStyleBackColor = false;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // lbl_TituloIngresos
            // 
            this.lbl_TituloIngresos.AutoSize = true;
            this.lbl_TituloIngresos.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloIngresos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_TituloIngresos.Location = new System.Drawing.Point(343, 317);
            this.lbl_TituloIngresos.Name = "lbl_TituloIngresos";
            this.lbl_TituloIngresos.Size = new System.Drawing.Size(302, 45);
            this.lbl_TituloIngresos.TabIndex = 2;
            this.lbl_TituloIngresos.Text = "Ingresos totales: $ ";
            // 
            // lbl_IngresosTotales
            // 
            this.lbl_IngresosTotales.AutoSize = true;
            this.lbl_IngresosTotales.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IngresosTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(163)))), ((int)(((byte)(37)))));
            this.lbl_IngresosTotales.Location = new System.Drawing.Point(624, 317);
            this.lbl_IngresosTotales.Name = "lbl_IngresosTotales";
            this.lbl_IngresosTotales.Size = new System.Drawing.Size(38, 45);
            this.lbl_IngresosTotales.TabIndex = 3;
            this.lbl_IngresosTotales.Text = "0";
            // 
            // lbl_TituloVentasTotales
            // 
            this.lbl_TituloVentasTotales.AutoSize = true;
            this.lbl_TituloVentasTotales.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloVentasTotales.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_TituloVentasTotales.Location = new System.Drawing.Point(343, 255);
            this.lbl_TituloVentasTotales.Name = "lbl_TituloVentasTotales";
            this.lbl_TituloVentasTotales.Size = new System.Drawing.Size(176, 31);
            this.lbl_TituloVentasTotales.TabIndex = 4;
            this.lbl_TituloVentasTotales.Text = "Ventas totales: ";
            // 
            // lbl_VentasTotales
            // 
            this.lbl_VentasTotales.AutoSize = true;
            this.lbl_VentasTotales.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_VentasTotales.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_VentasTotales.Location = new System.Drawing.Point(510, 255);
            this.lbl_VentasTotales.Name = "lbl_VentasTotales";
            this.lbl_VentasTotales.Size = new System.Drawing.Size(27, 31);
            this.lbl_VentasTotales.TabIndex = 5;
            this.lbl_VentasTotales.Text = "0";
            // 
            // lbl_TituloComprador
            // 
            this.lbl_TituloComprador.AutoSize = true;
            this.lbl_TituloComprador.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloComprador.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_TituloComprador.Location = new System.Drawing.Point(343, 149);
            this.lbl_TituloComprador.Name = "lbl_TituloComprador";
            this.lbl_TituloComprador.Size = new System.Drawing.Size(304, 31);
            this.lbl_TituloComprador.TabIndex = 6;
            this.lbl_TituloComprador.Text = "Comprador más frecuente: ";
            // 
            // lbl_CompradorFrecuente
            // 
            this.lbl_CompradorFrecuente.AutoSize = true;
            this.lbl_CompradorFrecuente.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CompradorFrecuente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CompradorFrecuente.Location = new System.Drawing.Point(343, 180);
            this.lbl_CompradorFrecuente.Name = "lbl_CompradorFrecuente";
            this.lbl_CompradorFrecuente.Size = new System.Drawing.Size(102, 31);
            this.lbl_CompradorFrecuente.TabIndex = 7;
            this.lbl_CompradorFrecuente.Text = "Nombre";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_CompradorFrecuente);
            this.Controls.Add(this.lbl_TituloComprador);
            this.Controls.Add(this.lbl_VentasTotales);
            this.Controls.Add(this.lbl_TituloVentasTotales);
            this.Controls.Add(this.lbl_IngresosTotales);
            this.Controls.Add(this.lbl_TituloIngresos);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.dtg_Ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_Ventas;
        private Button btn_Borrar;
        private BindingSource ventaBindingSource;
        private Label lbl_TituloIngresos;
        private Label lbl_IngresosTotales;
        private Label lbl_TituloVentasTotales;
        private Label lbl_VentasTotales;
        private Label lbl_TituloComprador;
        private Label lbl_CompradorFrecuente;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}