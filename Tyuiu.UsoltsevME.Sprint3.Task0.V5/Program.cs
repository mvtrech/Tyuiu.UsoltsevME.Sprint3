
using System;
using Tyuiu.UsoltsevME.Sprint3.Task0.V5.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите начальное значение k: ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение k: ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            double result = ds.GetSumSeries(startValue, stopValue);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            if (double.IsNaN(result))
            {
                Console.WriteLine("Невозможно вычислить сумму.");
            }
            else
            {
                Console.WriteLine("Сумма ряда = " + result);
            }

            Console.ReadKey();
        }
    }
}
