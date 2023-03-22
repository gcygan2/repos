using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG_wytworzona_przez_glonojad_gaming
{
    class wojownik : Hero
    {
        public wojownik(string Nazwa, int HP, int Atak) : base(Nazwa, HP, Atak)
        {

        }
        int Obrona = 7;
        public void odejmijHP()
        {
            int zyciedoodjecia = Atak - Obrona / 3;
        }
        public int Pobierzsileataku()
        {
            return Atak;
        }
    }
}
