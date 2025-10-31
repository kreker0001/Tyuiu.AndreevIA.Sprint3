using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndreevIA.Sprint3.Task4.V12.Lib
{
    public class DataService : ISprint3Task4V12
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1.0; 

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) break; 

                double y = x / (x + Math.Sin(x)) + 2.5;
                res *= y; 
            }

            return Math.Round(res, 3);
        }
    }
}
