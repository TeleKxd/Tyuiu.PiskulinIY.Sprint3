using Tyuiu.PiskulinIY.Sprint3.Task7.V6.Lib;
namespace Tyuiu.PiskulinIY.Sprint3.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] ValueWaitArray;
            ValueWaitArray = new double[len];

            ValueWaitArray[0] = 23.92;
            ValueWaitArray[1] = 18.88;
            ValueWaitArray[2] = 13.10;
            ValueWaitArray[3] = 7.24;
            ValueWaitArray[4] = 1.80;
            ValueWaitArray[5] = -8;
            ValueWaitArray[6] = -5.70;
            ValueWaitArray[7] = -11.26;
            ValueWaitArray[8] = -17.12;
            ValueWaitArray[9] = -22.88;
            ValueWaitArray[10] = -27.92;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(ValueWaitArray, res);
        }
    }
}