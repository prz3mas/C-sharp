using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, w, bmi;
            Console.WriteLine("Podaj swój wzrost w metrach: ");
            w = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoją wage w kilogramach: ");
            m = double.Parse(Console.ReadLine());
            bmi = m / (w * w);
            Console.WriteLine(bmi);
            Console.ReadKey();
        }
    }
}
