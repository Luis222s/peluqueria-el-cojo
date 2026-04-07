using peluqueria_el_cojo.Modelos;

namespace peluqueria_el_cojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Producto> productos = new List<Producto>();

            Producto p1 = new Producto("001", "Gel", "Cabello", 200, 100, 10, 3);
            Producto p2 = new Producto("001", "Gel duplicado", "Cabello", 200, 100, 5, 3);

            if (p1.Equals(p2))
            {
                MessageBox.Show("Producto duplicado detectado");
            }

            Producto copia = (Producto)p1.Clone();
            MessageBox.Show($"Clonado: {copia.Nombre}");
        }
    }
}
