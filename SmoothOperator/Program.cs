using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a non-negative number:\n");
            string str = Console.ReadLine();
            byte n = byte.Parse(str);
            n--;
            Console.WriteLine(n);
            n++;
            Console.WriteLine(n);
        }
    }
}
