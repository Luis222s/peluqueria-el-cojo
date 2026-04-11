using peluqueria_el_cojo.Modelos;
using peluqueria_el_cojo.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peluqueria_el_cojo
{
    public partial class FacturacionForm : Form
    {
        private Factura factura;
        public FacturacionForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void FacturacionForm_Load(object sender, EventArgs e)
        {
            cmbClientes.DataSource = DatosGlobales.Clientes;
            cmbClientes.DisplayMember = "Nombre";

            cmbEmpleados.DataSource = DatosGlobales.Empleados;
            cmbEmpleados.DisplayMember = "Nombre";

            cmbServicios.Items.Add("Corte Normal");
            cmbServicios.Items.Add("Degradado");
            cmbServicios.Items.Add("Afeitado");
            cmbServicios.Items.Add("Cejas");
        }

        private void btnIniciarFactura_Click(object sender, EventArgs e)
        {
            factura = new Factura(
                (Cliente)cmbClientes.SelectedItem,
                (Empleado)cmbEmpleados.SelectedItem
            );

            MessageBox.Show("Factura iniciada");
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (factura == null)
            {
                MessageBox.Show("Primero inicia la factura");
                return;
            }

            Servicio s = null;

            switch (cmbServicios.SelectedItem.ToString())
            {
                case "Corte Normal":
                    s = new CorteNormal();
                    break;
                case "Degradado":
                    s = new Degradado(2);
                    break;
                case "Afeitado":
                    s = new Afeitado(true);
                    break;
                case "Cejas":
                    s = new CorteCejas();
                    break;
            }

            factura.AgregarServicio(s);

            ActualizarGrid();

            lblTotal.Text = factura.CalcularTotal().ToString("0.00");
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (factura == null)
            {
                MessageBox.Show("No hay factura");
                return;
            }

            string recibo = factura.GenerarRecibo();

            MessageBox.Show(recibo);

            factura.RegistrarVenta();

            Backup.Guardar(recibo);
        }
        private void ActualizarGrid()
        {
            dgvServicios.DataSource = null;
            dgvServicios.DataSource = factura.Servicios;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
