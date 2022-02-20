using System;
using System.Collections.Generic;
using static System.Console;

namespace TesteLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lineFood = new List<string>();
            int line = int.Parse(ReadLine());
    
            for(int j = 0; j < line; j++)
            {
                string[] food = ReadLine().Split(" "); 

                for(int i = 0; i < food.Length; i++)
                {
                    if(!lineFood.Contains(food[i]))
                    {
                    lineFood.Add(food[i]);
                    }
                }

                lineFood.Sort();
                WriteLine(string.Join(" ", lineFood));
                lineFood.Clear();
            }
        }
    }
}
