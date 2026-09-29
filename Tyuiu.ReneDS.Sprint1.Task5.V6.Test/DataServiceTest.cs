using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ReneDS.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ReneDS.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int k = 10;
            var res = ds.Calculate(k);

            Assert.AreEqual(3, res);
        }
    }
}
