using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01._Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string materialInput = Console.ReadLine();
            string magicInput = Console.ReadLine();

            Stack<int> materials = new Stack<int>(materialInput.Split(" ").Select(int.Parse));
            Queue<int> magic = new Queue<int>(magicInput.Split(" ").Select(int.Parse));
            int dolls = 0;
            int trains = 0;
            int bears = 0;
            int bikes = 0;
            bool areCrafted = false;

            while (magic.Count > 0 && materials.Count > 0)
            {
                
                int currMaterial = materials.Peek();
                int currMagic = magic.Peek();
                
                int product = currMagic * currMaterial;
                if (product == 150)
                {
                    dolls++;
                    materials.Pop();
                    magic.Dequeue();
                }
                else if (product == 250)
                {
                    trains++;
                    materials.Pop();
                    magic.Dequeue();
                }
                else if (product == 300)
                {
                    bears++;
                    materials.Pop();
                    magic.Dequeue();
                }
                else if (product == 400)
                {
                    bikes++;
                    materials.Pop();
                    magic.Dequeue();
                }
                else if (product < 0)
                {
                    int sum = currMaterial + currMagic;
                    materials.Pop();
                    magic.Dequeue();
                    materials.Push(sum);
                }
                else if (currMagic == 0||currMaterial==0)
                {
                    if(currMagic==0&&currMaterial==0)
                    {
                        materials.Pop();
                        magic.Dequeue();
                    }
                    else if(currMagic==0)
                    {
                        magic.Dequeue();
                    }
                    else
                    {
                        materials.Pop();
                    }
                }
                else if(product>0)
                {
                    magic.Dequeue();
                    currMaterial += 15;
                    materials.Pop();
                    materials.Push(currMaterial);
                }
                if (dolls >= 1 && trains >= 1 || bears >= 1 && bikes >= 1)
                {
                    areCrafted = true;

                }

            }
            if(areCrafted==true)
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if(materials.Any())
            {
                Console.WriteLine("Materials left: "+string.Join(", ",materials));
            } 
            if(magic.Any())
            {
                Console.WriteLine("Magic left: "+string.Join(", ",magic));
            }
            if(bikes>=1)
            {
                Console.WriteLine("Bicycle: "+bikes);
            }
            if(dolls>=1)
            {
                Console.WriteLine("Doll: "+dolls);
            }
            if(bears>=1)
            {
                Console.WriteLine("Teddy bear: "+ bears);
            }
            if(trains>=1)
            {
                Console.WriteLine("Wooden train: "+trains);
            }


        }
    }
}
