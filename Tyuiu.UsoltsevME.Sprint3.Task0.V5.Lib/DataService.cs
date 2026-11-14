
using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                int temp = startValue;
                startValue = stopValue;
                stopValue = temp;
            }

            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double sin = Math.Sin(k);

                if (Math.Abs(sin) < 0.000000001)
                {
                    return double.NaN;
                }

                sum += Math.Pow(1.0 / sin, 2);
            }

            return Math.Round(sum, 3);
        }
    }
}
