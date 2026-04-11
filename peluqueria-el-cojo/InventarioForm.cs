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
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = new Producto(
                    txtCodigo.Text,
                    txtNombre.Text,
                    "General",
                    double.Parse(txtPrecio.Text),
                    double.Parse(txtCosto.Text),
                    int.Parse(txtStock.Text),
                    3
                );

                if (DatosGlobales.Productos.Contains(p))
                {
                    MessageBox.Show("Producto duplicado");
                    return;
                }

                DatosGlobales.Productos.Add(p);
                ActualizarGrid();

                MessageBox.Show("Producto agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ActualizarGrid()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = DatosGlobales.Productos;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
