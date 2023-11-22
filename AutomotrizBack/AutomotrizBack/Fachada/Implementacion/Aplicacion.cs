
using AutomotrizBack.Datos.Implementacion;
using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using AutomotrizBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IFacturaDao dao;
        public Aplicacion()
        {
            dao=new FacturaDao();
        }

        public bool Borrar(int nro)
        {
            return dao.Borrar(nro);
        }

        public List<Autoparte> GetAutopartes()
        {
            return dao.ObtenerAutopartes();
        }

        public List<Cliente> GetClientes()
        {
            return dao.ObtenerClientes();
        }

        public List<Factura> GetFacturas(DateTime desde, DateTime hasta, int cliente)
        {
            return dao.ObtenerFacturasPorFiltros(desde,hasta,cliente);
        }

        public int ObtenerProximaFactura()
        {
            return dao.ObtenerProximaFactura();
        }

        public bool SaveFactura(Factura oFactura)
        {
            return dao.Crear(oFactura);
        }

        public Factura GetFactura(int nro)
        {
            return dao.ObtenerFacturaPorNro(nro);
        }

        public bool Actualizar(Factura oFactura)
        {
            return dao.Actualizar(oFactura);
        }
    }
}
