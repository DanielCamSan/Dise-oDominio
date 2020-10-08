using System;
using System.Collections.Generic;
using System.Text;

namespace Diseño_Guiado_por_el_Dominio_y_SOLID.Clases
{
    class FirstClass : Passenger, IDue
    {
        private decimal _due;
        private decimal flightPrice = 1200;
        private int MaxLuggageWeight = 100;

        public FirstClass(decimal due)
        {
            _due = due;
        }
        public decimal TotalToPay()
        {
            return _due;
        }

        public void AddWeightTax()
        {
            _due += flightPrice;
        }
        public void AddLuggageTax()
        {
            _due = (LuggageWeight < MaxLuggageWeight) ? _due + 12 : _due + 12 + 10 * Math.Truncate((LuggageWeight - MaxLuggageWeight));
        }
        public string ServeFood()
        {
            string food = "";
            food += ServeLunch();
            food += ServeDessert();
            food += ServeDrink();
            return food;
        }
        private string ServeLunch()
        {
            return "Enjoy our main plate, Golden Chicken!\n";
        }
        private string ServeDessert()
        {
            return "Enjoy the dessert, Ice Cream!\n";
        }
        private string ServeDrink()
        {
            return "Enjoy the drink, Miami Vice!\n";
        }
    }
}
