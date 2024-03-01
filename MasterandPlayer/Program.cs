using System;

namespace MasterandPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //User 1 or Master
            Console.Write("Number Master insert number: ");
            string str = Console.ReadLine();
            int numMaster = int.Parse(str);

            if (numMaster > 0 && numMaster < 100)
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("");
                }

                //User 2 or Player
                Console.Write("Player insert number: ");
                string str2 = Console.ReadLine();
                int numPlayer = int.Parse(str2);

                while (numPlayer != numMaster)
                {

                    //Invalid number
                    if (numPlayer <= 0 || numPlayer >= 100)
                    {
                        Console.WriteLine("Invalid number! Try again!");
                    }

                    //Number lower than Master
                    else if (numPlayer < numMaster)
                    {
                        Console.WriteLine($"The correct number is higher than {numPlayer}");
                    }

                    //Number higher than Master
                    else if (numPlayer > numMaster)
                    {
                        Console.WriteLine($"The correct number is lower than {numPlayer}");
                    }
                    
                    Console.Write("Player insert number: ");
                    str2 = Console.ReadLine();
                    numPlayer = int.Parse(str2);

                    if (numPlayer == numMaster)
                    {
                        Console.WriteLine("Player wins!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
