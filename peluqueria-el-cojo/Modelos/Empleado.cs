using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    public class Empleado : IComparable<Empleado>
    {
        private string nombre;
        private string apodo;
        private string cedula;
        private string telefono;
        private Rol rol;
        private double salarioBase;
        private double porcentajeComision;
        private double totalVentas;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nombre inválido");
                nombre = value;
            }
        }

        public string Apodo
        {
            get { return apodo; }
            set { apodo = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Cédula inválida");
                cedula = value;
            }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (value.Length != 10)
                    throw new ArgumentException("Teléfono inválido");
                telefono = value;
            }
        }

        public Rol Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public double SalarioBase
        {
            get { return salarioBase; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salario inválido");
                salarioBase = value;
            }
        }

        public double PorcentajeComision
        {
            get { return porcentajeComision; }
            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("Comisión inválida");
                porcentajeComision = value;
            }
        }

        public double TotalVentas
        {
            get { return totalVentas; }
            private set { totalVentas = value; }
        }

        public Empleado(string nombre, string apodo, string cedula, string telefono, Rol rol, double salarioBase, double porcentajeComision)
        {
            Nombre = nombre;
            Apodo = apodo;
            Cedula = cedula;
            Telefono = telefono;
            Rol = rol;
            SalarioBase = salarioBase;
            PorcentajeComision = porcentajeComision;
            TotalVentas = 0;
        }

        public void RegistrarVenta(double monto)
        {
            TotalVentas += monto;
        }

        public double CalcularSalario()
        {
            return SalarioBase + (TotalVentas * PorcentajeComision);
        }

        public int CompareTo(Empleado otro)
        {
            if (otro == null) return 1;
            return otro.TotalVentas.CompareTo(this.TotalVentas);
        }
    }
}

