//syntaxe c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Třídy a metody
//Třída je datový typ, který obsahuje data a metody, které pracují s těmito daty.
//Metoda je funkce, která je součástí třídy.



namespace tridy_a_metody_1
{
    class Trida_1 //deklarace třídy
    {
        //deklarace proměnných
        int a;
        int b;
        int c;

        //deklarace metody
        public void Metoda_1()
        {
            Console.WriteLine("Metoda 1");
        }

        //deklarace metody
        public void Metoda_2()
        {
            Console.WriteLine("Metoda 2");
        }

        //deklarace metody
        public void Metoda_3()
        {
            Console.WriteLine("Metoda 3");
        }
        //Typy metod
        //Metody mohou být statické nebo nestatické.
        //Statické metody jsou přístupné bez vytvoření instance třídy.
        //Nestatické metody jsou přístupné pouze po vytvoření instance třídy.
        //Metody mohou být virtuální nebo abstraktní.

        //Virtuální metody jsou přepsatelné v potomcích.
        //Abstraktní metody jsou přepsatelné v potomcích a musí být přepsány v potomcích.
        //Metody mohou být přetížené.
        //Přetížené metody mají stejný název, ale různé parametry.
        //Přetížené metody se liší podle počtu parametrů, typu parametrů nebo pořadí parametrů.
        //Přetížené metody nemohou mít různý návratový typ.
        //Přetížené metody nemohou mít různý modifikátor přístupu.
        //Přetížené metody nemohou mít různý modifikátor statického člena.
        //Přetížené metody nemohou mít různý modifikátor přetížení.
        //Přetížené metody nemohou mít různý modifikátor přepsání.
        //Přetížené metody nemohou mít různý modifikátor abstraktního člena.
    
    }
}