using peluqueria_el_cojo.Modelos;

namespace peluqueria_el_cojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Servicio> servicios = new List<Servicio>();

            servicios.Add(new CorteNormal());
            servicios.Add(new Degradado(3));
            servicios.Add(new Afeitado(true));
            servicios.Add(new CorteCejas());

            double total = 0;

            foreach (var s in servicios)
            {
                total += s.CalcularPrecio();
            }

            MessageBox.Show($"Total: RD${total}");
        }
    }
}
