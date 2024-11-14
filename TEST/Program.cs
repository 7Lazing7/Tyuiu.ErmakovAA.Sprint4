using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь" };
            foreach (string item in data)

                if (item.Length == 7)

                    Console.WriteLine(item);
        }
    }
}
