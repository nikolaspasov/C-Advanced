using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Queue<int> effects = new Queue<int>
                (Console.ReadLine().Split(", ").Select(int.Parse).ToList());
            Stack<int> casings = new Stack<int>
                (Console.ReadLine().Split(", ").Select(int.Parse).ToList());

            int daturaCount = 0;
            int cherryCount = 0;
            int smokeDecoyCount = 0;
            int currCasing = 0;
            bool filledPouch = false;
           while(effects.Count>0&&casings.Count>0)
            {
                int currEffect = effects.Peek();
                
                if (currCasing <=0)
                {
                    currCasing = casings.Peek();
                   
                }
                if(daturaCount>=3&&cherryCount>=3&&smokeDecoyCount>=3)
                {
                    filledPouch = true;
                    break;
                }
               else if(currEffect+currCasing==40)
                {
                    daturaCount++;
                    effects.Dequeue();
                    casings.Pop();
                    currCasing = 0;
                }
                else if(currEffect+currCasing==60)
                {
                    cherryCount++;
                    effects.Dequeue();
                    casings.Pop();
                    currCasing = 0;

                }
                else if(currEffect+currCasing==120)
                {
                    smokeDecoyCount++;
                    effects.Dequeue();
                    casings.Pop();
                    currCasing = 0;

                }
                
                else if(currCasing>=0)
                {
                    currCasing -= 5;
                }
            }
           if(filledPouch==true)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
           else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            
            Console.Write("Bomb Effects: ");
            if (effects.Any())
            {
                Console.Write(string.Join(", ",effects));
            }
            else
            {
                Console.Write("empty");
            }
            Console.WriteLine();
            Console.Write("Bomb Casings: ");
            if (casings.Any())
            {
                Console.Write(string.Join(", ",casings));
            }
            else
            {
                Console.Write("empty");
            }
            Console.WriteLine();
            Console.WriteLine($"Cherry Bombs: {cherryCount}\nDatura Bombs: {daturaCount}\n" +
                $"Smoke Decoy Bombs: {smokeDecoyCount}");
        } 
    }
}
