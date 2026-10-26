
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double sin = Math.Sin(k);

                if (Math.Abs(sin) < 0.000000001)
                {
                    return double.NaN;
                }

                sum += 1.0 / (sin * sin);
            }

            return Math.Round(sum, 3);
        }
    }
}
