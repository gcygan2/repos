using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Gra> gry = new List<Gra>();
            Gra umierajaceSwiatlo = new Gra("Umierajace światło", 99.99m);
            gry.Add(umierajaceSwiatlo);
            Gra minecraft = new Gra("Minecraft", 99.99m);
            gry.Add(minecraft);
            foreach(Gra g in gry)
            {
                Console.WriteLine( g.ToString());
            }
            Console.ReadKey();
        }
    }
}
