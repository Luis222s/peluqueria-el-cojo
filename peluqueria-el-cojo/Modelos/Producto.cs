using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peluqueria_el_cojo.Modelos
{
    public class Producto : IEquatable<Producto>, ICloneable
    {
        private string codigo;
        private string nombre;
        private string categoria;
        private double precio;
        private double costo;
        private int stock;
        private int stockMinimo;

        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Código inválido");
                codigo = value;
            }
        }

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

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Precio inválido");
                precio = value;
            }
        }

        public double Costo
        {
            get { return costo; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Costo inválido");
                costo = value;
            }
        }

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stock inválido");
                stock = value;
            }
        }

        public int StockMinimo
        {
            get { return stockMinimo; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stock mínimo inválido");
                stockMinimo = value;
            }
        }

        public Producto(string codigo, string nombre, string categoria, double precio, double costo, int stock, int stockMinimo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Costo = costo;
            Stock = stock;
            StockMinimo = stockMinimo;
        }

        public double CalcularGanancia()
        {
            return Precio - Costo;
        }

        public bool StockBajo()
        {
            return Stock <= StockMinimo;
        }

        public bool Equals(Producto otro)
        {
            if (otro == null) return false;
            return this.Codigo == otro.Codigo;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Producto);
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }

        public object Clone()
        {
            return new Producto(Codigo, Nombre, Categoria, Precio, Costo, Stock, StockMinimo);
        }
    }
}
