using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ErmakovAA.Sprint4.Task4.V29.Lib
{
    public class DataService : ISprint4Task4V29
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; // количество строк
            int cols = matrix.Length / rows; // количество столбцов

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count += matrix[i, j];
                    }
                }

            }
            return count;
        }
    }
}
