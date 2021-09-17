using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.1 exercises");
            Console.Write("Введите своё имя : ");
            string name = Console.ReadLine();
            Console.WriteLine("Здравия желаю товарищ  " + name);
            Console.WriteLine("2.2 exercises");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number2 == 0)
            {
                Console.WriteLine("шо ещё хотите?");
            }
            else
            {
                Console.WriteLine((double)number1 / number2);
            }
            Console.WriteLine("homework 2.1");

            char inputLetter = char.Parse(Console.ReadLine());
            Console.WriteLine((char)((int)inputLetter + 1));

            Console.WriteLine("homework 2.2");
            Console.WriteLine("введите коэффициент a : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите коэффициен b : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("введите коэффициент c : ");
            double c = double.Parse(Console.ReadLine());
            double D, x1, x2;
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D >= 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= " + x1 + "\n" + "x2=" + x2);

            }
            else
            {
                Console.WriteLine("корней нет");
            }
        }
    }
}
