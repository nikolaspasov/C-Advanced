using System;

namespace _05.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();

            string secondDate = Console.ReadLine();

            DateModifier dateDifference = new DateModifier();
            var days = dateDifference.GetDays(firstDate,secondDate);
            Console.WriteLine(days);
        }
    }
}
