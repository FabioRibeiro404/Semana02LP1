using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = sbyte.MaxValue;
            sbyte num2 = sbyte.MinValue;

            byte num3 = byte.MaxValue;
            byte num4 = byte.MinValue;

            ushort num5 = ushort.MaxValue;
            ushort num6 = ushort.MinValue;

            short num7 = short.MaxValue;
            short num8 = short.MinValue;

            uint num9 = uint.MaxValue;
            uint num10 = uint.MinValue;

            int num11 = int.MaxValue;
            int num12 = int.MinValue;

            ulong num13 = ulong.MaxValue;
            ulong num14 = ulong.MinValue;

            long num15 = long.MaxValue;
            long num16 = long.MinValue;

            float num17 = float.MaxValue;
            float num18 = float.MinValue;

            double num19 = double.MaxValue;
            double num20 = double.MinValue;

            double posiDou = double.PositiveInfinity;
            double negaDou = double.NegativeInfinity;

            float posiFlo = float.PositiveInfinity;
            float negaFlo = float.NegativeInfinity;

            double nanDou = double.NaN;
            float nanFlo = float.NaN;


            Console.WriteLine($"Max values:");
            Console.WriteLine($"sbyte:{num1}");
            Console.WriteLine($"byte:{num3}");
            Console.WriteLine($"ushort:{num5}");
            Console.WriteLine($"short:{num7}");
            Console.WriteLine($"uint:{num9}");
            Console.WriteLine($"int:{num11}");
            Console.WriteLine($"ulong:{num13}");
            Console.WriteLine($"long:{num15}");
            Console.WriteLine($"float:{num17}");
            Console.WriteLine($"sbyte:{num19}\n");

            Console.WriteLine("Min values:");
            Console.WriteLine($"sbyte:{num2}");
            Console.WriteLine($"byte:{num4}");
            Console.WriteLine($"ushort:{num6}");
            Console.WriteLine($"short:{num8}");
            Console.WriteLine($"uint:{num10}");
            Console.WriteLine($"int:{num12}");
            Console.WriteLine($"ulong:{num14}");
            Console.WriteLine($"long:{num16}");
            Console.WriteLine($"float:{num18}");
            Console.WriteLine($"sbyte:{num20}");

            Console.WriteLine($"Positive Infinity: {posiDou}, {posiFlo}");
            Console.WriteLine($"Negative Infinity: {negaDou}, {negaFlo}");
            Console.WriteLine($"Nan: {nanDou} {nanFlo}");
        }
    }
}
