namespace CapaPresentacion
{
    partial class Consultar
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
            panel3 = new Panel();
            txtIdPedido = new TextBox();
            label1 = new Label();
            btnConsultarPorId = new Button();
            lblPrecio = new Label();
            label6 = new Label();
            btnConsultar = new Button();
            dgvPedido = new DataGridView();
            label7 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtIdPedido);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnConsultarPorId);
            panel3.Controls.Add(lblPrecio);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btnConsultar);
            panel3.Controls.Add(dgvPedido);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 345);
            panel3.TabIndex = 9;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(31, 310);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(100, 23);
            txtIdPedido.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oswald", 11.25F);
            label1.Location = new Point(9, 309);
            label1.Name = "label1";
            label1.Size = new Size(26, 26);
            label1.TabIndex = 33;
            label1.Text = "Id:";
            // 
            // btnConsultarPorId
            // 
            btnConsultarPorId.Location = new Point(137, 310);
            btnConsultarPorId.Name = "btnConsultarPorId";
            btnConsultarPorId.Size = new Size(239, 23);
            btnConsultarPorId.TabIndex = 32;
            btnConsultarPorId.Text = "Consultar por ID";
            btnConsultarPorId.UseVisualStyleBackColor = true;
            btnConsultarPorId.Click += btnConsultarPorId_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Oswald", 11.25F);
            lblPrecio.Location = new Point(102, 251);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(17, 26);
            lblPrecio.TabIndex = 30;
            lblPrecio.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Oswald", 11.25F);
            label6.Location = new Point(19, 251);
            label6.Name = "label6";
            label6.Size = new Size(77, 26);
            label6.TabIndex = 31;
            label6.Text = "Monto Total:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(9, 280);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(367, 23);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvPedido
            // 
            dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedido.BackgroundColor = SystemColors.ButtonFace;
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Location = new Point(9, 36);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersVisible = false;
            dgvPedido.Size = new Size(367, 201);
            dgvPedido.TabIndex = 3;
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
            // Consultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 348);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Consultar";
            Text = "Consultar";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnConsultar;
        private DataGridView dgvPedido;
        private Label label7;
        private Label lblPrecio;
        private Label label6;
        private Label label1;
        private Button btnConsultarPorId;
        private TextBox txtIdPedido;
    }
}