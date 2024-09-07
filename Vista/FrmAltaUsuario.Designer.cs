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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaUsuario));
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            lbl_NombreUsuario = new Label();
            lbl_Contrasenia = new Label();
            lbl_Dni = new Label();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Dni = new TextBox();
            txt_NombreDeUsuario = new TextBox();
            txt_Contrasenia = new TextBox();
            lbl_Error = new Label();
            btn_Confirmar = new Button();
            btn_Cancelar = new Button();
            btn_VerContrasenia = new Button();
            cmb_Rol = new ComboBox();
            lbl_Rol = new Label();
            pan_Nombre = new Panel();
            pan_Apellido = new Panel();
            pan_Dni = new Panel();
            pan_NombreUsuario = new Panel();
            pan_Contrasenia = new Panel();
            SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.ForeColor = SystemColors.HighlightText;
            lbl_Nombre.Location = new Point(36, 72);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(67, 20);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Apellido.ForeColor = SystemColors.HighlightText;
            lbl_Apellido.Location = new Point(36, 119);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(67, 20);
            lbl_Apellido.TabIndex = 1;
            lbl_Apellido.Text = "Apellido";
            // 
            // lbl_NombreUsuario
            // 
            lbl_NombreUsuario.AutoSize = true;
            lbl_NombreUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreUsuario.ForeColor = SystemColors.HighlightText;
            lbl_NombreUsuario.Location = new Point(332, 74);
            lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            lbl_NombreUsuario.Size = new Size(40, 20);
            lbl_NombreUsuario.TabIndex = 2;
            lbl_NombreUsuario.Text = "Nick";
            // 
            // lbl_Contrasenia
            // 
            lbl_Contrasenia.AutoSize = true;
            lbl_Contrasenia.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Contrasenia.ForeColor = SystemColors.HighlightText;
            lbl_Contrasenia.Location = new Point(284, 118);
            lbl_Contrasenia.Name = "lbl_Contrasenia";
            lbl_Contrasenia.Size = new Size(88, 20);
            lbl_Contrasenia.TabIndex = 3;
            lbl_Contrasenia.Text = "Contraseña";
            // 
            // lbl_Dni
            // 
            lbl_Dni.AutoSize = true;
            lbl_Dni.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Dni.ForeColor = SystemColors.HighlightText;
            lbl_Dni.Location = new Point(332, 27);
            lbl_Dni.Name = "lbl_Dni";
            lbl_Dni.Size = new Size(37, 20);
            lbl_Dni.TabIndex = 4;
            lbl_Dni.Text = "DNI";
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.FromArgb(26, 26, 26);
            txt_Nombre.BorderStyle = BorderStyle.None;
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(112, 69);
            txt_Nombre.MaxLength = 14;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(151, 16);
            txt_Nombre.TabIndex = 5;
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.FromArgb(26, 26, 26);
            txt_Apellido.BorderStyle = BorderStyle.None;
            txt_Apellido.ForeColor = Color.White;
            txt_Apellido.Location = new Point(112, 116);
            txt_Apellido.MaxLength = 14;
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(151, 16);
            txt_Apellido.TabIndex = 6;
            // 
            // txt_Dni
            // 
            txt_Dni.BackColor = Color.FromArgb(26, 26, 26);
            txt_Dni.BorderStyle = BorderStyle.None;
            txt_Dni.ForeColor = Color.White;
            txt_Dni.Location = new Point(381, 24);
            txt_Dni.MaxLength = 8;
            txt_Dni.Name = "txt_Dni";
            txt_Dni.Size = new Size(151, 16);
            txt_Dni.TabIndex = 7;
            // 
            // txt_NombreDeUsuario
            // 
            txt_NombreDeUsuario.BackColor = Color.FromArgb(26, 26, 26);
            txt_NombreDeUsuario.BorderStyle = BorderStyle.None;
            txt_NombreDeUsuario.ForeColor = Color.White;
            txt_NombreDeUsuario.Location = new Point(381, 72);
            txt_NombreDeUsuario.MaxLength = 16;
            txt_NombreDeUsuario.Name = "txt_NombreDeUsuario";
            txt_NombreDeUsuario.Size = new Size(151, 16);
            txt_NombreDeUsuario.TabIndex = 8;
            // 
            // txt_Contrasenia
            // 
            txt_Contrasenia.BackColor = Color.FromArgb(26, 26, 26);
            txt_Contrasenia.BorderStyle = BorderStyle.None;
            txt_Contrasenia.ForeColor = Color.White;
            txt_Contrasenia.Location = new Point(382, 115);
            txt_Contrasenia.MaxLength = 16;
            txt_Contrasenia.Name = "txt_Contrasenia";
            txt_Contrasenia.Size = new Size(151, 16);
            txt_Contrasenia.TabIndex = 9;
            txt_Contrasenia.UseSystemPasswordChar = true;
            // 
            // lbl_Error
            // 
            lbl_Error.AutoSize = true;
            lbl_Error.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Error.ForeColor = Color.FromArgb(172, 0, 0);
            lbl_Error.Location = new Point(36, 162);
            lbl_Error.Name = "lbl_Error";
            lbl_Error.Size = new Size(124, 19);
            lbl_Error.TabIndex = 10;
            lbl_Error.Text = "Mensaje de error";
            lbl_Error.Visible = false;
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.FromArgb(67, 143, 16);
            btn_Confirmar.Cursor = Cursors.Hand;
            btn_Confirmar.FlatAppearance.BorderSize = 0;
            btn_Confirmar.FlatStyle = FlatStyle.Flat;
            btn_Confirmar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirmar.ForeColor = SystemColors.ButtonHighlight;
            btn_Confirmar.Location = new Point(393, 162);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(140, 45);
            btn_Confirmar.TabIndex = 11;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = false;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(164, 45, 0);
            btn_Cancelar.Cursor = Cursors.Hand;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cancelar.Location = new Point(393, 213);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(140, 34);
            btn_Cancelar.TabIndex = 12;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_VerContrasenia
            // 
            btn_VerContrasenia.BackColor = Color.FromArgb(26, 26, 26);
            btn_VerContrasenia.Cursor = Cursors.Hand;
            btn_VerContrasenia.FlatStyle = FlatStyle.Flat;
            btn_VerContrasenia.ForeColor = SystemColors.HighlightText;
            btn_VerContrasenia.Location = new Point(539, 116);
            btn_VerContrasenia.Name = "btn_VerContrasenia";
            btn_VerContrasenia.Size = new Size(38, 23);
            btn_VerContrasenia.TabIndex = 13;
            btn_VerContrasenia.Text = "Ver";
            btn_VerContrasenia.UseVisualStyleBackColor = false;
            btn_VerContrasenia.Click += btn_VerContrasenia_Click;
            // 
            // cmb_Rol
            // 
            cmb_Rol.BackColor = Color.FromArgb(26, 26, 26);
            cmb_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Rol.ForeColor = Color.White;
            cmb_Rol.FormattingEnabled = true;
            cmb_Rol.Items.AddRange(new object[] { "SuperUsuario", "Empleado", "Cliente" });
            cmb_Rol.Location = new Point(112, 24);
            cmb_Rol.MaxDropDownItems = 3;
            cmb_Rol.Name = "cmb_Rol";
            cmb_Rol.Size = new Size(151, 23);
            cmb_Rol.TabIndex = 14;
            // 
            // lbl_Rol
            // 
            lbl_Rol.AutoSize = true;
            lbl_Rol.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Rol.ForeColor = SystemColors.HighlightText;
            lbl_Rol.Location = new Point(63, 27);
            lbl_Rol.Name = "lbl_Rol";
            lbl_Rol.Size = new Size(32, 20);
            lbl_Rol.TabIndex = 15;
            lbl_Rol.Text = "Rol";
            // 
            // pan_Nombre
            // 
            pan_Nombre.BackColor = Color.White;
            pan_Nombre.Location = new Point(112, 91);
            pan_Nombre.Name = "pan_Nombre";
            pan_Nombre.Size = new Size(151, 1);
            pan_Nombre.TabIndex = 16;
            // 
            // pan_Apellido
            // 
            pan_Apellido.BackColor = Color.White;
            pan_Apellido.Location = new Point(112, 138);
            pan_Apellido.Name = "pan_Apellido";
            pan_Apellido.Size = new Size(151, 1);
            pan_Apellido.TabIndex = 17;
            // 
            // pan_Dni
            // 
            pan_Dni.BackColor = Color.White;
            pan_Dni.Location = new Point(382, 46);
            pan_Dni.Name = "pan_Dni";
            pan_Dni.Size = new Size(151, 1);
            pan_Dni.TabIndex = 18;
            // 
            // pan_NombreUsuario
            // 
            pan_NombreUsuario.BackColor = Color.White;
            pan_NombreUsuario.Location = new Point(382, 94);
            pan_NombreUsuario.Name = "pan_NombreUsuario";
            pan_NombreUsuario.Size = new Size(151, 1);
            pan_NombreUsuario.TabIndex = 19;
            // 
            // pan_Contrasenia
            // 
            pan_Contrasenia.BackColor = Color.White;
            pan_Contrasenia.Location = new Point(382, 137);
            pan_Contrasenia.Name = "pan_Contrasenia";
            pan_Contrasenia.Size = new Size(151, 1);
            pan_Contrasenia.TabIndex = 20;
            // 
            // FrmAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(592, 318);
            Controls.Add(pan_Contrasenia);
            Controls.Add(pan_NombreUsuario);
            Controls.Add(pan_Dni);
            Controls.Add(pan_Apellido);
            Controls.Add(pan_Nombre);
            Controls.Add(lbl_Rol);
            Controls.Add(cmb_Rol);
            Controls.Add(btn_VerContrasenia);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Confirmar);
            Controls.Add(lbl_Error);
            Controls.Add(txt_Contrasenia);
            Controls.Add(txt_NombreDeUsuario);
            Controls.Add(txt_Dni);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Dni);
            Controls.Add(lbl_Contrasenia);
            Controls.Add(lbl_NombreUsuario);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAltaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos del Usuario";
            Load += FrmAltaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Panel pan_Nombre;
        private Panel pan_Apellido;
        private Panel pan_Dni;
        private Panel pan_NombreUsuario;
        private Panel pan_Contrasenia;
    }
}