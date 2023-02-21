using System;

namespace tridy_a_metody_4
{
    //Program s třídou a metodami pro výpočet obvodu a obsahu obdélníku

    class Program
    {
        static void Main(string[] args)
        {
            //Vytvoření objektu třídy Obdelnik
            Obdelnik obdelnik = new Obdelnik();

            //Zadání hodnoty strany a
            Console.Write("Zadejte hodnotu strany a: ");
            obdelnik.a = Convert.ToDouble(Console.ReadLine());

            //Zadání hodnoty strany b
            Console.Write("Zadejte hodnotu strany b: ");
            obdelnik.b = Convert.ToDouble(Console.ReadLine());

            //Výpočet obvodu a obsahu obdélníku
            obdelnik.VypocitejObvod();
            obdelnik.VypocitejObsah();

            //Výpis obvodu a obsahu obdélníku
            Console.WriteLine("Obvod obdélníku je: " + obdelnik.obvod);
            Console.WriteLine("Obsah obdélníku je: " + obdelnik.obsah);

            Console.ReadKey();
        }
    }

    //Třída Obdelnik
    class Obdelnik
    {
        //Proměnné třídy
        public double a;
        public double b;
        public double obvod;
        public double obsah;

        //Metoda pro výpočet obvodu obdélníku
        public void VypocitejObvod()
        {
            obvod = 2 * a + 2 * b;
        }

        //Metoda pro výpočet obsahu obdélníku
        public void VypocitejObsah()
        {
            obsah = a * b;
        }
    }

    
}