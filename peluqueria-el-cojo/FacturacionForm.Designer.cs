namespace peluqueria_el_cojo
{
    partial class FacturacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionForm));
            label5 = new Label();
            cmbClientes = new ComboBox();
            label1 = new Label();
            cmbEmpleados = new ComboBox();
            cmbServicios = new ComboBox();
            label2 = new Label();
            btnAgregarServicio = new Button();
            btnIniciarFactura = new Button();
            btnGenerarFactura = new Button();
            label3 = new Label();
            lblTotal = new Label();
            dgvServicios = new DataGridView();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(222, 144);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 41;
            label5.Text = "Cliente";
            label5.Click += label5_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(306, 142);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(121, 23);
            cmbClientes.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 182);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 43;
            label1.Text = "Empleado";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(306, 180);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(121, 23);
            cmbEmpleados.TabIndex = 42;
            // 
            // cmbServicios
            // 
            cmbServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(306, 220);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(121, 23);
            cmbServicios.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 222);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 45;
            label2.Text = "Servicios";
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarServicio.Location = new Point(449, 184);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(140, 34);
            btnAgregarServicio.TabIndex = 47;
            btnAgregarServicio.Text = "AgregarServicio";
            btnAgregarServicio.UseVisualStyleBackColor = true;
            btnAgregarServicio.Click += btnAgregarServicio_Click;
            // 
            // btnIniciarFactura
            // 
            btnIniciarFactura.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarFactura.Location = new Point(449, 144);
            btnIniciarFactura.Name = "btnIniciarFactura";
            btnIniciarFactura.Size = new Size(140, 34);
            btnIniciarFactura.TabIndex = 46;
            btnIniciarFactura.Text = "IniciarFactura";
            btnIniciarFactura.UseVisualStyleBackColor = true;
            btnIniciarFactura.Click += btnIniciarFactura_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarFactura.Location = new Point(449, 224);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(140, 34);
            btnGenerarFactura.TabIndex = 48;
            btnGenerarFactura.Text = "GenerarFactura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(468, 314);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 50;
            label3.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(468, 353);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 21);
            lblTotal.TabIndex = 51;
            lblTotal.Click += lblTotal_Click;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(222, 288);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.ReadOnly = true;
            dgvServicios.Size = new Size(240, 150);
            dgvServicios.TabIndex = 52;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(741, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FacturacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(dgvServicios);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(btnGenerarFactura);
            Controls.Add(btnAgregarServicio);
            Controls.Add(btnIniciarFactura);
            Controls.Add(label2);
            Controls.Add(cmbServicios);
            Controls.Add(label1);
            Controls.Add(cmbEmpleados);
            Controls.Add(label5);
            Controls.Add(cmbClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FacturacionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FacturacionForm";
            Load += FacturacionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private ComboBox cmbClientes;
        private Label label1;
        private ComboBox cmbEmpleados;
        private ComboBox cmbServicios;
        private Label label2;
        private Button btnAgregarServicio;
        private Button btnIniciarFactura;
        private Button btnGenerarFactura;
        private Label label3;
        private Label lblTotal;
        private DataGridView dgvServicios;
        private PictureBox pictureBox2;
    }
}