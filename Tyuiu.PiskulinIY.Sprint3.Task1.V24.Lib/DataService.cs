using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PiskulinIY.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow((2 / (Math.Pow(6 + value, startValue))), startValue));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
