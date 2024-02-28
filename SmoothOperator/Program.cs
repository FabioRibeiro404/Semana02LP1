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
            int div = n / 2;
            Console.WriteLine(div);
            int bit = n << 3;
            Console.WriteLine(bit);
            int xor = n ^ 5;
            Console.WriteLine(xor);
            bool highNum = n > 10;
            Console.WriteLine(highNum);
        }
    }
}
