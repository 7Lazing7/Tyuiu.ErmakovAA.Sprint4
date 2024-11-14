using Tyuiu.ErmakovAA.Sprint4.Task6.V27.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                  *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #6                                                                   *");
            Console.WriteLine("* Выполнил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string[] figure = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            Console.WriteLine("Исходный массив:");
            foreach (string companyItem in figure)
            {
                Console.WriteLine(companyItem);
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Количество элементов, длина которых < 7 = " + ds.Calculate(figure));

            Console.ReadKey(); ;
        }
    }
}
