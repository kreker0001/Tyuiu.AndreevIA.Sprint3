﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AndreevIA.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0.0;
            int k = startValue;

            while (k <= stopValue)
            {
                sum += (Math.Pow(value, k) + 1.0 / (k + 1)) * Math.Cos(value);
                k++;
            }

            return Math.Round(sum, 3); 
        }

    }
}