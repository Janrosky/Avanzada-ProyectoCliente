namespace CapaPresentacion
{
    partial class RealizarPedido
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
            panel2 = new Panel();
            label5 = new Label();
            dtp = new DateTimePicker();
            lblUsuario = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnAgregar = new Button();
            label3 = new Label();
            dgvArticulos = new DataGridView();
            cbHoteles = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            lblPrecio = new Label();
            label6 = new Label();
            btnRealizarPedido = new Button();
            dgvSeleccion = new DataGridView();
            label7 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeleccion).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dtp);
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 34);
            panel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Oswald", 11.25F);
            label5.Location = new Point(9, 1);
            label5.Name = "label5";
            label5.Size = new Size(43, 26);
            label5.TabIndex = 9;
            label5.Text = "Fecha";
            // 
            // dtp
            // 
            dtp.Location = new Point(58, 4);
            dtp.Name = "dtp";
            dtp.Size = new Size(76, 23);
            dtp.TabIndex = 8;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Oswald", 11.25F);
            lblUsuario.Location = new Point(576, 2);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(17, 26);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oswald", 11.25F);
            label4.Location = new Point(457, 2);
            label4.Name = "label4";
            label4.Size = new Size(103, 26);
            label4.TabIndex = 5;
            label4.Text = "Usuario Logeado:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dgvArticulos);
            panel1.Controls.Add(cbHoteles);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 294);
            panel1.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(9, 259);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(420, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar Al Pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oswald", 11.25F);
            label3.Location = new Point(119, 36);
            label3.Name = "label3";
            label3.Size = new Size(158, 26);
            label3.TabIndex = 4;
            label3.Text = "Articulos asociados al Hotel";
            // 
            // dgvArticulos
            // 
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticulos.BackgroundColor = SystemColors.ButtonFace;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(9, 65);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.Size = new Size(420, 188);
            dgvArticulos.TabIndex = 3;
            // 
            // cbHoteles
            // 
            cbHoteles.FormattingEnabled = true;
            cbHoteles.Location = new Point(73, 10);
            cbHoteles.Name = "cbHoteles";
            cbHoteles.Size = new Size(356, 23);
            cbHoteles.TabIndex = 1;
            cbHoteles.SelectedIndexChanged += cbHoteles_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oswald", 11.25F);
            label2.Location = new Point(15, 7);
            label2.Name = "label2";
            label2.Size = new Size(52, 26);
            label2.TabIndex = 0;
            label2.Text = "Hoteles";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblPrecio);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btnRealizarPedido);
            panel3.Controls.Add(dgvSeleccion);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(460, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 294);
            panel3.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Oswald", 11.25F);
            lblPrecio.Location = new Point(63, 230);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(17, 26);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Oswald", 11.25F);
            label6.Location = new Point(12, 230);
            label6.Name = "label6";
            label6.Size = new Size(45, 26);
            label6.TabIndex = 29;
            label6.Text = "Precio";
            // 
            // btnRealizarPedido
            // 
            btnRealizarPedido.Location = new Point(9, 259);
            btnRealizarPedido.Name = "btnRealizarPedido";
            btnRealizarPedido.Size = new Size(395, 23);
            btnRealizarPedido.TabIndex = 5;
            btnRealizarPedido.Text = "Realizar Pedido";
            btnRealizarPedido.UseVisualStyleBackColor = true;
            btnRealizarPedido.Click += btnRealizarPedido_Click;
            // 
            // dgvSeleccion
            // 
            dgvSeleccion.AllowUserToAddRows = false;
            dgvSeleccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSeleccion.BackgroundColor = SystemColors.ButtonFace;
            dgvSeleccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeleccion.Location = new Point(9, 36);
            dgvSeleccion.Name = "dgvSeleccion";
            dgvSeleccion.RowHeadersVisible = false;
            dgvSeleccion.Size = new Size(395, 190);
            dgvSeleccion.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Oswald", 11.25F);
            label7.Location = new Point(129, 7);
            label7.Name = "label7";
            label7.Size = new Size(134, 26);
            label7.TabIndex = 4;
            label7.Text = "Información del Pedido";
            // 
            // RealizarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 338);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RealizarPedido";
            Text = "Menu";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeleccion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label lblUsuario;
        private Label label4;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private DataGridView dgvArticulos;
        private Button btnAgregar;
        private Panel panel3;
        private Button btnRealizarPedido;
        private DataGridView dgvSeleccion;
        private Label label7;
        private ComboBox cbHoteles;
        private Label label5;
        private DateTimePicker dtp;
        private Label lblPrecio;
        private Label label6;
    }
}