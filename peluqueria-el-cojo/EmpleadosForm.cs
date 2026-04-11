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
    public partial class EmpleadosForm : Form
    {
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private void EmpleadosForm_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Enum.GetValues(typeof(Rol));
            cmbRol.SelectedIndex = 0;
            ActualizarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado emp = new Empleado(
                    txtNombre.Text,
                    txtApodo.Text,
                    txtCedula.Text,
                    txtTelefono.Text,
                    (Rol)cmbRol.SelectedItem,
                    10000,
                    0.10
                );
                if (cmbRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol");
                    return;
                }

                DatosGlobales.Empleados.Add(emp);
                ActualizarGrid();

                MessageBox.Show("Empleado agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            DatosGlobales.Empleados.Sort();
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = DatosGlobales.Empleados;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
