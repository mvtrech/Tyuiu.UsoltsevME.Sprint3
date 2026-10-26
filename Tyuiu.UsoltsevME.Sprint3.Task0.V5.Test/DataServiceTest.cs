
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint3.Task0.V5.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeriesTest()
        {
            DataService ds = new DataService();

            double result = ds.GetSumSeries(1, 10);

            Assert.AreEqual(81.083, result, 0.001);
        }

        [TestMethod]
        public void GetSumSeriesSingleValueTest()
        {
            DataService ds = new DataService();

            double result = ds.GetSumSeries(1, 1);

            Assert.AreEqual(1.412, result, 0.001);
        }
    }
}
