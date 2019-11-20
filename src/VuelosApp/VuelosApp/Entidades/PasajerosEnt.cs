using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuelosApp.Entidades
{
    public class PasajerosEnt : DefectoEnt
    {
        public Decimal Identificacion { get; set; }
        public string Nombres { get; set; }
        public decimal NumeroCelular { get; set; }

        public string CorreoElectronico { get; set; }

    }
}
