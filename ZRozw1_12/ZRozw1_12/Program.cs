using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            double liczba1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            double liczba2 = Convert.ToDouble(Console.ReadLine());
            if(liczba2 !=0)
            {
                Console.WriteLine("Iloraz = {0}", liczba1 / liczba2);
            }
            else
            {
                Console.WriteLine("nie można dzielić przez zero!");
            }
            Console.ReadKey();
        }
    }
}
