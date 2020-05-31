using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_kopcowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 3, 7, 5, 3, 1, 6, 4, 9, 5, 4 };
            int n = tab.Length;

            Console.WriteLine("Tablica przed sortowaniem: ");
            foreach (int x in tab)
                Console.Write("{0} ,", x);
            Console.WriteLine();

            for (int i = n / 2 - 1; i >= 0 ; i--)
                MaxKop(tab, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                Swap(tab, 0, i);
                n--;
                MaxKop(tab, n, 0);

            }

            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (int x in tab)
                Console.Write("{0} ,", x);
            

            Console.ReadKey();
        }

        public static void MaxKop(int [] tab, int kopRoz, int rodzInd)
        {
            int maxInd = rodzInd;
            int leweDz = rodzInd * 2 + 1;
            int praweDz = rodzInd * 2 + 2;

            if (leweDz < kopRoz && tab[leweDz] > tab[maxInd])
                maxInd = leweDz;
            if (praweDz < kopRoz && tab[praweDz] > tab[maxInd])
                maxInd = praweDz;

            if(maxInd != rodzInd)
            {
                Swap(tab,maxInd,rodzInd);
                MaxKop(tab, kopRoz, maxInd);
            }

            
        }
        static void Swap(int[] tab, int maxInd, int rodzInd)
        {
            int temp = tab[maxInd];
            tab[maxInd] = tab[rodzInd];
            tab[rodzInd] = temp;
        }
    }
}
