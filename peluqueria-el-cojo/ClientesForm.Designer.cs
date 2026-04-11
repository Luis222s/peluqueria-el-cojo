namespace peluqueria_el_cojo
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            label3 = new Label();
            label5 = new Label();
            btnBuscar = new Button();
            cmbTipo = new ComboBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            btnAgregar = new Button();
            dgvClientes = new DataGridView();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(326, 237);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 16;
            label3.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 195);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 15;
            label5.Text = "Telefono";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(291, 285);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 34);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(387, 235);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(387, 193);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(121, 23);
            txtTelefono.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(387, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 156);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(425, 285);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(83, 34);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(251, 335);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(323, 150);
            dgvClientes.TabIndex = 18;
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
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 490);
            Controls.Add(pictureBox2);
            Controls.Add(dgvClientes);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(btnBuscar);
            Controls.Add(cmbTipo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientesForm";
            Load += ClientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label5;
        private Button btnBuscar;
        private ComboBox cmbTipo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label label2;
        private Button btnAgregar;
        private DataGridView dgvClientes;
        private PictureBox pictureBox2;
    }
}