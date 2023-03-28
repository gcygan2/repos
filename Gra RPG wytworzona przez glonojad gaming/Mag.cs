using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG_wytworzona_przez_glonojad_gaming
{
    class mag : Hero
    {
        public mag(string Nazwa, int HP, int Atak) : base(Nazwa, HP, Atak)
        {

        }
        int Moc = 4;
        public void odejmijHP()
        {
            HP -= Atak;
        }
        public int Pobierzsileataku()
        {
            return Atak += Moc / 5;
        }
    }
}
