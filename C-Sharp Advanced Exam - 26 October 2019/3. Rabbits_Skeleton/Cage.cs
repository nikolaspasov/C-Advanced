using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
       

        private List<Rabbit> data;

        public string Name { get; set; }
        
        public int Capacity { get; set; }

        private Cage()
        {
            this.data = new List<Rabbit>();
        }
        public int Count { get { return data.Count; } }
        public Cage(string name,int capacity)
            :this()
        {
            Name = name;
            Capacity = capacity;
           
        }

        public void Add(Rabbit rabbit)
        {
            if(Capacity>=data.Count+1)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbitToRemove = data.FirstOrDefault(
                x => x.Name == name);
            if (rabbitToRemove != null)
            {
                data.Remove(rabbitToRemove);
                return true;
            }
            return false;
        }

        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(r => r.Species == species);
        }
        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbitToSell = data.FirstOrDefault(
                x => x.Name == name);
            if(rabbitToSell!=null)
            {
                rabbitToSell.Available = false;
                
            }
            return rabbitToSell;
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {

            Rabbit[] rabbits = data
                .Where(x => x.Species == species)
                .ToArray();
            foreach (var rabbit in rabbits)
            {
                rabbit.Available = false;
            }
            return rabbits;
            
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");
            foreach (var rabbit in this.data)
            {
                if (rabbit.Available == true||rabbit.Available==false)
                {
                    sb.AppendLine(rabbit.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
