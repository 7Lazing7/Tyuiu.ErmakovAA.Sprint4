using Tyuiu.ErmakovAA.Sprint4.Task7.V23.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task7.V23
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

            int[,] matrix = new int[4, 3];
            string str = "678135972584";

            int index = 0;
            Console.WriteLine("\nМассив");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++, index++)
                {
                    Console.Write($"{str[index]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Количество нечётных элементов = " + ds.Calculate(4, 3, str));
            Console.ReadKey();
        }
    }
}
