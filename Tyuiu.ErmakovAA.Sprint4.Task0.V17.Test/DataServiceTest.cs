using Tyuiu.ErmakovAA.Sprint4.Task0.V17.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl1()
        {
            DataService ds = new DataService();
            
            int[] numsArray = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            Assert.AreEqual(34, ds.GetSumEvenArrEl(numsArray));

        }
    }
}
