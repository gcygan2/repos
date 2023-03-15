using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liczby = new List<int>();

            float suma = 0;

            while (true)
            {
                Console.WriteLine("Podaj kolejną liczbę");
                int oc = int.Parse(Console.ReadLine());
                liczby.Add (oc);

                suma += oc;

                Console.WriteLine("Aktualna średnia {0}", suma / liczby.Count);
            }


            Console.ReadKey();
        }
    }
}
