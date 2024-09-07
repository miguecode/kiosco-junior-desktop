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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lbl_Nombre = new Label();
            lbl_Contrasenia = new Label();
            btn_Ingresar = new Button();
            btn_Autocompletar = new Button();
            txt_Nombre = new TextBox();
            txt_Contrasenia = new TextBox();
            lbl_Error = new Label();
            pic_Login = new PictureBox();
            btn_IngresarAdmin = new Button();
            btn_Ver = new Button();
            btn_IngresarCliente = new Button();
            btn_IngresarEmpleado = new Button();
            lbl_IngresosRapidos = new Label();
            pan_Usuario = new Panel();
            pan_Contrasenia = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic_Login).BeginInit();
            SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.ForeColor = Color.White;
            lbl_Nombre.Location = new Point(137, 169);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(63, 20);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "Usuario";
            // 
            // lbl_Contrasenia
            // 
            lbl_Contrasenia.AutoSize = true;
            lbl_Contrasenia.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Contrasenia.ForeColor = Color.White;
            lbl_Contrasenia.Location = new Point(137, 228);
            lbl_Contrasenia.Name = "lbl_Contrasenia";
            lbl_Contrasenia.Size = new Size(88, 20);
            lbl_Contrasenia.TabIndex = 1;
            lbl_Contrasenia.Text = "Contraseña";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.FromArgb(24, 75, 171);
            btn_Ingresar.Cursor = Cursors.Hand;
            btn_Ingresar.FlatAppearance.BorderSize = 0;
            btn_Ingresar.FlatStyle = FlatStyle.Flat;
            btn_Ingresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = SystemColors.Control;
            btn_Ingresar.Location = new Point(378, 185);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(128, 54);
            btn_Ingresar.TabIndex = 2;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // btn_Autocompletar
            // 
            btn_Autocompletar.BackColor = Color.FromArgb(64, 105, 201);
            btn_Autocompletar.Cursor = Cursors.Hand;
            btn_Autocompletar.FlatAppearance.BorderSize = 0;
            btn_Autocompletar.FlatStyle = FlatStyle.Flat;
            btn_Autocompletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Autocompletar.ForeColor = SystemColors.Control;
            btn_Autocompletar.Location = new Point(378, 245);
            btn_Autocompletar.Name = "btn_Autocompletar";
            btn_Autocompletar.Size = new Size(128, 38);
            btn_Autocompletar.TabIndex = 3;
            btn_Autocompletar.Text = "Auto.";
            btn_Autocompletar.UseVisualStyleBackColor = false;
            btn_Autocompletar.Click += btn_Autocompletar_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.FromArgb(26, 26, 26);
            txt_Nombre.BorderStyle = BorderStyle.None;
            txt_Nombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(147, 192);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(153, 18);
            txt_Nombre.TabIndex = 4;
            // 
            // txt_Contrasenia
            // 
            txt_Contrasenia.BackColor = Color.FromArgb(26, 26, 26);
            txt_Contrasenia.BorderStyle = BorderStyle.None;
            txt_Contrasenia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contrasenia.ForeColor = Color.White;
            txt_Contrasenia.Location = new Point(147, 251);
            txt_Contrasenia.Name = "txt_Contrasenia";
            txt_Contrasenia.Size = new Size(153, 18);
            txt_Contrasenia.TabIndex = 5;
            txt_Contrasenia.UseSystemPasswordChar = true;
            // 
            // lbl_Error
            // 
            lbl_Error.AutoSize = true;
            lbl_Error.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Error.ForeColor = Color.FromArgb(172, 0, 0);
            lbl_Error.Location = new Point(137, 301);
            lbl_Error.Name = "lbl_Error";
            lbl_Error.Padding = new Padding(2);
            lbl_Error.Size = new Size(142, 25);
            lbl_Error.TabIndex = 6;
            lbl_Error.Text = "Mensaje de error";
            lbl_Error.Visible = false;
            // 
            // pic_Login
            // 
            pic_Login.Image = Properties.Resources.loginB;
            pic_Login.Location = new Point(184, 29);
            pic_Login.Name = "pic_Login";
            pic_Login.Size = new Size(131, 126);
            pic_Login.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Login.TabIndex = 7;
            pic_Login.TabStop = false;
            // 
            // btn_IngresarAdmin
            // 
            btn_IngresarAdmin.BackColor = Color.FromArgb(35, 35, 35);
            btn_IngresarAdmin.Cursor = Cursors.Hand;
            btn_IngresarAdmin.FlatAppearance.BorderColor = Color.FromArgb(24, 75, 171);
            btn_IngresarAdmin.FlatAppearance.BorderSize = 3;
            btn_IngresarAdmin.FlatStyle = FlatStyle.Flat;
            btn_IngresarAdmin.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_IngresarAdmin.ForeColor = SystemColors.ControlLightLight;
            btn_IngresarAdmin.Location = new Point(379, 52);
            btn_IngresarAdmin.Name = "btn_IngresarAdmin";
            btn_IngresarAdmin.Size = new Size(128, 30);
            btn_IngresarAdmin.TabIndex = 9;
            btn_IngresarAdmin.Text = "Admin.";
            btn_IngresarAdmin.UseVisualStyleBackColor = false;
            btn_IngresarAdmin.Click += btn_IngresarAdmin_Click;
            // 
            // btn_Ver
            // 
            btn_Ver.Cursor = Cursors.Hand;
            btn_Ver.FlatStyle = FlatStyle.Flat;
            btn_Ver.ForeColor = Color.White;
            btn_Ver.Location = new Point(306, 249);
            btn_Ver.Name = "btn_Ver";
            btn_Ver.Size = new Size(33, 23);
            btn_Ver.TabIndex = 10;
            btn_Ver.Text = "Ver";
            btn_Ver.UseVisualStyleBackColor = true;
            btn_Ver.Click += btn_Ver_Click;
            // 
            // btn_IngresarCliente
            // 
            btn_IngresarCliente.BackColor = Color.FromArgb(35, 35, 35);
            btn_IngresarCliente.Cursor = Cursors.Hand;
            btn_IngresarCliente.FlatAppearance.BorderColor = Color.FromArgb(24, 75, 171);
            btn_IngresarCliente.FlatAppearance.BorderSize = 3;
            btn_IngresarCliente.FlatStyle = FlatStyle.Flat;
            btn_IngresarCliente.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_IngresarCliente.ForeColor = SystemColors.ControlLightLight;
            btn_IngresarCliente.Location = new Point(379, 125);
            btn_IngresarCliente.Name = "btn_IngresarCliente";
            btn_IngresarCliente.Size = new Size(128, 30);
            btn_IngresarCliente.TabIndex = 11;
            btn_IngresarCliente.Text = "Cliente";
            btn_IngresarCliente.UseVisualStyleBackColor = false;
            btn_IngresarCliente.Click += btn_IngresarCliente_Click;
            // 
            // btn_IngresarEmpleado
            // 
            btn_IngresarEmpleado.BackColor = Color.FromArgb(35, 35, 35);
            btn_IngresarEmpleado.Cursor = Cursors.Hand;
            btn_IngresarEmpleado.FlatAppearance.BorderColor = Color.FromArgb(24, 75, 171);
            btn_IngresarEmpleado.FlatAppearance.BorderSize = 3;
            btn_IngresarEmpleado.FlatStyle = FlatStyle.Flat;
            btn_IngresarEmpleado.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_IngresarEmpleado.ForeColor = SystemColors.ControlLightLight;
            btn_IngresarEmpleado.Location = new Point(379, 88);
            btn_IngresarEmpleado.Name = "btn_IngresarEmpleado";
            btn_IngresarEmpleado.Size = new Size(128, 31);
            btn_IngresarEmpleado.TabIndex = 12;
            btn_IngresarEmpleado.Text = "Empleado";
            btn_IngresarEmpleado.UseVisualStyleBackColor = false;
            btn_IngresarEmpleado.Click += btn_IngresarEmpleado_Click;
            // 
            // lbl_IngresosRapidos
            // 
            lbl_IngresosRapidos.AutoSize = true;
            lbl_IngresosRapidos.BackColor = Color.FromArgb(26, 26, 26);
            lbl_IngresosRapidos.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IngresosRapidos.ForeColor = Color.White;
            lbl_IngresosRapidos.Location = new Point(378, 29);
            lbl_IngresosRapidos.Name = "lbl_IngresosRapidos";
            lbl_IngresosRapidos.Size = new Size(129, 20);
            lbl_IngresosRapidos.TabIndex = 13;
            lbl_IngresosRapidos.Text = "Ingresos Rápidos";
            // 
            // pan_Usuario
            // 
            pan_Usuario.BackColor = Color.White;
            pan_Usuario.Location = new Point(147, 216);
            pan_Usuario.Name = "pan_Usuario";
            pan_Usuario.Size = new Size(153, 1);
            pan_Usuario.TabIndex = 14;
            // 
            // pan_Contrasenia
            // 
            pan_Contrasenia.BackColor = Color.White;
            pan_Contrasenia.Location = new Point(147, 275);
            pan_Contrasenia.Name = "pan_Contrasenia";
            pan_Contrasenia.Size = new Size(153, 1);
            pan_Contrasenia.TabIndex = 15;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(642, 350);
            Controls.Add(pan_Contrasenia);
            Controls.Add(pan_Usuario);
            Controls.Add(lbl_IngresosRapidos);
            Controls.Add(btn_IngresarEmpleado);
            Controls.Add(btn_IngresarCliente);
            Controls.Add(btn_Ver);
            Controls.Add(btn_IngresarAdmin);
            Controls.Add(pic_Login);
            Controls.Add(lbl_Error);
            Controls.Add(txt_Contrasenia);
            Controls.Add(txt_Nombre);
            Controls.Add(btn_Autocompletar);
            Controls.Add(btn_Ingresar);
            Controls.Add(lbl_Contrasenia);
            Controls.Add(lbl_Nombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pic_Login).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btn_IngresarAdmin;
        private Button btn_Ver;
        private Button btn_IngresarCliente;
        private Button btn_IngresarEmpleado;
        private Label lbl_IngresosRapidos;
        private Panel pan_Usuario;
        private Panel pan_Contrasenia;
    }
}