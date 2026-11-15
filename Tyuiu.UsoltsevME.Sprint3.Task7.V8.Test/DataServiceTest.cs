
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint3.Task7.V8.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunctionTest()
        {
            DataService ds = new DataService();

            double[] wait =
            {
                -8.86, -7.19, -6.14, -4.76, -2.33,
                1.00, 4.38, 4.91, 6.13, 7.07, 8.61
            };

            double[] result = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void GetMassFunctionOneValueTest()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(2, 2);

            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(4.91, result[0], 0.001);
        }
    }
}
