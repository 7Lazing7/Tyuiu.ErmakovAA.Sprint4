using Tyuiu.ErmakovAA.Sprint4.Task3.V19.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
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


            int[,] mas = new int[5, 5] { { 6, 5, 6, 3, 8 },
                                         { 9, 4, 4, 3, 4 },
                                         { 3, 3, 6, 8, 6 },
                                         { 6, 5, 3, 4, 3 },
                                         { 9, 3, 5, 3, 7 } };

            int rows = mas.GetUpperBound(0) + 1; // количество строк
            int cols = mas.Length / rows; // количество столбцов
                                          // или так int cols = numbers.GetUpperBound(1) + 1;


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
