using peluqueria_el_cojo.Modelos;
using peluqueria_el_cojo.Utilidades;

namespace peluqueria_el_cojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Cliente cliente = new Cliente("Luis", "8091234567", TipoCliente.VIP);
            Empleado emp = new Empleado("Juan", "El duro", "001", "8091111111", Rol.Barbero, 10000, 0.10);

            Factura factura = new Factura(cliente, emp);

            factura.AgregarServicio(new CorteNormal());
            factura.AgregarServicio(new Degradado(2));
            factura.AgregarServicio(new Afeitado(true));

            string recibo = factura.GenerarRecibo();

            MessageBox.Show(recibo);
        }
    }
}
