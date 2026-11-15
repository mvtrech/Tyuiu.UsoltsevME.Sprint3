
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.UsoltsevME.Sprint3.Task3.V23.Lib
{
    public class DataService : ISprint3Task3V23
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string result = "";

            foreach (char symbol in value)
            {
                if (symbol == replaceable)
                {
                    result += replacement;
                }
                else
                {
                    result += symbol;
                }
            }

            return result;
        }
    }
}
