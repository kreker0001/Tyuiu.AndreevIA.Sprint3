using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndreevIA.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;
            int i = startValue;
            do
            {
                p *= ((value * value * i) + 2);
                i++;
            } while (i <= stopValue);
            return Math.Round(p, 3);
        }
    }
}