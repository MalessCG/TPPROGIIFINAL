using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoC { get; set; }
        
        public Cliente(int id,string nom, string ape, int tipo)
        {
            this.IdCliente = id;
            this.Nombre = nom;
            this.Apellido = ape; 
            this.TipoC = tipo;
        }
    }
}
