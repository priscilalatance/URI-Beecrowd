using System;
using static System.Console;

namespace TestePoligonosRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = ReadLine().Split(" ");
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
        
            WriteLine(a * b);
        }
    }
}
