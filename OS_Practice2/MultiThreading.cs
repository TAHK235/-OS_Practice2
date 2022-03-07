using System;
using System.Text;
using System.Threading.Tasks;

namespace OS_Practice2
{
    internal static class MultiThreading
    {
        internal static void BruteHash(string hash)
        {
            DateTime start = DateTime.Now;
            Parallel.For(0, 26, a =>
            {
                byte[] password = new byte[5];
                password[0] = (byte) (97 + a);
                for (password[1] = 97; password[1] < 123; password[1]++)
                for (password[2] = 97; password[2] < 123; password[2]++)
                for (password[3] = 97; password[3] < 123; password[3]++)
                for (password[4] = 97; password[4] < 123; password[4]++)
                {
                    string passwordString = Encoding.ASCII.GetString(password);
                    string hashed = Hash.GetStringSha256Hash(passwordString);
                    if (hash != hashed) continue;

                    Console.WriteLine($"Найден пароль {passwordString}, hash {hashed}");
                    Console.WriteLine(DateTime.Now - start);
                }
            });
        }
    }
}
