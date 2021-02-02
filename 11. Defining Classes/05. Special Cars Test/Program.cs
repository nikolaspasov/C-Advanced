using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string tireCommand = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();
            while (tireCommand != "No more tires")
            {
                int tireYear1 = int.Parse(tireCommand.Split(" ")[0]);
                double tirePressure1 = double.Parse(tireCommand.Split(" ")[1]);
                int tireYear2 = int.Parse(tireCommand.Split(" ")[2]);
                double tirePressure2 = double.Parse(tireCommand.Split(" ")[3]);
                int tireYear3 = int.Parse(tireCommand.Split(" ")[4]);
                double tirePressure3 = double.Parse(tireCommand.Split(" ")[5]);
                int tireYear4 = int.Parse(tireCommand.Split(" ")[6]);
                double tirePressure4 = double.Parse(tireCommand.Split(" ")[7]);

                var currTire = new Tire[]
                {new Tire(tireYear1,tirePressure1),
                new Tire(tireYear2,tirePressure2),
                new Tire(tireYear3,tirePressure3),
                new Tire(tireYear4,tirePressure4)

                };
                tires.Add(currTire);
                tireCommand = Console.ReadLine();
            }

            string engineCommand = Console.ReadLine();
            List<Engine> engines = new List<Engine>();
            while (engineCommand != "Engines done")
            {
                int horsePower = int.Parse(engineCommand.Split(" ")[0]);
                double cubicCapacity = double.Parse(engineCommand.Split(" ")[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
                engineCommand = Console.ReadLine();
            }

            string carCommand = Console.ReadLine();
            List<Car> cars = new List<Car>();

            while (carCommand != "Show special")
            {
                string make = carCommand.Split(" ")[0];
                string model = carCommand.Split(" ")[1];
                int year = int.Parse(carCommand.Split(" ")[2]);
                double fuelQuantity = double.Parse(carCommand.Split(" ")[3]);
                double fuelConsumption = double.Parse(carCommand.Split(" ")[4]);
                int engineIndex = int.Parse(carCommand.Split(" ")[5]);
                int tiresIndex = int.Parse(carCommand.Split(" ")[6]);

                if ((engineIndex >= 0 && engineIndex < engines.Count)
                    && (tiresIndex >= 0 && tiresIndex < tires.Count))
                {
                    var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                    cars.Add(car);
                }
                carCommand = Console.ReadLine();
            }
            foreach (var car in cars.Where(x => x.Year >= 2017
            && x.Engine.HorsePower > 330
            && x.Tires.Sum(y => y.Pressure) >= 9
                && x.Tires.Sum(y => y.Pressure) <= 10).ToList())
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }

        }
    }
}
