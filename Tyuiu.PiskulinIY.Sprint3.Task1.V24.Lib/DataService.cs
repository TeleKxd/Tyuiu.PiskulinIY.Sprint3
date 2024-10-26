﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PiskulinIY.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            while (startValue <= stopValue)
            {
                res += Math.Pow(((2) / (6 + Math.Pow(value, startValue))), startValue);
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
