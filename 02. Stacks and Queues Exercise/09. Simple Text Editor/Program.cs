using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<char> text = new Stack<char>();
            Stack<string> changes = new Stack<string>();
            string command = "";

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                
                if(command.Split()[0]=="1")
                {
                    string ElementsToAdd = command.Split()[1];
                    for (int j = 0; j < ElementsToAdd.Length; j++)
                    {
                        text.Push(ElementsToAdd[j]);
                    }
                }
                else if(command.Split()[0]=="2")
                {
                    int elementsToRemove = int.Parse(command.Split()[1]);
                    if (elementsToRemove <= text.Count)
                    {
                        for (int k = 0; k < elementsToRemove; k++)
                        {
                            text.Pop();
                        }
                    }
                }
                else if(command.Split()[0]=="3")
                {
                    int index = int.Parse(command.Split()[1]);
                    if (text.Count >= index)
                    {
                        string word = string.Join("", text);
                        StringBuilder sb = new StringBuilder();
                        for (int m = word.Length - 1; m >= 0; m--)
                        {
                            sb.Append(word[m]);
                        }


                        Console.WriteLine(sb[index - 1]);
                    }
                }
                else if(command.Split()[0]=="4")
                {
                    if (changes.Count > 1)
                    {
                        changes.Pop();
                        string lastChange = changes.Peek().ToString();
                        text.Clear();
                        for (int k = lastChange.Length - 1; k >= 0; k--)
                        {
                            text.Push(lastChange.ToString()[k]);
                        }
                    }
                   else if(changes.Count==1)
                    {
                        changes.Pop();
                        text.Clear();
                    }
                }
                if (command.Split()[0] == "1" || command.Split()[0] == "2")
                {
                    string currWord = string.Join("", text);
                    StringBuilder changesStringBuilder = new StringBuilder();
                    for (int o = 0; o < text.Count; o++)
                    {
                        changesStringBuilder.Append(currWord[o]);
                    }
                    changes.Push(string.Join("", text));
                }

            }
        }
    }
}
