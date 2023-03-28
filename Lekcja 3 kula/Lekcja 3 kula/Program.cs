using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_3_kula
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Podaj promień kuli: ");
            double r = double.Parse(Console.ReadLine());
            double V = 4 * Math.PI * Math.Pow(r, 3)/3;
            Console.WriteLine("V kuli wynosi\n " + V);
            */
            Console.WriteLine("Podaj temp w Fahrenheitach: ");
            double Fahr = double.Parse(Console.ReadLine());
            double Cels = (Fahr-32) * 5 / 9;
            Console.WriteLine("Temp wynosi\n " + Cels);

            Console.ReadLine();
        }
    }
}
