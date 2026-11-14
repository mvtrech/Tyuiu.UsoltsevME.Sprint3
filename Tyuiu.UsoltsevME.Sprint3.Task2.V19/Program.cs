using Tyuiu.UsoltsevME.Sprint3.Task2.V19.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task2.V19
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

            double result = ds.GetSumSeries(startValue, stopValue);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Сумма ряда = " + result);

            Console.ReadKey();
        }
    }
}