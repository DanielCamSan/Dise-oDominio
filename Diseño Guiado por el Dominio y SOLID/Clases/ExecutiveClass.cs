using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio_y_SOLID.Clases
{
    class ExecutiveClass : Passenger, IDue
    {
        private decimal _due;
        private decimal flightPrice = 800;
        private int MaxLuggageWeight = 50;

        public ExecutiveClass(decimal due)
        {
            _due = due;
        }
        public decimal TotalToPay()
        {
            return _due;
        }

        public void AddWeightTax()
        {
            _due = (Weight > 100) ? _due + flightPrice : _due + flightPrice * 2;
        }
        public void AddLuggageTax()
        {
            _due = (LuggageWeight < MaxLuggageWeight) ? _due + 12 : _due + 12 + 10 * Math.Truncate((LuggageWeight - MaxLuggageWeight));
        }
        public string ServeFood()
        {
            string food = "";
            food += ServeLunch();
            return food;
        }
        private string ServeLunch()
        {
            return "Enjoy our main plate, Golden Chicken!\n";
        }
    }
}
