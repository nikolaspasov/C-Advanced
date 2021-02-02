using System;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            Car car = new Car(
                 "VW",
             "Golf 2",
            1992,
             200,
             200
            );

            Engine engine = new Engine(650, 1000);
            Tire[] tires = new Tire[]
            {
                new Tire(2008,1200),
                new Tire(2008,1200),
                new Tire(2008,1200),
                new Tire(2008,1200)
            };


        }
    }
}
