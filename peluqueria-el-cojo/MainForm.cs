using peluqueria_el_cojo.Modelos;
using peluqueria_el_cojo.Utilidades;

namespace peluqueria_el_cojo
{
    public partial class Form1 : Form
    {
        private Usuario usuario;
        public Form1(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            if (usuario.Rol != Rol.Administrador)
            {
                btnEmpleados.Enabled = false;
                btnInventario.Enabled = false;
            }
            else
            {
                btnEmpleados.Enabled = true;
                btnInventario.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new ClientesForm().ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            new EmpleadosForm().ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            new InventarioForm().ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            new FacturacionForm().ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Bienvenido, " + usuario.Username;
        }
    }
}
