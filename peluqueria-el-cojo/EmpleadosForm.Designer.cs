namespace peluqueria_el_cojo
{
    partial class EmpleadosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosForm));
            label3 = new Label();
            label5 = new Label();
            cmbRol = new ComboBox();
            txtApodo = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTelefono = new TextBox();
            txtCedula = new TextBox();
            label4 = new Label();
            btnAgregar = new Button();
            btnRanking = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 257);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 22;
            label3.Text = "Rol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(231, 170);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 21;
            label5.Text = "Apodo";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(314, 255);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 20;
            // 
            // txtApodo
            // 
            txtApodo.Location = new Point(314, 168);
            txtApodo.Name = "txtApodo";
            txtApodo.Size = new Size(121, 23);
            txtApodo.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(314, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 141);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 17;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 228);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 26;
            label1.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(314, 226);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(121, 23);
            txtTelefono.TabIndex = 25;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(314, 197);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(121, 23);
            txtCedula.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(228, 199);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 23;
            label4.Text = "Cedula";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(484, 197);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(83, 34);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnRanking
            // 
            btnRanking.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRanking.Location = new Point(484, 139);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(83, 34);
            btnRanking.TabIndex = 27;
            btnRanking.Text = "Rank";
            btnRanking.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(231, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(336, 150);
            dataGridView1.TabIndex = 29;
            // 
            // EmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(btnRanking);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(cmbRol);
            Controls.Add(txtApodo);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpleadosForm";
            Text = "EmpleadosForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label5;
        private ComboBox cmbRol;
        private TextBox txtApodo;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private TextBox txtTelefono;
        private TextBox txtCedula;
        private Label label4;
        private Button btnAgregar;
        private Button btnRanking;
        private DataGridView dataGridView1;
    }
}