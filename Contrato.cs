using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Entidades
{
    internal class Contrato
    {
        public DateTime Data { get; set; }

        public double ValorPorHora { get; set; }

        public int Hora { get; set; }

        public Contrato()
        {

        }

        public Contrato(DateTime Data, double ValorPorHora, int Hora)
        {
            this.Data = Data;
            this.ValorPorHora = ValorPorHora;
            this.Hora = Hora;
        }

        public double ValorTotal()
        {
            return ValorPorHora * Hora;
        }
    }
}
