using Tyuiu.PiskulinIY.Sprint3.Task2.V17.Lib;
namespace Tyuiu.PiskulinIY.Sprint3.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 4.399;

            Assert.AreEqual(wait, res);
        }
    }
}