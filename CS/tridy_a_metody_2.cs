//Syntaxe C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tridy_a_metody_2
{
    //nestatická třída
    class TridaA
    {
        //statická metoda
        public static void MetodaA()
        {
            Console.WriteLine("MetodaA");
        }
        //nestatická metoda
        public void MetodaB()
        {
            Console.WriteLine("MetodaB");
        }
    }



    //statická třída
    static class TridaB
    {
        //statická metoda
        public static void MetodaA()
        {
            Console.WriteLine("MetodaA");
        }
        //nestatická metoda
        public void MetodaB()
        {
            Console.WriteLine("MetodaB");
        }
    }

    //veřejné metody
    class Program
    {
        static void Main(string[] args)
        {
            //statická třída
            TridaA.MetodaA();
            //nestatická třída
            TridaA tridaA = new TridaA();
            tridaA.MetodaB();

            //statická třída
            TridaB.MetodaA();
            //nestatická třída
            TridaB tridaB = new TridaB();
            tridaB.MetodaB();

            //volání statické metody
            TridaB.MetodaA();
            //volání nestatické metody
            TridaB.MetodaB();
            
            Console.ReadKey();
        }
    }
    // volání metod
    // MetodaA
    // MetodaB
    // MetodaA


    //call to non-static method 'TridaB.MetodaB()' from static context

}