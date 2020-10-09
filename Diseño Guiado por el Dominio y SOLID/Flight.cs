using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio_y_SOLID
{
    public class Flight
    {
        public int NumberOfFly { get; set; }
        public DateTime DepartureTime { get; set; }
        public int QuantityOfPassengers { get; set; }
        public string Airline { get; set; }
        public string  Pilot { get; set; }
        public List<Passenger> Passengers { get; set; }
    }
}
