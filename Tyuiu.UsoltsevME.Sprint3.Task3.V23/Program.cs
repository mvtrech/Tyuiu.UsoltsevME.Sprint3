
using System;
using Tyuiu.UsoltsevME.Sprint3.Task3.V23.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task3.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите строку: ");
            string value = Console.ReadLine();

            string result = ds.ReplaceCharOnNum(value, 's', '8');

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Полученная строка: " + result);

            Console.ReadKey();
        }
    }
}
