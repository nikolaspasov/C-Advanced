using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Rabbits
{
    public class Rabbit
    {

        private Rabbit()
        {
            this.Available = true;
        }
        public Rabbit(string name, string species)
            :this()
        {
            Name = name;
            Species = species;
        }
        public override string ToString()
        {
            return $"Rabbit ({Species}): {Name}";
        }
        public string Name { get; set; }
        
        
        public string Species { get; set; }
        
        public bool Available { get; set; }

        
    }
}
