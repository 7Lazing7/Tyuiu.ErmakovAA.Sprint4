using Tyuiu.ErmakovAA.Sprint4.Task2.V6.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = new int[] { 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1, 1, 2 };
            Assert.AreEqual(ds.Calculate(numsArray), 225);

        }
    }
}