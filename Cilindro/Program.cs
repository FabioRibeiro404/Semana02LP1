using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert height:   ");
            string strH = Console.ReadLine();
            float height = float.Parse(strH);

            Console.WriteLine("Insert radius:   ");
            string strR = Console.ReadLine();
            float radius = float.Parse(strR);

            float volume = MathF.PI * MathF.Pow(radius, 2) * height;
            Console.WriteLine($"Volume = {volume}");

            float supArea = 2 * MathF.PI * radius * (radius + height);
            Console.WriteLine($"Superficial Area = {supArea}");
        }
    }
}
