namespace Vista
{
    partial class FrmLogin
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
            this.lbl_Contrasenia = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Autocompletar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pic_Login = new System.Windows.Forms.PictureBox();
            this.lbl_Bienvenido = new System.Windows.Forms.Label();
            this.btn_IngresarAdmin = new System.Windows.Forms.Button();
            this.btn_Ver = new System.Windows.Forms.Button();
            this.btn_IngresarCliente = new System.Windows.Forms.Button();
            this.btn_IngresarEmpleado = new System.Windows.Forms.Button();
            this.lbl_IngresosRapidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(129, 163);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(67, 20);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Contrasenia
            // 
            this.lbl_Contrasenia.AutoSize = true;
            this.lbl_Contrasenia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contrasenia.ForeColor = System.Drawing.Color.White;
            this.lbl_Contrasenia.Location = new System.Drawing.Point(129, 220);
            this.lbl_Contrasenia.Name = "lbl_Contrasenia";
            this.lbl_Contrasenia.Size = new System.Drawing.Size(88, 20);
            this.lbl_Contrasenia.TabIndex = 1;
            this.lbl_Contrasenia.Text = "Contraseña";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ingresar.FlatAppearance.BorderSize = 0;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Ingresar.Location = new System.Drawing.Point(338, 168);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(128, 54);
            this.btn_Ingresar.TabIndex = 2;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_Autocompletar
            // 
            this.btn_Autocompletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(105)))), ((int)(((byte)(201)))));
            this.btn_Autocompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Autocompletar.FlatAppearance.BorderSize = 0;
            this.btn_Autocompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Autocompletar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Autocompletar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Autocompletar.Location = new System.Drawing.Point(338, 228);
            this.btn_Autocompletar.Name = "btn_Autocompletar";
            this.btn_Autocompletar.Size = new System.Drawing.Size(128, 38);
            this.btn_Autocompletar.TabIndex = 3;
            this.btn_Autocompletar.Text = "Auto.";
            this.btn_Autocompletar.UseVisualStyleBackColor = false;
            this.btn_Autocompletar.Click += new System.EventHandler(this.btn_Autocompletar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Nombre.Location = new System.Drawing.Point(129, 186);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(144, 23);
            this.txt_Nombre.TabIndex = 4;
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.Location = new System.Drawing.Point(129, 243);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(144, 23);
            this.txt_Contrasenia.TabIndex = 5;
            this.txt_Contrasenia.UseSystemPasswordChar = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.lbl_Error.Location = new System.Drawing.Point(129, 285);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Error.Size = new System.Drawing.Size(142, 25);
            this.lbl_Error.TabIndex = 6;
            this.lbl_Error.Text = "Mensaje de error";
            this.lbl_Error.Visible = false;
            // 
            // pic_Login
            // 
            this.pic_Login.Image = global::Vista.Properties.Resources.login;
            this.pic_Login.Location = new System.Drawing.Point(223, 31);
            this.pic_Login.Name = "pic_Login";
            this.pic_Login.Size = new System.Drawing.Size(126, 87);
            this.pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Login.TabIndex = 7;
            this.pic_Login.TabStop = false;
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bienvenido.ForeColor = System.Drawing.Color.White;
            this.lbl_Bienvenido.Location = new System.Drawing.Point(213, 121);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(145, 29);
            this.lbl_Bienvenido.TabIndex = 8;
            this.lbl_Bienvenido.Text = "BIENVENIDO";
            // 
            // btn_IngresarAdmin
            // 
            this.btn_IngresarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.btn_IngresarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IngresarAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btn_IngresarAdmin.FlatAppearance.BorderSize = 3;
            this.btn_IngresarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngresarAdmin.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_IngresarAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_IngresarAdmin.Location = new System.Drawing.Point(494, 54);
            this.btn_IngresarAdmin.Name = "btn_IngresarAdmin";
            this.btn_IngresarAdmin.Size = new System.Drawing.Size(128, 30);
            this.btn_IngresarAdmin.TabIndex = 9;
            this.btn_IngresarAdmin.Text = "Admin.";
            this.btn_IngresarAdmin.UseVisualStyleBackColor = false;
            this.btn_IngresarAdmin.Click += new System.EventHandler(this.btn_IngresarAdmin_Click);
            // 
            // btn_Ver
            // 
            this.btn_Ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ver.ForeColor = System.Drawing.Color.White;
            this.btn_Ver.Location = new System.Drawing.Point(279, 243);
            this.btn_Ver.Name = "btn_Ver";
            this.btn_Ver.Size = new System.Drawing.Size(33, 23);
            this.btn_Ver.TabIndex = 10;
            this.btn_Ver.Text = "Ver";
            this.btn_Ver.UseVisualStyleBackColor = true;
            this.btn_Ver.Click += new System.EventHandler(this.btn_Ver_Click);
            // 
            // btn_IngresarCliente
            // 
            this.btn_IngresarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.btn_IngresarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IngresarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_IngresarCliente.FlatAppearance.BorderSize = 3;
            this.btn_IngresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngresarCliente.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_IngresarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_IngresarCliente.Location = new System.Drawing.Point(494, 127);
            this.btn_IngresarCliente.Name = "btn_IngresarCliente";
            this.btn_IngresarCliente.Size = new System.Drawing.Size(128, 30);
            this.btn_IngresarCliente.TabIndex = 11;
            this.btn_IngresarCliente.Text = "Cliente";
            this.btn_IngresarCliente.UseVisualStyleBackColor = false;
            this.btn_IngresarCliente.Click += new System.EventHandler(this.btn_IngresarCliente_Click);
            // 
            // btn_IngresarEmpleado
            // 
            this.btn_IngresarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.btn_IngresarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IngresarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_IngresarEmpleado.FlatAppearance.BorderSize = 3;
            this.btn_IngresarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IngresarEmpleado.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_IngresarEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_IngresarEmpleado.Location = new System.Drawing.Point(494, 90);
            this.btn_IngresarEmpleado.Name = "btn_IngresarEmpleado";
            this.btn_IngresarEmpleado.Size = new System.Drawing.Size(128, 31);
            this.btn_IngresarEmpleado.TabIndex = 12;
            this.btn_IngresarEmpleado.Text = "Empleado";
            this.btn_IngresarEmpleado.UseVisualStyleBackColor = false;
            this.btn_IngresarEmpleado.Click += new System.EventHandler(this.btn_IngresarEmpleado_Click);
            // 
            // lbl_IngresosRapidos
            // 
            this.lbl_IngresosRapidos.AutoSize = true;
            this.lbl_IngresosRapidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbl_IngresosRapidos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IngresosRapidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(75)))), ((int)(((byte)(171)))));
            this.lbl_IngresosRapidos.Location = new System.Drawing.Point(493, 31);
            this.lbl_IngresosRapidos.Name = "lbl_IngresosRapidos";
            this.lbl_IngresosRapidos.Size = new System.Drawing.Size(129, 20);
            this.lbl_IngresosRapidos.TabIndex = 13;
            this.lbl_IngresosRapidos.Text = "Ingresos Rápidos";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(634, 335);
            this.Controls.Add(this.lbl_IngresosRapidos);
            this.Controls.Add(this.btn_IngresarEmpleado);
            this.Controls.Add(this.btn_IngresarCliente);
            this.Controls.Add(this.btn_Ver);
            this.Controls.Add(this.btn_IngresarAdmin);
            this.Controls.Add(this.lbl_Bienvenido);
            this.Controls.Add(this.pic_Login);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Autocompletar);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lbl_Contrasenia);
            this.Controls.Add(this.lbl_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nombre;
        private Label lbl_Contrasenia;
        private Button btn_Ingresar;
        private Button btn_Autocompletar;
        private TextBox txt_Nombre;
        private TextBox txt_Contrasenia;
        private Label lbl_Error;
        private PictureBox pic_Login;
        private Label lbl_Bienvenido;
        private Button btn_IngresarAdmin;
        private Button btn_Ver;
        private Button btn_IngresarCliente;
        private Button btn_IngresarEmpleado;
        private Label lbl_IngresosRapidos;
    }
}