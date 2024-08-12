namespace ProyectoCliente
{
    partial class Login
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
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            btnDesconectar = new FontAwesome.Sharp.IconButton();
            btnConectarse = new FontAwesome.Sharp.IconButton();
            txtIdentificacion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblUsuario = new Label();
            panel2 = new Panel();
            btnConsultarPedido = new FontAwesome.Sharp.IconButton();
            btnRealizarPedido = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            lblEstado = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oswald", 11.25F);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 26);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la Aplicación Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnDesconectar);
            panel1.Controls.Add(btnConectarse);
            panel1.Controls.Add(txtIdentificacion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 124);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Oswald", 11.25F);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(87, 26);
            label6.TabIndex = 7;
            label6.Text = "Resorts-Uned";
            // 
            // btnDesconectar
            // 
            btnDesconectar.IconChar = FontAwesome.Sharp.IconChar.Lock;
            btnDesconectar.IconColor = Color.Black;
            btnDesconectar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDesconectar.IconSize = 18;
            btnDesconectar.ImageAlign = ContentAlignment.MiddleRight;
            btnDesconectar.Location = new Point(3, 89);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(186, 23);
            btnDesconectar.TabIndex = 6;
            btnDesconectar.Text = "Salir";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnConectarse
            // 
            btnConectarse.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            btnConectarse.IconColor = Color.Black;
            btnConectarse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConectarse.IconSize = 20;
            btnConectarse.ImageAlign = ContentAlignment.MiddleRight;
            btnConectarse.Location = new Point(195, 89);
            btnConectarse.Name = "btnConectarse";
            btnConectarse.Size = new Size(186, 23);
            btnConectarse.TabIndex = 5;
            btnConectarse.Text = "Conectarse";
            btnConectarse.UseVisualStyleBackColor = true;
            btnConectarse.Click += btnConectarse_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(195, 47);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(186, 23);
            txtIdentificacion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oswald", 11.25F);
            label3.Location = new Point(101, 44);
            label3.Name = "label3";
            label3.Size = new Size(88, 26);
            label3.TabIndex = 3;
            label3.Text = "Identificación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oswald", 11.25F);
            label2.Location = new Point(235, 18);
            label2.Name = "label2";
            label2.Size = new Size(84, 26);
            label2.TabIndex = 2;
            label2.Text = "Iniciar Sesión";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Oswald", 11.25F);
            lblUsuario.Location = new Point(248, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(17, 26);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "-";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnConsultarPedido);
            panel2.Controls.Add(btnRealizarPedido);
            panel2.Location = new Point(12, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 33);
            panel2.TabIndex = 5;
            // 
            // btnConsultarPedido
            // 
            btnConsultarPedido.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnConsultarPedido.IconColor = Color.Black;
            btnConsultarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultarPedido.IconSize = 25;
            btnConsultarPedido.ImageAlign = ContentAlignment.MiddleRight;
            btnConsultarPedido.Location = new Point(195, 3);
            btnConsultarPedido.Name = "btnConsultarPedido";
            btnConsultarPedido.Size = new Size(186, 26);
            btnConsultarPedido.TabIndex = 1;
            btnConsultarPedido.Text = "Consultar Pedidos";
            btnConsultarPedido.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultarPedido.UseVisualStyleBackColor = true;
            btnConsultarPedido.Click += btnConsultarPedido_Click;
            // 
            // btnRealizarPedido
            // 
            btnRealizarPedido.IconChar = FontAwesome.Sharp.IconChar.Opencart;
            btnRealizarPedido.IconColor = Color.Black;
            btnRealizarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRealizarPedido.IconSize = 30;
            btnRealizarPedido.ImageAlign = ContentAlignment.MiddleRight;
            btnRealizarPedido.Location = new Point(3, 3);
            btnRealizarPedido.Name = "btnRealizarPedido";
            btnRealizarPedido.Size = new Size(186, 26);
            btnRealizarPedido.TabIndex = 0;
            btnRealizarPedido.Text = "Realizar Pedidos";
            btnRealizarPedido.TextAlign = ContentAlignment.MiddleLeft;
            btnRealizarPedido.UseVisualStyleBackColor = true;
            btnRealizarPedido.Click += btnRealizarPedido_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oswald", 11.25F);
            label4.Location = new Point(16, 35);
            label4.Name = "label4";
            label4.Size = new Size(51, 26);
            label4.TabIndex = 6;
            label4.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Oswald", 11.25F);
            lblEstado.Location = new Point(92, 35);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(17, 26);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "-";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(419, 226);
            Controls.Add(lblEstado);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(lblUsuario);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnConectarse;
        private TextBox txtIdentificacion;
        private Label label3;
        private Label label2;
        private Label lblUsuario;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnConsultarPedido;
        private FontAwesome.Sharp.IconButton btnRealizarPedido;
        private Label label4;
        private Label lblEstado;
        private FontAwesome.Sharp.IconButton btnDesconectar;
        private DataGridView dgvClientes;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnVerClientes;
        private Label label6;
    }
}
