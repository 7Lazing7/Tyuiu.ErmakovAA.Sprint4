namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1,5,-2,4,-7,-6 };
            int s = 0 ;
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i] < 0)
                    s += array[i];
            }
            Console.WriteLine(s);
        }
    }
}
