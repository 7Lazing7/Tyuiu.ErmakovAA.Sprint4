using Tyuiu.ErmakovAA.Sprint4.Task4.V29.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                int[,] mas = new int[5, 5] { { 5, 6, 5, 6, 5 },
                                             { 5, 5, 5, 8, 4 },
                                             { 8, 5, 5, 8, 8 },
                                             { 6, 5, 4, 4, 8 },
                                             { 8, 5, 6, 8, 8 } };

                int rows = mas.GetLength(0);
                int cols = mas.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"{mas[i, j]} \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
                Console.WriteLine("********************************************************************************");

                int res = ds.Calculate(mas);
                Console.WriteLine("количество = " + res);
                Console.ReadKey();
            }
        }
    }
}
