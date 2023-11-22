using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Color
    {
        public int IdColor { get; set; }
        public string NombreColor { get; set; }

        public Color()
        {
            IdColor = 0;
            NombreColor = string.Empty;
        }

        public override string ToString()
        {
            return NombreColor;
        }
    }
}
