using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndreevIA.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                sum += (Math.Pow(value, i) + (1 / (i + 1.0))) * Math.Cos(value);
                i++;
            }
            return Math.Round(sum, 3);
        }
    }
}