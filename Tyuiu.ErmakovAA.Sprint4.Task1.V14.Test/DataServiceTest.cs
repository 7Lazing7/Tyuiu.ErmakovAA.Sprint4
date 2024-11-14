using Tyuiu.ErmakovAA.Sprint4.Task1.V14.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = new int[] { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
            Assert.AreEqual(ds.Calculate(numsArray), 32);

        }
    }
}