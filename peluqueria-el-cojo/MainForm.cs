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


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
