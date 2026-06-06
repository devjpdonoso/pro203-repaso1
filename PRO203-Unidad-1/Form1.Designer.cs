namespace PRO203_Unidad_1
{
    partial class frmVideojuegos
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
            btnGuardar = new Button();
            txtHorasJugadas = new TextBox();
            label3 = new Label();
            txtCategoria = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtIdentificador = new TextBox();
            lblIdentificador = new Label();
            dgvJuegos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtHorasJugadas);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtIdentificador);
            groupBox1.Controls.Add(lblIdentificador);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Juego";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(380, 35);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtHorasJugadas
            // 
            txtHorasJugadas.Location = new Point(117, 156);
            txtHorasJugadas.Name = "txtHorasJugadas";
            txtHorasJugadas.Size = new Size(222, 23);
            txtHorasJugadas.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 159);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "Horas Jugadas";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(117, 118);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(222, 23);
            txtCategoria.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 121);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Categoria";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 23);
            txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 78);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtIdentificador
            // 
            txtIdentificador.Location = new Point(117, 33);
            txtIdentificador.Name = "txtIdentificador";
            txtIdentificador.Size = new Size(222, 23);
            txtIdentificador.TabIndex = 1;
            // 
            // lblIdentificador
            // 
            lblIdentificador.AutoSize = true;
            lblIdentificador.Location = new Point(22, 36);
            lblIdentificador.Name = "lblIdentificador";
            lblIdentificador.Size = new Size(74, 15);
            lblIdentificador.TabIndex = 0;
            lblIdentificador.Text = "Identificador";
            // 
            // dgvJuegos
            // 
            dgvJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJuegos.Location = new Point(12, 251);
            dgvJuegos.Name = "dgvJuegos";
            dgvJuegos.Size = new Size(696, 258);
            dgvJuegos.TabIndex = 1;
            dgvJuegos.CellClick += dgvJuegos_CellClick;
            // 
            // frmVideojuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(dgvJuegos);
            Controls.Add(groupBox1);
            Name = "frmVideojuegos";
            Text = "Administrador de Videojuegos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJuegos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIdentificador;
        private Label lblIdentificador;
        private Button btnGuardar;
        private TextBox txtHorasJugadas;
        private Label label3;
        private TextBox txtCategoria;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private DataGridView dgvJuegos;
    }
}
