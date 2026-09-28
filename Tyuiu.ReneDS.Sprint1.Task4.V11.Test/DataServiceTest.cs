using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ReneDS.Sprint1.Task4.V11.Lib;

namespace Tyuiu.ReneDS.Sprint1.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            
            double x = 1;
            double y = 2;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.106, res);
        }
    }
}
