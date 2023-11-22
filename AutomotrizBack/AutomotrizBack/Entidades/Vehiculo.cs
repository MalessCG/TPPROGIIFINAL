using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Color Color { get; set; }
        public TiposVehiculos TipoV { get; set; }
        public decimal Precio { get; set; }
        public int Modelo { get; set; }

        public Vehiculo()
        {
            Id = 0;
            Nombre = string.Empty;
            Color = new Color();
            TipoV = new TiposVehiculos();
            Precio = 0;
            Modelo = 0;
        }
        public Vehiculo(int id, string nom,Color col,TiposVehiculos tipo,decimal precio, int mod)
        {
            this.Id = id;
            this.Nombre = nom;
            this.Color = col;
            this.TipoV = tipo;
            this.Precio = precio;
            this.Modelo = mod;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
