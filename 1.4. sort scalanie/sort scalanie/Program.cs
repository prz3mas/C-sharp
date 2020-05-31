using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program

{
    static int[] tablica = { 3, 5, 7, 2, 4, 9, 4, 0 }; 
    static int[] tab = new int[tablica.Length];

    static void Main()
    {
        Console.WriteLine("Tablica przed sortowaniem: ");
        foreach (int x in tablica)
            Console.Write("{0} ,", x);
        Console.WriteLine();
       
        
        Sortowanie(0, tablica.Length - 1);


        Console.WriteLine("Tablica po sortowaniu: ");
        foreach (int x in tablica)
            Console.Write("{0} ,", x);
        Console.ReadKey();
    }
    
   

   
    static void Scalanie(int pocz, int kon)
    {
        
        for (int i = pocz; i <= kon; i++)
        {
            tab[i] = tablica[i];
        }

        
        int p = pocz;
        int q = (pocz + kon) / 2 + 1;
        int r = pocz;
        while (p <= (pocz + kon) / 2 && q <= kon)
        {
            if (tab[p] < tab[q])
            {
                tablica[r] = tab[p];
                r++;
                p++;
            }
            else
            {
                tablica[r] = tab[q];
                r++;
                q++;
            }
        }
                
        while (p <= (pocz + kon) / 2)
        {
            tablica[r] = tab[p];
            r++;
            p++;
        }
    }

       static void Sortowanie(int pocz, int kon)
    {
        if (pocz < kon)
        {
            
            Sortowanie(pocz, (pocz + kon) / 2);
            Sortowanie((pocz + kon) / 2 + 1, kon);
            Scalanie(pocz, kon);
        }
    }
           
}