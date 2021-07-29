using System;
using DotaDiscordExtension.Core;

namespace DotaDiscordExtension.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Dota2Provider();

            test.Start();

            Console.ReadLine();

            test.Stop();
        }
    }
}
