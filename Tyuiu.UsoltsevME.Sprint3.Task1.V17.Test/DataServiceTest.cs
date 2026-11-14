using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint3.Task1.V17.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMultiplySeries()
        {
            DataService ds = new DataService();

            int x = 1;
            int startValue = 1;
            int stopValue = 4;

            double wait = 482982.891;

            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            Assert.AreEqual(wait, Math.Round(result, 3), 0.001);
        }
    }
}