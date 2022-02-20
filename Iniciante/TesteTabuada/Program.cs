using System;
using static System.Console;

namespace TesteTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());

            for (int i = 1; i <= 10; i++)
            {
              WriteLine($"{i} x {n} = {i * n}"); 
            }
        }
    }
}
