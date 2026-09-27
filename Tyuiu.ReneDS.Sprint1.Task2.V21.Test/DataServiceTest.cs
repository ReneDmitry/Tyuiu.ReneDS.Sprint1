using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ReneDS.Sprint1.Task2.V21.Lib;

namespace Tyuiu.ReneDS.Sprint1.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 2;
            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(8, res);
        }
    }
}
