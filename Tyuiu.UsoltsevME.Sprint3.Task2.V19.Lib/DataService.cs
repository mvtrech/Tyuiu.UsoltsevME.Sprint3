using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double result = 0;
            int i = startValue;

            if (startValue > stopValue)
            {
                return 0;
            }

            do
            {
                result = result + Math.Cos(i) * 0.5;
                i++;
            }
            while (i <= stopValue);

            return Math.Round(result, 3);
        }
    }
}