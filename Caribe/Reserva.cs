using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caribe
{
    class Reserva
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Fecha { get; set; }
        public string Tipo { get; set; }
        public int Asistentes { get; set; }
        public string TipoCocina { get; set; }
        public int Dias { get; set; }
        public string ReservarHabitaciones { get; set; }

        public Reserva()
        {
        }
    }
}
