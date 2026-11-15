
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint3.Task5.V2.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeriesTest()
        {
            DataService ds = new DataService();

            double result = ds.GetSumSumSeries(5, 1, 1, 3, 12);

            Assert.AreEqual(35.658, result, 0.001);
        }

        [TestMethod]
        public void GetSumSumSeriesOneValueTest()
        {
            DataService ds = new DataService();

            double result = ds.GetSumSumSeries(5, 1, 1, 1, 1);

            Assert.AreEqual(1.108, result, 0.001);
        }
    }
}
