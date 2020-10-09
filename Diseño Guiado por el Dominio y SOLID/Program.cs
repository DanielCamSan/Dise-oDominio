using Diseño_Guiado_por_el_Dominio_y_SOLID.Clases;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Diseño_Guiado_por_el_Dominio_y_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight flight1 = InitializeValues();

            foreach (var passenger in flight1.Passengers)
            {
                //Aqui se usa polimorfismo ya que dentro del assigndue se llama a los metodos y dependiendo del tipo de pasajero que sea 
                //Se realiza diferentes acciones y se asigna diferentes tarifas a la deuda
                Console.WriteLine($"\nDear Mr./Ms. {passenger.Name} enjoy the Flight\n");
                GetDue((IDue)passenger);
            }
            
            

        }

        private static Flight InitializeValues()
        {
            Flight flight = new Flight()
            {
                NumberOfFly = 1,
                Airline = "BOA",
                DepartureTime = new DateTime(2020, 7, 10),
                Pilot = "Boris",
                QuantityOfPassengers = 120
            };
            List<Passenger> Passengers = new List<Passenger>();
            decimal initialDue = 0;
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
            Passengers.Add(passenger1);
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
            Passengers.Add(passenger2);
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
            Passengers.Add(passenger3);
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
            Passengers.Add(passenger4);
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
            Passengers.Add(passenger5);
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
            Passengers.Add(passenger6);
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
            Passengers.Add(passenger7);
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
            Passengers.Add(passenger8);
            flight.Passengers = Passengers;
            return flight;
        }
        private static void GetDue(IDue pass)
        {
            pass.AddLuggageTax();
            pass.AddWeightTax();
            Console.WriteLine(pass.ServeFood());
            Console.WriteLine($"\n You have to pay {pass.TotalToPay()}\n------------------------------------\n");
        }
    }
}
