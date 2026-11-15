
using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            int step = startValue <= stopValue ? 1 : -1;

            for (long x = startValue;
                 step > 0 ? x <= stopValue : x >= stopValue;
                 x += step)
            {
                if (x == 0)
                {
                    break;
                }

                double result = x / (Math.Cos(x) - Math.Sin(x));

                sum += result;
            }

            return Math.Round(sum, 3);
        }
    }
}
