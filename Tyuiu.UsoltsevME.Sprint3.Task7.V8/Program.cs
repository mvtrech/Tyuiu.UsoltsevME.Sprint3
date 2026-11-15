
using System;
using Tyuiu.UsoltsevME.Sprint3.Task7.V8.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task7.V8
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

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            int firstValue = Math.Min(startValue, stopValue);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(
                    "x = " + (firstValue + i) +
                    "    F(x) = " + result[i].ToString("F2"));
            }

            Console.WriteLine("****************************************************");

            Console.ReadKey();
        }
    }
}
