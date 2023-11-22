using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class TipoCliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoCliente()
        {
            Id = 0;
            Nombre = string.Empty;
        }
        public TipoCliente(int id,string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
    }
}
