using System;

namespace task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? string.Empty);
            
            int count = GetDigitCount(number);
            Console.WriteLine(count);

            Console.Read();
        }

        private static int GetDigitCount(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            var count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }

            return count;
        }
    }
}