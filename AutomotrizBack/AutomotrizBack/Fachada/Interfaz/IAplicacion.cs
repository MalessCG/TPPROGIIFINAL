using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Fachada.Interfaz
{
    public interface IAplicacion
    {
        List<Autoparte> GetAutopartes();
        bool SaveFactura(Factura oFactura);
        List<Cliente> GetClientes();
        int ObtenerProximaFactura();
        List<Factura> GetFacturas(DateTime desde, DateTime hasta, int cliente);
        Factura GetFactura(int nro);
        bool Borrar(int nro);
        bool Actualizar(Factura oFactura);
    }
}
