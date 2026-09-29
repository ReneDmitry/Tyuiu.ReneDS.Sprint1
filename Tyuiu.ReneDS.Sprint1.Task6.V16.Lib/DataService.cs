using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ReneDS.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            var res = value.Contains("!") && value.Contains("?");
            return res;
        }
    }
}
