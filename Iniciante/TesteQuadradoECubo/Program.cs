using System;
using static System.Console;

namespace TesteQuadradoECubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(ReadLine());

            for (int i = 1; i <= number; i++)
            {
                
              WriteLine($"{i} {(Math.Pow(i, 2))} {(Math.Pow(i, 3))}");
                
            }
        }
    }
}
