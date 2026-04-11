namespace peluqueria_el_cojo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnClientes = new Button();
            btnEmpleados = new Button();
            btnInventario = new Button();
            btnFacturacion = new Button();
            lblNombre = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Gainsboro;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(22, 145);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(224, 35);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.Gainsboro;
            btnEmpleados.Cursor = Cursors.Hand;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.Location = new Point(22, 206);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(224, 35);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Gainsboro;
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.Location = new Point(22, 267);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(224, 35);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.BackColor = Color.Gainsboro;
            btnFacturacion.Cursor = Cursors.Hand;
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnFacturacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturacion.Location = new Point(22, 329);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(224, 35);
            btnFacturacion.TabIndex = 3;
            btnFacturacion.Text = "Facturacion";
            btnFacturacion.UseVisualStyleBackColor = false;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(302, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 37);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "label";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gainsboro;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(22, 403);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(224, 35);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar programa";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(lblNombre);
            Controls.Add(btnFacturacion);
            Controls.Add(btnInventario);
            Controls.Add(btnEmpleados);
            Controls.Add(btnClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnEmpleados;
        private Button btnInventario;
        private Button btnFacturacion;
        private Label lblNombre;
        private Button btnCerrar;
    }
}
