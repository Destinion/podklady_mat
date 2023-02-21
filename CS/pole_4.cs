//syntaxe c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Textové pole
            string[] pole = new string[3];

            //naplnění pole
            pole[0] = "ahoj";
            pole[1] = "nazdar";
            pole[2] = "cau";

            //výpis pole
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine(pole[i]);
            }

            //Vyhledání hodnoty v poli
            Console.WriteLine("Hodnota nazdar se nachází na pozici: " + Array.IndexOf(pole, "nazdar"));

            //Výpis hodnoty na pozici 1
            Console.WriteLine("Hodnota na pozici 1 je: " + pole[1]);

            Console.ReadKey();
            
        }
    }
}