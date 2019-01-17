using System;

namespace AdrianSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Sum(long.Parse(args[0]), long.Parse(args[1]));
        }

        public static long Sum(long num1, long num2)
        {
            return num1 + num2;
        }
    }
}
