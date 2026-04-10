namespace peluqueria_el_cojo
{
    partial class InventarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioForm));
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            txtStock = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtCosto = new TextBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(251, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(321, 150);
            dataGridView1.TabIndex = 50;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(489, 139);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(83, 34);
            btnAgregar.TabIndex = 49;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(323, 253);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 253);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 47;
            label3.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 226);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(55, 21);
            label1.TabIndex = 46;
            label1.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(323, 224);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(121, 23);
            txtCosto.TabIndex = 45;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(323, 195);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(246, 197);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 43;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(240, 168);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 42;
            label5.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(323, 166);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(121, 23);
            txtCodigo.TabIndex = 41;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(323, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 139);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 39;
            label2.Text = "Nombre";
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtCosto);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventarioForm";
            Text = "InventarioForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private TextBox txtStock;
        private Label label3;
        private Label label1;
        private TextBox txtCosto;
        private TextBox txtPrecio;
        private Label label4;
        private Label label5;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label label2;
    }
}