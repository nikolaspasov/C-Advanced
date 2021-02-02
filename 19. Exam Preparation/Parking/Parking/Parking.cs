using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public string Type { get; set; }
        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }
        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            Car carToRemove = data.FirstOrDefault(x =>
            x.Manufacturer == manufacturer
            && x.Model == model);
            if (carToRemove != null)
            {
                data.Remove(carToRemove);
                return true;
            }
            
                return false;
            
        }
        public Car GetLatestCar()
        {
            
            Car newestCar = 
                data.OrderByDescending(x => x.Year)
                .FirstOrDefault();
            return newestCar;
        }
        public Car GetCar(string manufacturer, string model)
        {
            Car validCar = data.FirstOrDefault(
                x => x.Manufacturer == manufacturer
                && x.Model == model);
            return validCar;
        }



        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in data)
            {
                sb.AppendLine($"{car.Manufacturer} {car.Model} ({car.Year})");
            }
            return sb.ToString();
        }
    }
}
