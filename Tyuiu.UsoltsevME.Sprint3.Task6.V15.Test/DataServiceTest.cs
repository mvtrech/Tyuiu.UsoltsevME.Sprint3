
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint3.Task6.V15.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisorsTest()
        {
            DataService ds = new DataService();

            int result = ds.GetSumTheDivisors(6, 15);

            Assert.AreEqual(168, result);
        }

        [TestMethod]
        public void GetSumTheDivisorsOneNumberTest()
        {
            DataService ds = new DataService();

            int result = ds.GetSumTheDivisors(6, 6);

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void GetSumTheDivisorsReverseTest()
        {
            DataService ds = new DataService();

            int result = ds.GetSumTheDivisors(15, 6);

            Assert.AreEqual(168, result);
        }
    }
}
