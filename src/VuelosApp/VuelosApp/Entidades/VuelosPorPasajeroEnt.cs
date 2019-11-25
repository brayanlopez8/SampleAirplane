using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VuelosApp.Entidades
{
    public class VuelosPorPasajeroEnt : DefectoEnt
    {
        public int IdAvion { get; set; }
        public virtual AvionesEnt VuelosEnt { get; set; }
        public int IdSilla { get; set; }
        public virtual SillasEnt SillasEnt { get; set; }

        public int IdVuelo { get; set; }
        public virtual VueloEnt VueloEnt { get; set; }

        public int IdPasajero { get; set; }

        public virtual PasajerosEnt PasajerosEnt { get; set; }

        public DateTime FechaCompra { get; set; }
        public DateTime FechaAsignacionSilla { get; set; }

    }
}
