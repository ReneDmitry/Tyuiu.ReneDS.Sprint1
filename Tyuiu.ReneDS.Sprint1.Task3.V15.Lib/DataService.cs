using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ReneDS.Sprint1.Task3.V15.Lib
{
    public class DataService : ISprint1Task3V15
    {
        public double DistanceOverTime(double v1, double v2, double S, double T)
        {
            S += (v1 + v2) * T;
            return Math.Round(S, 3);

        }
    }
}
