
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint3.Task1.V17.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesTest()
        {
            DataService ds = new DataService();

            double result = ds.GetMultiplySeries(0, 1, 2);

            Assert.AreEqual(8.0, result, 0.001);
        }
    }
}
