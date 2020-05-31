using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_wstawianie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 4, 7, 9, 3, 6, 2, 99, 5, 2 };
            int n = tab.Length;
            int obecny;
            int nastepny;

            Console.WriteLine("Tablica przed sortowaniem: ");
            foreach (int x in tab)
                Console.Write(x + ",");
            
            for(int i = 1; i < n; i++)
            {
                obecny = tab[i];
                nastepny = i;
                while(nastepny > 0 && obecny < tab[nastepny - 1])
                {
                    tab[nastepny] = tab[nastepny - 1];
                    nastepny--;
                    
                }
                tab[nastepny] = obecny;

            }
            Console.WriteLine();
            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (int x in tab)
                Console.Write(x + ",");

            Console.ReadKey();
        }
    }
}
    