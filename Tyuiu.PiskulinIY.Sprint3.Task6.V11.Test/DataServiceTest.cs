using Tyuiu.PiskulinIY.Sprint3.Task6.V11.Lib;
namespace Tyuiu.PiskulinIY.Sprint3.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 19;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}