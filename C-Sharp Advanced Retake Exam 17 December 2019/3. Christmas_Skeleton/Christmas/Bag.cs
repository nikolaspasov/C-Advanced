using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
   public class Bag
    {
        List<Present> data;

        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            data = new List<Present>();
        }
        public void Add(Present present)
        {
            if(Capacity>data.Count)
            {
                data.Add(present);
            }
        }
        public bool Remove(string name)
        {
            Present presentToRemove = data.FirstOrDefault(
                x => x.Name == name);
            if(presentToRemove!=null)
            {
                data.Remove(presentToRemove);
                return true;
            }
            return false;

        }
        public Present GetHeaviestPresent()
        {
            Present heaviest = data.OrderByDescending(
                x => x.Weight).FirstOrDefault();
            return heaviest;
            
        }
        public Present GetPresent(string name)
        {
            Present presentToGet = data.FirstOrDefault(x => x.Name == name);
            
               return presentToGet;
          
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Color} bag contains:");
            foreach (var present in data)
            {
                sb.AppendLine(present.ToString());
            }
            return sb.ToString().Trim();
        }


    }
}
