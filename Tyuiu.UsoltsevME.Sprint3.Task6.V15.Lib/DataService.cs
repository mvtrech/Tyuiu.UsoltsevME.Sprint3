
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                int temp = startValue;
                startValue = stopValue;
                stopValue = temp;
            }

            int sum = 0;

            for (int number = startValue; number <= stopValue; number++)
            {
                if (number == 0)
                {
                    continue;
                }

                int n = Math.Abs(number);

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
            }

            return sum;
        }
    }
}
