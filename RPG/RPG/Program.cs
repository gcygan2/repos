using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratorPostaci generatorPostaci = new GeneratorPostaci();

            Console.WriteLine("Witaj w grze Wojownik vs Magowie");

            // tworzymy gracza i przeciwnika
            Wojownik gracz = generatorPostaci.GenerujWojownika();
            Mag przeciwnik = generatorPostaci.GenerujMaga();

            Console.WriteLine("Na swojej drodze spotkałeś przeciwnika.");
            przeciwnik.WyswietlStatystyki();

            Console.WriteLine("Czy chcesz zaatakować (wpisz: atak) czy uciekać (wpisz: ucieczka)");
            string odp = Console.ReadLine();
            if (odp != "atak")
            {
                Console.WriteLine("Uciekasz....");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Do ataku !!!");

            // walka toczy się dopóki zycie któregoś z graczy nie spadnie poniżej zera
            while (gracz.Hp >= 0 && przeciwnik.Hp >= 0)
            {
                // przeciwnik atakuje
                Console.WriteLine($"Gracz {przeciwnik.Nazwa} atakuje.");
                int atakPrzeciwnika = przeciwnik.PobierzSileAtaku();
                gracz.OdejmijHp(atakPrzeciwnika);
                Console.WriteLine($"Pozostało Ci {gracz.Hp} życia.\n");

                // sprawdzamy czy po ataku czasem nie zgineliśmy
                // jeżeli tak to kończymy walkę
                if (gracz.Hp <= 0)
                    break;

                // zatrzymujemy na pól sekundy program dla ciekawszego efektu
                System.Threading.Thread.Sleep(500);

                // my atakujemy
                Console.WriteLine($"Gracz {gracz.Nazwa} atakuje.");
                int atakGracza = gracz.PobierzSileAtaku();
                przeciwnik.OdejmijHp(atakGracza);
                Console.WriteLine($"Przeciwnikowi zostało {przeciwnik.Hp} życia.\n");

                // sprawdzamy czy po ataku czasem nie pokonaliśmy wroga
                // jeżeli tak to kończymy walkę
                if (przeciwnik.Hp <= 0)
                    break;

                // zatrzymujemy na pól sekundy program dla ciekawszego efektu
                System.Threading.Thread.Sleep(500);
            }

            if (gracz.Hp <= 0)
            {
                Console.WriteLine($"Niestety zostałeś pokonany. Przeciwnik {przeciwnik.Nazwa} wygrał.");
            }
            else
            {
                Console.WriteLine($"Gratulację. Pokonałeś przeciwnika {przeciwnik.Nazwa}");
            }

            Console.ReadKey();
        }
    }
}
