using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8TrojkaPitagorejska
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Program sprawdza, czy trzy wprowadzone liczby tworzą trójkę pitagorejską");
            Console.Write("Podaj liczbę a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę c= ");
            c = Convert.ToDouble(Console.ReadLine());   
            if ((a * a) +(b * b) == (c * c))
                Console.WriteLine("Podane liczby a= {0}, b= {1} i c= {2}, tworzą trójkę pitagorejską", a, b, c);
            else
                Console.WriteLine("Podane liczby a= {0}, b= {1} i c= {2}, nie tworzą trójki pitagorejskiej", a, b, c);
            Console.ReadLine();
        }
    }
}
