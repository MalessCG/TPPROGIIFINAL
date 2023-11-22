using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class TiposVehiculos
    {
        public int IdTipoV { get; set; }
        public string NombreTipoV { get; set; }

        public TiposVehiculos()
        {
            IdTipoV = 0;
            NombreTipoV = string.Empty; 
        }

        public override string ToString()
        {
            return NombreTipoV;
        }
    }
}
