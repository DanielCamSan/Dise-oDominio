using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio_y_SOLID
{
    public abstract class Passenger
    {
        public int Ci { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal  Weight { get; set; }
        public int NumberOfFly { get; set; }
        public DateTime FlightDate { get; set; }
        public decimal LuggageWeight { get; set; }
    }
}
