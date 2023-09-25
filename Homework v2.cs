using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки x");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки y");
            Double y = Convert.ToDouble(Console.ReadLine());
            int R = 6;
            bool result = (x > 0) && (y > 0) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 36) && (x >= Math.Sqrt(18)) && (y >= Math.Sqrt(18));
            if (result==true)
            {
                Console.WriteLine("Точка соответствует координатам заштрихованной плоскости");
            }
            else
            {
                Console.WriteLine("Точка не соответствует координатам заштрихованной плоскости");
            }
            Console.ReadKey();
        }
    }
}
