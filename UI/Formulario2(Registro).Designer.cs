namespace UI
{
    partial class Formulario2_Registro_
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
            groupBox1 = new GroupBox();
            btnVolver = new Button();
            btnRegistrar = new Button();
            txtDireccionaRegistrar = new TextBox();
            txtTelefonoaRegistrar = new TextBox();
            txtApellidoaRegistrar = new TextBox();
            txtDNIaRegistrar = new TextBox();
            txtNombreaRegistrar = new TextBox();
            txtContraseña = new TextBox();
            txtRegistroUsuario = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtDireccionaRegistrar);
            groupBox1.Controls.Add(txtTelefonoaRegistrar);
            groupBox1.Controls.Add(txtApellidoaRegistrar);
            groupBox1.Controls.Add(txtDNIaRegistrar);
            groupBox1.Controls.Add(txtNombreaRegistrar);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(txtRegistroUsuario);
            groupBox1.Location = new Point(172, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 399);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de usuario";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(324, 316);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 52);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Ingresos de usuario";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(324, 187);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 52);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtDireccionaRegistrar
            // 
            txtDireccionaRegistrar.Location = new Point(90, 346);
            txtDireccionaRegistrar.Name = "txtDireccionaRegistrar";
            txtDireccionaRegistrar.PlaceholderText = "Direccion";
            txtDireccionaRegistrar.Size = new Size(170, 23);
            txtDireccionaRegistrar.TabIndex = 6;
            // 
            // txtTelefonoaRegistrar
            // 
            txtTelefonoaRegistrar.Location = new Point(93, 300);
            txtTelefonoaRegistrar.Name = "txtTelefonoaRegistrar";
            txtTelefonoaRegistrar.PlaceholderText = "Telefono";
            txtTelefonoaRegistrar.Size = new Size(167, 23);
            txtTelefonoaRegistrar.TabIndex = 5;
            // 
            // txtApellidoaRegistrar
            // 
            txtApellidoaRegistrar.Location = new Point(93, 259);
            txtApellidoaRegistrar.Name = "txtApellidoaRegistrar";
            txtApellidoaRegistrar.PlaceholderText = "Apellido";
            txtApellidoaRegistrar.Size = new Size(169, 23);
            txtApellidoaRegistrar.TabIndex = 4;
            // 
            // txtDNIaRegistrar
            // 
            txtDNIaRegistrar.Location = new Point(90, 74);
            txtDNIaRegistrar.Name = "txtDNIaRegistrar";
            txtDNIaRegistrar.PlaceholderText = "DNI";
            txtDNIaRegistrar.Size = new Size(172, 23);
            txtDNIaRegistrar.TabIndex = 3;
            // 
            // txtNombreaRegistrar
            // 
            txtNombreaRegistrar.Location = new Point(90, 216);
            txtNombreaRegistrar.Name = "txtNombreaRegistrar";
            txtNombreaRegistrar.PlaceholderText = "Nombre";
            txtNombreaRegistrar.Size = new Size(172, 23);
            txtNombreaRegistrar.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(93, 170);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(169, 23);
            txtContraseña.TabIndex = 1;
            // 
            // txtRegistroUsuario
            // 
            txtRegistroUsuario.Location = new Point(90, 124);
            txtRegistroUsuario.Name = "txtRegistroUsuario";
            txtRegistroUsuario.PlaceholderText = "Usuario";
            txtRegistroUsuario.Size = new Size(172, 23);
            txtRegistroUsuario.TabIndex = 0;
            // 
            // Formulario2_Registro_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Formulario2_Registro_";
            Text = "Formulario2_Registro_";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRegistroUsuario;
        private TextBox txtNombreaRegistrar;
        private TextBox txtContraseña;
        private TextBox txtDNIaRegistrar;
        private TextBox txtApellidoaRegistrar;
        private Button btnVolver;
        private Button btnRegistrar;
        private TextBox txtDireccionaRegistrar;
        private TextBox txtTelefonoaRegistrar;
    }
}