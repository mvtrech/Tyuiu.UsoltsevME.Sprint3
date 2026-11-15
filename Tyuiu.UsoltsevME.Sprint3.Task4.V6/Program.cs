
using System;
using Tyuiu.UsoltsevME.Sprint3.Task4.V6.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите начальное значение x: ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение x: ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Сумма значений функции = " + result);

            Console.ReadKey();
        }
    }
}
