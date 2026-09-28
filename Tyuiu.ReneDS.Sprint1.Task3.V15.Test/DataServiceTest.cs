using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ReneDS.Sprint1.Task3.V15.Lib;

namespace Tyuiu.ReneDS.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExperession()
        {
            DataService ds = new DataService();
            double v1 = 60;
            double v2 = 80;
            double S = 100;
            double T = 2;

            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(380, res);

        }
    }
}
