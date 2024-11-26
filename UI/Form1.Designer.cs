namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtDNI = new TextBox();
            linkLabel1 = new LinkLabel();
            btnIngreso = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(btnIngreso);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.InfoText;
            groupBox1.Location = new Point(163, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingreso de Usuario";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(95, 144);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "DNI";
            txtDNI.Size = new Size(205, 23);
            txtDNI.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(117, 328);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(163, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Haz click aqui para registrarse";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnIngreso
            // 
            btnIngreso.Location = new Point(155, 270);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(79, 38);
            btnIngreso.TabIndex = 3;
            btnIngreso.Text = "Ingresar";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(95, 222);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(205, 23);
            txtContraseña.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(95, 183);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(205, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 105);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresar";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button btnIngreso;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private TextBox txtDNI;
    }
}
