using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class TipoAutoparte
    {
        public int IdTipoA { get; set; }
        public string NombreAutoparte { get; set; }

        public TipoAutoparte()
        {
            IdTipoA = 0;
            NombreAutoparte = string.Empty;
        }
        public override string ToString()
        {
            return NombreAutoparte;
        }
    }
}
