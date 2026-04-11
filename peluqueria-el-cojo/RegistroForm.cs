using peluqueria_el_cojo.Modelos;
using peluqueria_el_cojo.Servicios;
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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Enum.GetValues(typeof(Rol));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            bool creado = AuthService.Registrar(
                txtUsuario.Text,
                txtPassword.Text,
                (Rol)cmbRol.SelectedItem);

            if (creado)
            {
                MessageBox.Show("Usuario creado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: usuario ya existe");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
        }
    }
}
