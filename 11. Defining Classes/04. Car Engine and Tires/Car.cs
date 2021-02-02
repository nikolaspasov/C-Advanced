using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        {
            make = Make;
            model = Model;
            year = Year;
            fuelQuantity = FuelQuantity;
            fuelConsumption = FuelConsumption;
        }

        public Car(string make,string model,int year, double fuelQuantity, double fuelConsumption,
            Engine engine,Tire[] tires)
            : this(make,model,year,fuelQuantity,fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        
    }
}
