using System;

namespace task_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.WriteLine($"{n/10} {n%10}");
        }
    }
}