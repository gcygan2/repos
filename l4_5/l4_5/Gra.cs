using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4_5
{
    class Gra
    {
        private string nazwa;
        private decimal cena;

        public Gra(string nazwa, decimal cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }
        public override string ToString()
        {
            return $"Gra {nazwa} kosztuje {cena}";
        }
    }
}
