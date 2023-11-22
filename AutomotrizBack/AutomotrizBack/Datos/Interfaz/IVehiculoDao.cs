using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaz
{
    public interface IVehiculoDao
    {
        List<Vehiculo> ObtenerVehiculosPorFiltros(decimal desde,decimal hasta,int tipov);
        bool Crear(Vehiculo oVehiculo);
        List<TiposVehiculos> ObtenerTiposVehiculos();
        List<Color> ObtenerColores();
        bool Borrar(int nro);
        bool Actualizar(Vehiculo oVehiculo);

    }
}
