namespace Vista
{
    partial class FrmAltaUsuario
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.lbl_Contrasenia = new System.Windows.Forms.Label();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_NombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_VerContrasenia = new System.Windows.Forms.Button();
            this.cmb_Rol = new System.Windows.Forms.ComboBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Nombre.Location = new System.Drawing.Point(36, 72);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(67, 20);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Apellido.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Apellido.Location = new System.Drawing.Point(36, 119);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(67, 20);
            this.lbl_Apellido.TabIndex = 1;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(332, 74);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(40, 20);
            this.lbl_NombreUsuario.TabIndex = 2;
            this.lbl_NombreUsuario.Text = "Nick";
            // 
            // lbl_Contrasenia
            // 
            this.lbl_Contrasenia.AutoSize = true;
            this.lbl_Contrasenia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contrasenia.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Contrasenia.Location = new System.Drawing.Point(284, 118);
            this.lbl_Contrasenia.Name = "lbl_Contrasenia";
            this.lbl_Contrasenia.Size = new System.Drawing.Size(88, 20);
            this.lbl_Contrasenia.TabIndex = 3;
            this.lbl_Contrasenia.Text = "Contraseña";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Dni.Location = new System.Drawing.Point(332, 27);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(37, 20);
            this.lbl_Dni.TabIndex = 4;
            this.lbl_Dni.Text = "DNI";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(112, 69);
            this.txt_Nombre.MaxLength = 14;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(151, 23);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(112, 116);
            this.txt_Apellido.MaxLength = 14;
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(151, 23);
            this.txt_Apellido.TabIndex = 6;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(381, 24);
            this.txt_Dni.MaxLength = 8;
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(151, 23);
            this.txt_Dni.TabIndex = 7;
            // 
            // txt_NombreDeUsuario
            // 
            this.txt_NombreDeUsuario.Location = new System.Drawing.Point(381, 72);
            this.txt_NombreDeUsuario.MaxLength = 16;
            this.txt_NombreDeUsuario.Name = "txt_NombreDeUsuario";
            this.txt_NombreDeUsuario.Size = new System.Drawing.Size(151, 23);
            this.txt_NombreDeUsuario.TabIndex = 8;
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.Location = new System.Drawing.Point(382, 115);
            this.txt_Contrasenia.MaxLength = 16;
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(151, 23);
            this.txt_Contrasenia.TabIndex = 9;
            this.txt_Contrasenia.UseSystemPasswordChar = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Error.Location = new System.Drawing.Point(36, 162);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(124, 19);
            this.lbl_Error.TabIndex = 10;
            this.lbl_Error.Text = "Mensaje de error";
            this.lbl_Error.Visible = false;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(136)))), ((int)(((byte)(4)))));
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Confirmar.Location = new System.Drawing.Point(393, 162);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(140, 45);
            this.btn_Confirmar.TabIndex = 11;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Cancelar.Location = new System.Drawing.Point(393, 213);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(140, 34);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_VerContrasenia
            // 
            this.btn_VerContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btn_VerContrasenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerContrasenia.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_VerContrasenia.Location = new System.Drawing.Point(539, 115);
            this.btn_VerContrasenia.Name = "btn_VerContrasenia";
            this.btn_VerContrasenia.Size = new System.Drawing.Size(38, 23);
            this.btn_VerContrasenia.TabIndex = 13;
            this.btn_VerContrasenia.Text = "Ver";
            this.btn_VerContrasenia.UseVisualStyleBackColor = false;
            this.btn_VerContrasenia.Click += new System.EventHandler(this.btn_VerContrasenia_Click);
            // 
            // cmb_Rol
            // 
            this.cmb_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rol.FormattingEnabled = true;
            this.cmb_Rol.Items.AddRange(new object[] {
            "SuperUsuario",
            "Empleado",
            "Cliente"});
            this.cmb_Rol.Location = new System.Drawing.Point(112, 24);
            this.cmb_Rol.MaxDropDownItems = 3;
            this.cmb_Rol.Name = "cmb_Rol";
            this.cmb_Rol.Size = new System.Drawing.Size(151, 23);
            this.cmb_Rol.TabIndex = 14;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Rol.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Rol.Location = new System.Drawing.Point(63, 27);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(32, 20);
            this.lbl_Rol.TabIndex = 15;
            this.lbl_Rol.Text = "Rol";
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(592, 318);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.cmb_Rol);
            this.Controls.Add(this.btn_VerContrasenia);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_NombreDeUsuario);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.lbl_Contrasenia);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Usuario";
            this.Load += new System.EventHandler(this.FrmAltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label lbl_NombreUsuario;
        private Label lbl_Contrasenia;
        private Label lbl_Dni;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Dni;
        private TextBox txt_NombreDeUsuario;
        private TextBox txt_Contrasenia;
        private Label lbl_Error;
        private Button btn_Confirmar;
        private Button btn_Cancelar;
        private Button btn_VerContrasenia;
        private ComboBox cmb_Rol;
        private Label lbl_Rol;
    }
}