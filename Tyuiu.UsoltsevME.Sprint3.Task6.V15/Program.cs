
using System;
using Tyuiu.UsoltsevME.Sprint3.Task6.V15.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите начальное значение: ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение: ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Сумма всех делителей = " + result);

            Console.ReadKey();
        }
    }
}
