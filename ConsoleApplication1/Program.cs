using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double S;
            Console.WriteLine("Введите площадь поверхности куба:");
            try
            {
                S = Convert.ToDouble(Console.ReadLine());
                if (S <= 0)
                {
                    Console.WriteLine("Площадь не может быть неположительным числом");
                }
                else
                {
                    Console.WriteLine(Math.Round(Math.Sqrt(S / 6),3));
                }
            }
            catch { Console.WriteLine("Некорректный ввод данных"); };
            Console.ReadKey();
        }
    }
}
