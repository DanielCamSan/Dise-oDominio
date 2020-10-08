using Diseño_Guiado_por_el_Dominio_y_SOLID.Clases;
using System;

namespace Diseño_Guiado_por_el_Dominio_y_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal initialDue=0;
            EconomyClass passenger1 = new EconomyClass(initialDue)
            {
                Ci = 5918928,
                Name = "Daniel",
                Age = 20,
                Weight = 64.5m,
                NumberOfFly = 1,
                FlightDate = new DateTime(2020, 7, 10),
                LuggageWeight = 48
            };
            EconomyClass passenger2 = new EconomyClass(initialDue)
            {
                Ci = 5918926,
                Name = "Paola",
                Age = 29,
                Weight = 48.6m,
                NumberOfFly = 1,
                FlightDate = new DateTime(2020, 7, 10),
                LuggageWeight = 60
            };
            EconomyClass passenger3 = new EconomyClass(initialDue)
            {
                Ci = 3723130,
                Name = "Danilo",
                Age = 48,
                Weight = 80.5m,
                NumberOfFly = 1,
                FlightDate = new DateTime(2020, 7, 10),
                LuggageWeight = 20
            };
            ExecutiveClass passenger4 = new ExecutiveClass(initialDue)
            {
                Ci = 4862518,
                Name = "Alan",
                Age = 28,
                Weight = 74.0m,
                NumberOfFly = 1,
                FlightDate = new DateTime(2020, 7, 10),
                LuggageWeight = 65
            };
            ExecutiveClass passenger5 = new ExecutiveClass(initialDue)
            {
                Ci = 4786856,
                Name = "Tyrese",
                Age = 18,
                Weight = 54.7m,
                NumberOfFly = 1,
                FlightDate = new DateTime(2020, 7, 10),
                LuggageWeight = 35
            };
            ExecutiveClass passenger6 = new ExecutiveClass(initialDue)
            {
                Ci = 78115,
                Name = "Gabriel",
                Age = 80,
                Weight = 50.5m,
                NumberOfFly = 1,
                FlightDate = new DateTime(2020, 7, 10),
                LuggageWeight = 65
            };
            FirstClass passenger7 = new FirstClass(initialDue)
            {
                Ci = 34880808,
                Name = "Maria",
                Age = 50,
                Weight = 48.9m,
                NumberOfFly = 1,
                FlightDate = new DateTime(2020, 7, 10),
                LuggageWeight = 60
            };
            FirstClass passenger8 = new FirstClass(initialDue)
            {
                Ci = 6859985,
                Name = "Tiago",
                Age = 26,
                Weight = 54.6m,
                NumberOfFly = 1,
                FlightDate = new DateTime(2020, 7, 10),
                LuggageWeight = 45
            };
            Console.WriteLine($"\nDear Mr{passenger1.Name} enjoy the Flight\n");
            AssignDue(passenger1);
            Console.WriteLine($"\nDear Mr{passenger2.Name} enjoy the Flight\n");
            AssignDue(passenger2);
            Console.WriteLine($"\nDear Mr{passenger3.Name} enjoy the Flight\n");
            AssignDue(passenger3);
            Console.WriteLine($"\nDear Mr{passenger4.Name} enjoy the Flight\n");
            AssignDue(passenger4);
            Console.WriteLine($"\nDear Mr{passenger5.Name} enjoy the Flight\n");
            AssignDue(passenger5);
            Console.WriteLine($"\nDear Mr{passenger6.Name} enjoy the Flight\n");
            AssignDue(passenger6);
            Console.WriteLine($"\nDear Mr{passenger7.Name} enjoy the Flight\n");
            AssignDue(passenger7);
            Console.WriteLine($"\nDear Mr{passenger8.Name} enjoy the Flight\n");
            AssignDue(passenger8);
        }
        private static void AssignDue(IDue pass)
        {
            pass.AddLuggageTax();
            pass.AddWeightTax();
            Console.WriteLine(pass.ServeFood());
            Console.WriteLine($"\n You have to pay {pass.TotalToPay()}\n------------------------------------\n");
        }
    }
}
