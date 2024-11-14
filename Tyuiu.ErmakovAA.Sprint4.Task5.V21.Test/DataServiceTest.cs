using Tyuiu.ErmakovAA.Sprint4.Task5.V21.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5]
            {
                { 6, 3, 6, 6, -7 },
                { 9, -8, 9, 7, 9 },
                { 5, 6, 8, -7, 5 },
                { 8, 5, -6, 5, 3 },
                { 3, -9, 9, 8, 8 }
            };
            int[,] masWait = new int[5, 5]
            {
                { 1, 1, 1, 1, -7 },
                { 1, -8, 1, 1, 1 },
                { 1, 1, 1, -7, 1 },
                { 1, 1, -6, 1, 1 },
                { 1, -9, 1, 1, 1 }
            };
            CollectionAssert.AreEqual(masWait, ds.Calculate(mas));
        }
    }
}