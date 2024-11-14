using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ErmakovAA.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            int count = Array.FindAll(array, x => x.Length < 7).Length;

            return count;
        }
    }
}