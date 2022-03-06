using System;

namespace OS_Practice2
{
    internal static class MultiThreading
    {
        private static readonly char[] Dictionary =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        private static readonly int Len = Dictionary.Length;

        internal static int SetThread()
        {
            while (true)
            {
                Console.WriteLine("Введите количество потоков");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int count))
                {
                    if (count < 2 || count > Len)
                    {
                        Console.WriteLine($"Потоков должно быть больше 1 и не больше {Len}");
                        SetThread();
                    }
                    else
                    {
                        int threads = Len / count;
                        Console.WriteLine(threads);
                        return threads;
                    }
                }
            }
        }
    }
}
