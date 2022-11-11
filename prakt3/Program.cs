using System;
using System.ComponentModel.Design;

namespace prakt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ноты пианино на клавиатуре:");
            Console.WriteLine("Чёрные клавиши:");
            Console.WriteLine("E - до диез, R - ми бемоль, Y - фа диез, U - соль диез, I - ля бемоль");
            Console.WriteLine("Белые клавиши:");
            Console.WriteLine("S - до, D - ре, F - ми, G - фа, H - соль, J - ля, K - си.");
            Boolean x = true;
            do
            {
                int[] octave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    x = false;
                }
                else if (key.Key != ConsoleKey.Escape)
                {
                    if (key.Key == ConsoleKey.S)
                    {
                        int a = octave[0];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.D)
                    {
                        int a = octave[2];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.F)
                    {
                        int a = octave[4];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.G)
                    {
                        int a = octave[5];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.H)
                    {
                        int a = octave[7];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.J)
                    {
                        int a = octave[9];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.K)
                    {
                        int a = octave[11];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.E)
                    {
                        int a = octave[1];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.R)
                    {
                        int a = octave[3];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.Y)
                    {
                        int a = octave[6];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.U)
                    {
                        int a = octave[8];
                        Console.Beep(a, a);
                    }
                    else if (key.Key == ConsoleKey.I)
                    {
                        int a = octave[10];
                        Console.Beep(a, a);
                    }
                }
                Console.Clear();
            }
            while (x);
        }
    }
}