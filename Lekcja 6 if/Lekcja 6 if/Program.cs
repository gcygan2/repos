using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_6_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wynik z testu (0-100):"); // 0-100
            int wynik = int.Parse(Console.ReadLine());

            if(wynik >90 && wynik <= 100)
            {
                Console.WriteLine($"Twój wynik to {wynik}, otrzymujesz 5");
            }
            else if (wynik > 75 && wynik <= 90)
            {
                Console.WriteLine($"Twój wynik to {wynik}, otrzymujesz 4");
            }
            else if (wynik > 50 && wynik <= 75)
            {
                Console.WriteLine($"Twój wynik to {wynik}, otrzymujesz 3");
            }
            else if (wynik > 30 && wynik <= 50)
            {
                Console.WriteLine($"Twój wynik to {wynik}, otrzymujesz 2");
            }
            else 
            {
                Console.WriteLine($"Twój wynik to {wynik}, otrzymujesz 1 (:");
            }


            Console.ReadLine();
        }
    }
}
