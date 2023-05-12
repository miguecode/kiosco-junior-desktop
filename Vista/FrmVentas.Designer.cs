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
            this.dtg_Ventas = new System.Windows.Forms.DataGridView();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.lbl_TituloIngresos = new System.Windows.Forms.Label();
            this.lbl_IngresosTotales = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtg_Ventas.Size = new System.Drawing.Size(313, 350);
            this.dtg_Ventas.TabIndex = 0;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(Entidades.Venta);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
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
            this.lbl_TituloIngresos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloIngresos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_TituloIngresos.Location = new System.Drawing.Point(343, 325);
            this.lbl_TituloIngresos.Name = "lbl_TituloIngresos";
            this.lbl_TituloIngresos.Size = new System.Drawing.Size(259, 37);
            this.lbl_TituloIngresos.TabIndex = 2;
            this.lbl_TituloIngresos.Text = "Ingresos totales: $ ";
            // 
            // lbl_IngresosTotales
            // 
            this.lbl_IngresosTotales.AutoSize = true;
            this.lbl_IngresosTotales.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IngresosTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(163)))), ((int)(((byte)(37)))));
            this.lbl_IngresosTotales.Location = new System.Drawing.Point(585, 325);
            this.lbl_IngresosTotales.Name = "lbl_IngresosTotales";
            this.lbl_IngresosTotales.Size = new System.Drawing.Size(33, 37);
            this.lbl_IngresosTotales.TabIndex = 3;
            this.lbl_IngresosTotales.Text = "0";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 60;
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
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Ingreso";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valorTotalDataGridViewTextBoxColumn.Width = 80;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.ControlBox = false;
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}