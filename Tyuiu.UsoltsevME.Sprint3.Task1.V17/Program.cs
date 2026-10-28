
using System;
using Tyuiu.UsoltsevME.Sprint3.Task1.V17.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task1.V17
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

            Console.Write("Введите начальное значение k: ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение k: ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            if (startValue > stopValue)
            {
                int temp = startValue;
                startValue = stopValue;
                stopValue = temp;
            }

            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            if (double.IsNaN(result) || double.IsInfinity(result))
            {
                Console.WriteLine("Невозможно вычислить результат.");
            }
            else
            {
                Console.WriteLine("P = " + result);
            }

            Console.ReadKey();
        }
    }
}
