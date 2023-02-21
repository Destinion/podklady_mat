using System;

namespace tridy_a_metody_5
{
    // Systém zaměstnanců

    class Zamestnanec
    {
        public string jmeno;
        public string prijmeni;
        public string pozice;
        public int plat;

        public Zamestnanec(string jmeno, string prijmeni, string pozice, int plat) // konstruktor - vytvoří nový objekt
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.pozice = pozice;
            this.plat = plat;
        }

        public void ZvysPlat(int proc) // metoda - zvýší plat o zadaný procentuální podíl
        {
            plat += plat * proc / 100;
        }
        {
            plat += plat * proc / 100;
        }

        public void VypisInfo() // metoda - vypíše informace o zaměstnanci
        {
            Console.WriteLine("Jméno:" {0} {1}, jmeno, prijmeni);
            Console.WriteLine("Pozice: {0}", pozice);
            Console.WriteLine("Plat: {0}", plat);
        }
        
        public static void Main(string[] args)
        {
            Zamestnanec z1 = new Zamestnanec("Jan", "Novák", "vedoucí", 50000);
            Zamestnanec z2 = new Zame

            z1.VypisInfo();
            z2.VypisInfo();

            z1.ZvysPlat(10);
            z2.ZvysPlat(20);

            z1.VypisInfo();
            z2.VypisInfo();

            Console.ReadKey();
        }
    }
}