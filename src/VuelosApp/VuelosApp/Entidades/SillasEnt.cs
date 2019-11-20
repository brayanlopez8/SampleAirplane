using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuelosApp.Entidades
{
    public class SillasEnt: DefectoEnt
    {
        public int NumeroSilla { get; set; }

        public int IdAvion { get; set; }

        public virtual AvionesEnt AvionesEnt { get; set; }

    }
}
