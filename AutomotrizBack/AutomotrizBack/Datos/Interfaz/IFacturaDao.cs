using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaz
{
    public interface IFacturaDao
    {
        List<Autoparte> ObtenerAutopartes();
        bool Crear(Factura oFactura);
        List<Cliente> ObtenerClientes();
        int ObtenerProximaFactura();
        bool Actualizar(Factura oFactura);
        bool Borrar(int nro);
        List<Factura> ObtenerFacturasPorFiltros(DateTime desde, DateTime hasta, int cliente);
        Factura ObtenerFacturaPorNro(int nro);

    }
}
