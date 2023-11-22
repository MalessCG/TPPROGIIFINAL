using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Factura
    {
        public int Nro { get; set; }
        public DateTime Fecha { get; set; }
        public int Cliente { get; set; }
        public List<DetalleFactura> ListaDetalles { get; set; }

        public Factura()
        {
            Nro = 0;
            Fecha = DateTime.Now;
            Cliente = 0;
            ListaDetalles = new List<DetalleFactura>();
        }

        public Factura(int nro,DateTime fecha,int cli)
        {
            this.Nro = nro;
            this.Fecha = fecha;
            this.Cliente = cli;
            this.ListaDetalles = new List<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura detalle)
        {
            ListaDetalles.Add(detalle);
        }

        public void QuitarDetalle(int nro)
        {
            ListaDetalles.RemoveAt(nro);
        }
    }
}
