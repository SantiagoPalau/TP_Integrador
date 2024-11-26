namespace UI
{
    partial class Formulario3_Usuario_
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            cmbHorarios = new ComboBox();
            label3 = new Label();
            txtSeñaReserva = new TextBox();
            txtComensales = new TextBox();
            cmbMesas = new ComboBox();
            label4 = new Label();
            btnReserva = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(495, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(522, 391);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 77);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Reservas";
            // 
            // button1
            // 
            button1.Location = new Point(674, 44);
            button1.Name = "button1";
            button1.Size = new Size(96, 48);
            button1.TabIndex = 2;
            button1.Text = "Filtrar por usuario";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(800, 44);
            button2.Name = "button2";
            button2.Size = new Size(96, 48);
            button2.TabIndex = 3;
            button2.Text = "Sacar filtros";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 77);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "Realizar reserva";
            // 
            // cmbHorarios
            // 
            cmbHorarios.FormattingEnabled = true;
            cmbHorarios.Location = new Point(79, 161);
            cmbHorarios.Name = "cmbHorarios";
            cmbHorarios.Size = new Size(118, 23);
            cmbHorarios.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 143);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Horario";
            // 
            // txtSeñaReserva
            // 
            txtSeñaReserva.Location = new Point(79, 204);
            txtSeñaReserva.Name = "txtSeñaReserva";
            txtSeñaReserva.PlaceholderText = "Seña";
            txtSeñaReserva.Size = new Size(118, 23);
            txtSeñaReserva.TabIndex = 7;
            // 
            // txtComensales
            // 
            txtComensales.Location = new Point(79, 256);
            txtComensales.Name = "txtComensales";
            txtComensales.PlaceholderText = "Comensales";
            txtComensales.Size = new Size(121, 23);
            txtComensales.TabIndex = 8;
            // 
            // cmbMesas
            // 
            cmbMesas.FormattingEnabled = true;
            cmbMesas.Location = new Point(79, 309);
            cmbMesas.Name = "cmbMesas";
            cmbMesas.Size = new Size(118, 23);
            cmbMesas.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 291);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 10;
            label4.Text = "Mesas";
            // 
            // btnReserva
            // 
            btnReserva.Location = new Point(88, 362);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(90, 55);
            btnReserva.TabIndex = 11;
            btnReserva.Text = "Agregar Reserva";
            btnReserva.UseVisualStyleBackColor = true;
            btnReserva.Click += btnReserva_Click;
            // 
            // Formulario3_Usuario_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 624);
            Controls.Add(btnReserva);
            Controls.Add(label4);
            Controls.Add(cmbMesas);
            Controls.Add(txtComensales);
            Controls.Add(txtSeñaReserva);
            Controls.Add(label3);
            Controls.Add(cmbHorarios);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Formulario3_Usuario_";
            Text = "Formulario3_Usuario_";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private ComboBox cmbHorarios;
        private Label label3;
        private TextBox txtSeñaReserva;
        private TextBox txtComensales;
        private ComboBox cmbMesas;
        private Label label4;
        private Button btnReserva;
    }
}