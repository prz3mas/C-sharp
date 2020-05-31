using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_bąbelkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 4, 2, 7, 4, 8, 5, 2, 8 };
            int licznik = 0;

            Console.WriteLine("Tablica przed sortowaniem: ");
            foreach (int x in tab)
                Console.Write(x);
            Console.WriteLine();
            
            while (licznik < tab.Length - 1)
            {
            
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                    }
                }
                licznik++;
            }
            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (int x in tab)
                Console.Write(x);
            Console.ReadKey();
        }
    }
}
