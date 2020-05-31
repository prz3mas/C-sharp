using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_szybki
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 2, 1, 5, 3, 4, 7, 6, 8, 2, 0 };

            Console.WriteLine("Tablica przed sortowaniem: ");
            foreach (int x in tab)
                Console.Write("{0} ,", x);
            Console.WriteLine();
            

            SzybkiSort(tab, 0, tab.Length -1);

            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (int x in tab)
                Console.Write("{0} ,", x);

            Console.ReadKey();
        }
        static void SzybkiSort(int [] tab, int lewy,int prawy)
        {
            if (lewy >= prawy)
                return;
            int pivot = tab[prawy];
            int granica = lewy - 1;
            int licznik = lewy;

            while(licznik < prawy)
            {
                if(tab[licznik] < pivot)
                {
                    granica++;
                    if(granica != licznik)
                    {
                        Swap(tab, granica, licznik);
                    }
                }
                licznik++;

            }
            granica++;
            if(granica != prawy)
            {
                Swap(tab, granica, prawy);
            }

            SzybkiSort(tab, lewy, granica - 1);
            SzybkiSort(tab, granica + 1, prawy);


        }
        static void Swap(int [] tab,int granica,int licznik)
        {
            int temp = tab[licznik];
            tab[licznik] = tab[granica];
            tab[granica] = temp;
        }
    }
}
