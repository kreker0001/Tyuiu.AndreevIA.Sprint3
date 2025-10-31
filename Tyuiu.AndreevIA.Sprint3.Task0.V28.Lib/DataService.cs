using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndreevIA.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double umn = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                umn *= ((Math.Pow(value, 3) * i) + 2);
            }
            return Math.Round(umn, 3);
        }
    }
}
