using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public Autoparte Autoparte { get; set; }
        public DetalleFactura(Autoparte autoparte, int cantidad)
        {
            Id = 0;
            Cantidad = cantidad;
            Autoparte = autoparte;
        }

        public double CalcularSubTotal()
        {
            return Convert.ToDouble(Autoparte.PrecioA) * Cantidad;
        }
    }
}
