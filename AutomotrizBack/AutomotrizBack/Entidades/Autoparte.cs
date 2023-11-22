using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Autoparte
    {
        public int IdAutoparte { get; set; }
        public string NombreA { get; set; }
        public decimal PrecioA { get; set; }
        public TipoAutoparte TipoA { get; set; }
        public int StockMin { get; set; }
        public int StockAct { get; set; }

        public Autoparte()
        {
            IdAutoparte = 0;
            NombreA = string.Empty;
            TipoA = new TipoAutoparte();
            PrecioA = 0;
            StockMin = 0;
            StockAct = 0;
        }
        public Autoparte(int id_Autoparte, string nombreA,TipoAutoparte tipo ,decimal precio, int stock_min, int stock_act)
        {
            this.IdAutoparte = id_Autoparte;
            this.NombreA = nombreA;
            this.TipoA = tipo;
            this.PrecioA = precio;
            this.StockMin = stock_min;
            this.StockAct = stock_act;
        }
        public string toString()
        {
            return IdAutoparte + " / " + NombreA + " / " + PrecioA + " / " + StockMin + " / " + StockAct;
        }
    }
}