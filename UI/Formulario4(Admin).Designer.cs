namespace UI
{
    partial class Formulario4_Admin_
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
            dataGridView1 = new DataGridView();
            btnModificarSeña = new Button();
            txtIdReserva = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            btnEliminarMesa = new Button();
            btnAgregarMesa = new Button();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            button1 = new Button();
            btnEliminar = new Button();
            dataGridView3 = new DataGridView();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnModificarSeña);
            groupBox1.Controls.Add(txtIdReserva);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(38, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 467);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reservas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(304, 307);
            dataGridView1.TabIndex = 6;
            // 
            // btnModificarSeña
            // 
            btnModificarSeña.Location = new Point(111, 342);
            btnModificarSeña.Name = "btnModificarSeña";
            btnModificarSeña.Size = new Size(86, 42);
            btnModificarSeña.TabIndex = 3;
            btnModificarSeña.Text = "Modificar Seña";
            btnModificarSeña.UseVisualStyleBackColor = true;
            btnModificarSeña.Click += btnModificarSeña_Click;
            // 
            // txtIdReserva
            // 
            txtIdReserva.Location = new Point(83, 390);
            txtIdReserva.Name = "txtIdReserva";
            txtIdReserva.PlaceholderText = "ID de reserva";
            txtIdReserva.Size = new Size(145, 23);
            txtIdReserva.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 419);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Seña";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(btnEliminarMesa);
            groupBox2.Controls.Add(btnAgregarMesa);
            groupBox2.Location = new Point(420, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 467);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mesas";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(10, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(304, 307);
            dataGridView2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 390);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Cantidad de Asientos";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 390);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Numero de Mesa";
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 6;
            // 
            // btnEliminarMesa
            // 
            btnEliminarMesa.Location = new Point(210, 346);
            btnEliminarMesa.Name = "btnEliminarMesa";
            btnEliminarMesa.Size = new Size(80, 38);
            btnEliminarMesa.TabIndex = 8;
            btnEliminarMesa.Text = "Eliminar Mesa";
            btnEliminarMesa.UseVisualStyleBackColor = true;
            btnEliminarMesa.Click += btnEliminarMesa_Click;
            // 
            // btnAgregarMesa
            // 
            btnAgregarMesa.Location = new Point(54, 346);
            btnAgregarMesa.Name = "btnAgregarMesa";
            btnAgregarMesa.Size = new Size(80, 38);
            btnAgregarMesa.TabIndex = 7;
            btnAgregarMesa.Text = "Agregar Mesa";
            btnAgregarMesa.UseVisualStyleBackColor = true;
            btnAgregarMesa.Click += btnAgregarMesa_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(dataGridView3);
            groupBox3.Location = new Point(814, 67);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(319, 467);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Usuarios";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 392);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "DNI";
            textBox4.Size = new Size(162, 23);
            textBox4.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(193, 348);
            button1.Name = "button1";
            button1.Size = new Size(86, 38);
            button1.TabIndex = 12;
            button1.Text = "Establecer como Admin";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(37, 348);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 38);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar usuario";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 35);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(304, 307);
            dataGridView3.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(1105, 556);
            button2.Name = "button2";
            button2.Size = new Size(89, 55);
            button2.TabIndex = 3;
            button2.Text = "Volver a registro de usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Formulario4_Admin_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 623);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Formulario4_Admin_";
            Text = "Formulario4_Admin_";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnModificarSeña;
        private TextBox txtIdReserva;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnEliminarMesa;
        private Button btnAgregarMesa;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox3;
        private Button btnEliminar;
        private DataGridView dataGridView3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}