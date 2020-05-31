using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delta
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Podaj wpółczynnik a równania kwadratowego: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wpółczynnik b równania kwadratowego: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wpółczynnik c równania kwadratowego: ");
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine(delta);
            Console.ReadKey();


        }
    }
}
