using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG_wytworzona_przez_glonojad_gaming
{
    class Hero
    {
        public int HP = 100;
        public string Nazwa = "Glonojad";
        public int Atak = 10;

        public Hero(string nazwa, int HP, int Atak)
        {
            Nazwa = nazwa;
            this.HP = HP;
            this.Atak = Atak;
        }
        public void WyswietlStatysktyki()
        {
            Console.WriteLine($"Postać nazywa się {0}, posiada {1} życia, zabiera {2}", Nazwa, HP, Atak);
        }
    }
}
