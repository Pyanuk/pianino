using System;

class Program
{
    static void Main()
    {
        while (true)
        { 

            Console.WriteLine("Белые клавиши: A, S, D, F, G, H");
            Console.WriteLine("Чёрные клавиши: W, E, R, T, Y");
            Console.WriteLine("Октавы: F1, F2, F3");
            Console.WriteLine("Для выхода нажмите клавишу Backspace");
            Console.WriteLine("Для смены октавы нажмите 2 раза Escape");
            Console.WriteLine("Выберите октаву");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.F1:
                        PlayOctave(new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 });
                        break;
                    case ConsoleKey.F2:
                        PlayOctave(new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 });
                        break;
                    case ConsoleKey.F3:
                        PlayOctave(new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 });
                    break;
            }
                } while (key.Key != ConsoleKey.Escape);
    }
        }
    static void PlayOctave(int[] octave)
    {
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            int noteIndex = -1;
            switch (key.Key)
            {
                case ConsoleKey.A:
                    noteIndex = 0;
                    break;
                case ConsoleKey.S:
                    noteIndex = 1;
                    break;
                case ConsoleKey.D:
                    noteIndex = 2;
                    break;
                case ConsoleKey.F:
                    noteIndex = 3;
                    break;
                case ConsoleKey.G:
                    noteIndex = 4;
                    break;
                case ConsoleKey.H:
                    noteIndex = 5;
                    break;
                case ConsoleKey.W:
                    noteIndex = 6;
                    break;
                case ConsoleKey.E:
                    noteIndex = 7;
                    break;
                case ConsoleKey.R:
                    noteIndex = 8;
                    break;
                case ConsoleKey.T:
                    noteIndex = 9;
                    break;
                case ConsoleKey.Y:
                    noteIndex = 10;
                    break;
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.Backspace:
                    Environment.Exit(0);
                    break;
            }

            if (noteIndex != -1)
            {
                MakeSound(octave[noteIndex]);
            }
        }
    }

    static void MakeSound(int frequency)
    {
        Console.Beep(frequency, 700);
        Console.Clear();
    }
}
