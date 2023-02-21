//syntaxe c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pole_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //dvojrozmerné pole
            int[,] pole = new int[3, 3];

            //naplnění pole
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = i + j;
                }
            }

            //výpis pole
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(pole[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            
        }
    }
}