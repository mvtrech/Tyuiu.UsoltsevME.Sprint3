
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint3.Task4.V6.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(-5, 5);

            Assert.AreEqual(8.995, result, 0.001);
        }

        [TestMethod]
        public void CalculatePositiveTest()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(1, 5);

            Assert.AreEqual(35.317, result, 0.001);
        }

        [TestMethod]
        public void CalculateZeroTest()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(0, 5);

            Assert.AreEqual(0, result, 0.001);
        }
    }
}
