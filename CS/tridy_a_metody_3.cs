//Syntaxe C#
using System;

namespace tridy_a_metody_3
{
    // Ukázka praktického použití statických metod
    // a statických proměnných

    // Třída pro práci s čísly
    class Cisla
    {
        // Statická proměnná pro počítání vytvořených instancí
        public static int pocet = 0;

        // Konstruktor
        public Cisla()
        {
            pocet++;
        }

        // Statická metoda pro výpočet faktoriálu
        public static int Faktorial(int cislo)
        {
            int vysledek = 1;
            for (int i = 1; i <= cislo; i++)
            {
                vysledek *= i;
            }
            return vysledek;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření dvou instancí třídy Cisla
            Cisla cislo1 = new Cisla();
            Cisla cislo2 = new Cisla();

            // Výpis počtu vytvořených instancí
            Console.WriteLine("Počet vytvořených instancí: {0}", Cisla.pocet);

            // Výpočet faktoriálu čísla 5
            Console.WriteLine("Faktoriál čísla 5 je: {0}", Cisla.Faktorial(5));

            Console.ReadKey();
        }
    }
        

}