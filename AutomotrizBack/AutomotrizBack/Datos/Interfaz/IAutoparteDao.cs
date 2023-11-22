using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaz
{
    public interface IAutoparteDao
    {
        List<Autoparte> ObtenerAutopartesPorFiltros(int stock, int tipoa);
        bool Crear(Autoparte oAutoparte);
        List<TipoAutoparte> ObtenerTiposA();
        bool Borrar(int nro);
        bool Actualizar(Autoparte oAutoparte);
    }
}
