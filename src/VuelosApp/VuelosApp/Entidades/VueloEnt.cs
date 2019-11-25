using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuelosApp.Entidades
{
    public class VueloEnt: DefectoEnt
    {
        public DateTime FechaVuelo { get; set; }

        public string Origen { get; set; }
        public string Destino { get; set; }

    }
}
