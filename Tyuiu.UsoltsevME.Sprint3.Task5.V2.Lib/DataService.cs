
using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task5.V2.Lib
{
    public class DataService : ISprint3Task5V2
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            if (x == 0)
            {
                throw new ArgumentException("x не должен быть равен нулю.");
            }

            if (startValue1 > stopValue1)
            {
                int temp = startValue1;
                startValue1 = stopValue1;
                stopValue1 = temp;
            }

            if (startValue2 > stopValue2)
            {
                int temp = startValue2;
                startValue2 = stopValue2;
                stopValue2 = temp;
            }

            double sum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += (Math.Cos(k) + x) / x;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}
