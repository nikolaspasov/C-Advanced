using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make = "VW";
        public string Model = "Golf 2";
        public int Year = 1993;
        public double FuelQuantity = 200;
        public double FuelConsumption = 10;
        public Car()
        {
            Make = "VW";
            Model = "Golf 2";
            Year = 1993;
        }

        public Car(string make, string model, int year)
        
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        } 
        public Car(string make, string model, int year,
           double fuelQuantity, double fuelConsumption )
            :this(make,model,year)
       
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }


       

    }
}
