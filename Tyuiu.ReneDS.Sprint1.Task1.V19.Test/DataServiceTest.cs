using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ReneDS.Sprint1.Task1.V19.Lib;
namespace Tyuiu.ReneDS.Sprint1.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(10,5, res);

        }
    }
}
