
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
                double division;

                if (2 - x == 0)
                {
                    division = 0;
                }
                else
                {
                    division = (Math.Cos(x) + 1) / (2 - x);
                }

                double y = Math.Sin(x) + division + 2 * x;

                result[index] = Math.Round(y, 2);

                index++;
            }

            return result;
        }
    }
}
