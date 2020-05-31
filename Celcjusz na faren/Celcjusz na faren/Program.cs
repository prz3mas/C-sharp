using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celcjusz_na_faren
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            Console.WriteLine("Podaj temp w Celsjuszach: ");
            C = double.Parse(Console.ReadLine());
            F = 32 + 9d / 5 * C;
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}
