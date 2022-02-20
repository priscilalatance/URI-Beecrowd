using System;
using static System.Console;
using System.Globalization;

namespace TesteTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] valor = ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if( a < b + c && b < a + c && c < a + b)
            {
              WriteLine($"Perimetro = {((a + b + c).ToString("0.0",CultureInfo.InvariantCulture))}");
            }
            else
            {
                WriteLine($"Area = {((a + b)*c/2).ToString("0.0",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
