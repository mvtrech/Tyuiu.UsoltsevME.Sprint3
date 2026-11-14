using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            double x = value;
            double cosX = Math.Cos(x);

            if (Math.Abs(cosX) < 0.0000001)
            {
                throw new ArgumentException("Косинус не должен быть равен нулю.");
            }

            int step = startValue <= stopValue ? 1 : -1;

            for (long k = startValue;
                 step > 0 ? k <= stopValue : k >= stopValue;
                 k += step)
            {
                result = result * Math.Pow(2 / cosX, k);
            }

            return Math.Round(result, 3);
        }
    }
}
