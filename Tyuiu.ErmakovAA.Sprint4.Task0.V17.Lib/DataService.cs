using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ErmakovAA.Sprint4.Task0.V17.Lib
{
    public class DataService : ISprint4Task0V17
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i % 2 == 0) sum += i;
            }
            return sum;
        }
    }
}
/*
for (int i = 0; i < array.Length - 1; i++)
{

}*/