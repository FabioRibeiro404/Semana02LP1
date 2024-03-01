using System;

namespace MasterandPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number Master insert number: ");
            string str = Console.ReadLine();
            int numMaster = int.Parse(str);

            if (numMaster > 0 && numMaster < 100)
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("");
                }
                
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
