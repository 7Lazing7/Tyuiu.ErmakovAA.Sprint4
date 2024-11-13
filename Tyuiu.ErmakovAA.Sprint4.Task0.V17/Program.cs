using Tyuiu.ErmakovAA.Sprint4.Task0.V17.Lib;
namespace Tyuiu.ErmakovAA.Sprint4.Task0.V17
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

            int[] numsArray = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

            Console.WriteLine("Исходный массив:");
            foreach (int num in numsArray)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Произведение = " + ds.GetSumEvenArrEl(numsArray));
        }
    }
}