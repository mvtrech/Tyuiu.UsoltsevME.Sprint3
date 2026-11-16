
using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                int temp = startValue;
                startValue = stopValue;
                stopValue = temp;
            }

            double[] result = new double[stopValue - startValue + 1];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 - x == 0)
                {
                    result[index] = 0.0;
                }
                else
                {
                    double y = Math.Sin(x)
                        + (Math.Cos(x) + 1) / (2 - x)
                        + 2 * x;

                    result[index] = Math.Round(y, 2);
                }

                index++;
            }

            return result;
        }
    }
}
