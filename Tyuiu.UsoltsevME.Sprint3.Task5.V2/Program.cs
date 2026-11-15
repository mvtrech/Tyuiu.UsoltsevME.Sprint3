
using System;
using Tyuiu.UsoltsevME.Sprint3.Task5.V2.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите начальное значение i: ");
            int startValue1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите начальное значение k: ");
            int startValue2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение i: ");
            int stopValue1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение k: ");
            int stopValue2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                double result = ds.GetSumSumSeries(
                    x, startValue1, startValue2, stopValue1, stopValue2);

                Console.WriteLine("****************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
                Console.WriteLine("****************************************************");

                Console.WriteLine("Результат y = " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
