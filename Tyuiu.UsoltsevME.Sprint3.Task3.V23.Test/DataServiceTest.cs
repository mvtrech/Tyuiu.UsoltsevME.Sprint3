
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint3.Task3.V23.Lib;

namespace Tyuiu.UsoltsevME.Sprint3.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReplaceCharOnNumTest()
        {
            DataService ds = new DataService();

            string value = "fdsst siu vsrs";
            string wait = "fd88t 8iu v8r8";

            string result = ds.ReplaceCharOnNum(value, 's', '8');

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ReplaceOtherStringTest()
        {
            DataService ds = new DataService();

            string result = ds.ReplaceCharOnNum("success", 's', '8');

            Assert.AreEqual("8ucce88", result);
        }
    }
}
