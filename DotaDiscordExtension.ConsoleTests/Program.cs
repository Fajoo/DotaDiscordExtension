using System;
using DotaDiscordExtension.Core;

namespace DotaDiscordExtension.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new DiscordProvider();

            test.Start();

            Console.ReadLine();

            test.Stop();
        }
    }
}
