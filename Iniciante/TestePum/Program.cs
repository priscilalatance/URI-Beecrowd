using System;
using static System.Console;

namespace TestePum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int primeiro = 1;
            for (int i = 1; i <= N; i++) {
            WriteLine($"{primeiro} {primeiro += 1} {primeiro += 1} PUM");
            primeiro += 2;
            }
        }
    }
}
