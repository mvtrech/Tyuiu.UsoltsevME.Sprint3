using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint3.Task2.V19.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double wait = -0.709;

            double result = ds.GetSumSeries(startValue, stopValue);

            Assert.AreEqual(wait, result, 0.001);
        }
    }
}