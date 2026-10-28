
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            int k = startValue;

            double cos = Math.Cos(value);

            if (Math.Abs(cos) < 0.000000001)
            {
                return double.NaN;
            }

            while (k <= stopValue)
            {
                result = result * Math.Pow(2.0 / cos, k);
                k++;
            }

            return Math.Round(result, 3);
        }
    }
}
