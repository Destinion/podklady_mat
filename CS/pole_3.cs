//syntaxe c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //dvojrozmerné pole
            int[,] pole = new int[3, 3];

            //naplnění pole na pozici 0,0 hodnotou 1
            pole[0, 0] = 1;

            //naplnění pole na pozici 0,1 hodnotou 2
            pole[0, 1] = 2;


            //výpis pole
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(pole[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Vyhledání hodnoty v poli
            Console.WriteLine("Hodnota 2 se nachází na pozici: " + Array.IndexOf(pole, 2));

            //Seřazení pole
            Array.Sort(pole);

            //Největší hodnota v poli
            Console.WriteLine("Největší hodnota v poli je: " + pole[pole.Length - 1]);

            //Nejmenší hodnota v poli
            Console.WriteLine("Nejmenší hodnota v poli je: " + pole[0, 0]);

            //Seřazení pole od největšího po nejmenší
            Array.Reverse(pole);

            //Vyhledání hodnoty v poli
            Console.WriteLine("Hodnota 1 se nachází na pozici: " + Array.IndexOf(pole, 1));

            Console.ReadKey();
            
        }
    }
}