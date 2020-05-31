using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_zlicz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 5, 9, 3, 5, 1, 6, 8, 4 };



            Console.WriteLine("Tablica przed sortowaniem: ");
            foreach (int x in tab)
                Console.Write(x + " ,");
            Console.WriteLine();

            int[] tabPom = new int[tab.Length];

            int min = tab[0];
            int max = tab[0];


            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min) min = tab[i];
                else if (tab[i] > max) max = tab[i];
            }
             
            
            int[] zlicz = new int[max - min + 1];


            for (int i = 0; i < tab.Length; i++)
            {
                zlicz[tab[i] - min]++;
            }
            zlicz[0]--;
            
            for (int i = 1; i < zlicz.Length; i++)
            {
                zlicz[i] = zlicz[i] + zlicz[i - 1];
            }

            for (int i = tab.Length - 1; i >= 0; i--)
            {
                tabPom[zlicz[tab[i] - min]--] = tab[i];
            }

            Console.WriteLine("Tablica po sortowaniu :");
            foreach (int x in tabPom)
                Console.Write(x + " ,");
           
            Console.ReadKey();
        }
    }
}
