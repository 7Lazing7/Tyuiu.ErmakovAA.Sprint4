using Tyuiu.ErmakovAA.Sprint4.Task6.V27.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] figure = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            Assert.AreEqual(1, ds.Calculate(figure));

        }
    }
}