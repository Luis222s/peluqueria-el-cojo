using peluqueria_el_cojo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using peluqueria_el_cojo.Utilidades;

namespace peluqueria_el_cojo
{

    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetValues(typeof(TipoCliente));
            ActualizarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente(
                    txtNombre.Text,
                    txtTelefono.Text,
                    (TipoCliente)cmbTipo.SelectedItem
                );

                DatosGlobales.Clientes.Add(c);
                ActualizarGrid();

                MessageBox.Show("Cliente agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = DatosGlobales.Clientes;
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtNombre.Text;

            var resultado = DatosGlobales.Clientes
                .FindAll(c => c.Coincide(criterio));

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = resultado;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
