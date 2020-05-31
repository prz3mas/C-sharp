using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_wybieranie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 4, 2, 6, 9, 4, 2, 6, 1 };
            int min;
            int pocz;

            Console.WriteLine("Tablica przed sortowaniem: ");
            foreach (int x in tab)
                Console.Write("{0},", x);
            
            for(int i = 0;i < tab.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1;j < tab.Length; j++)
                {
                    if (tab[j] < tab[min])
                    {
                        min = j;
                    }
                }
              if (min != i)
                {
                    pocz = tab[i];
                    tab[i] = tab[min];
                    tab[min] = pocz;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (int x in tab)
                Console.Write("{0},", x);
            Console.ReadKey();

        }
    }
}
