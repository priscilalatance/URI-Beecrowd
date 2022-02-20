using System;
using static System.Console;

namespace TesteNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, result = 0;
            value = int.Parse(ReadLine());
            int[] money = { 100, 50, 20, 10, 5, 2, 1};
            
            WriteLine(value);

            for(int counter = 0; counter < money.Length ; counter++)
            {
              result = value / money[counter];
              WriteLine($"{result} nota(s) de R$ {money[counter]:C2}");
              value %= money[counter];
            }
        }
    }
}
