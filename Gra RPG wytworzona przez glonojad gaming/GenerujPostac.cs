using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG_wytworzona_przez_glonojad_gaming
{
    public class GenerujPostac
    {
        public void GenerujSkalara()
        {
            mag mag = new mag("Mag", 8, 9);
        }
        public void GenerujBojownika()
        {
            wojownik wojownik = new wojownik("Wojownik", 70, 15);
        }
    }
}
