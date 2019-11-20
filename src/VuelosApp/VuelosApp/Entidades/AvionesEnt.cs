using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuelosApp.Entidades
{
    public class AvionesEnt: DefectoEnt
    {
        public int NumeroSerie { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }
    }
}
