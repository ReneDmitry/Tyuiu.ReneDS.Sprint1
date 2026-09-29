using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ReneDS.Sprint1.Task6.V16.Lib;

namespace Tyuiu.ReneDS.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string value = "Привет! Как дела?";
            var res = ds.CheckSpecSymbols(value);

            Assert.AreEqual(true, res);
        }
    }
}
