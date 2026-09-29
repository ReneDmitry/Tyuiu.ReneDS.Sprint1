using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ReneDS.Sprint1.Task7.V13.Lib;

namespace Tyuiu.ReneDS.Sprint1.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(0.978, res);
        }
    }
}
