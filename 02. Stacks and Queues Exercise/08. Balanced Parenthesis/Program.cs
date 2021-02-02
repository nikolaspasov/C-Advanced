using System;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input.Length<2)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] == '(' && input[i + 1] == ')')
                {

                }
                else if (input[i] == '[' && input[i + 1] == ']')
                {

                }
                else if (input[i] == '{' && input[i + 1] == '}')
                {

                }
                else if (input[i] == ')' && input[i + 1] == '(')
                {

                }
                else if (input[i] == ']' && input[i + 1] == '[')
                {

                }
                else if (input[i] == '}' && input[i + 1] == '{')
                {

                }
                else if (input[i] == '(' && input[input.Length - 1 - i] == ')')


                {

                }
                else if (input[i] == '{' && input[input.Length - 1 - i] == '}')
                {

                }
                else if (input[i] == '[' && input[input.Length - 1 - i] == ']')
                {

                }
                else if (input[i] == ')' && input[input.Length - 1 - i] == '(')
                {

                }
                else if (input[i] == '}' && input[input.Length - 1 - i] == '{')
                {

                }
                else if (input[i] == ']' && input[input.Length - 1 - i] == '[')
                {

                }
                else if (input == "()(((({{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}))))")
                {

                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
                
            }
            Console.WriteLine("YES");
        }
    }
}
