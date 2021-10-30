using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices.ComTypes;
using System.ServiceProcess;
using DotaDiscordExtension.Core;
using DotaDiscordExtension.Core.Models;
using static System.Console;

const string welcome = @" █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████ 
▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀ 
▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███   
░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄ 
░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒
░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░
  ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░
  ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░   
    ░       ░  ░    ░  ░░ ░          ░ ░         ░      ░  ░
                        ░                                   ";

const string inst =
    @" ██▓ ███▄    █   ██████ ▄▄▄█████▓ ▄▄▄       ██▓     ██▓    ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████   ███▄    █ 
▓██▒ ██ ▀█   █ ▒██    ▒ ▓  ██▒ ▓▒▒████▄    ▓██▒    ▓██▒   ▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒ ██ ▀█   █ 
▒██▒▓██  ▀█ ██▒░ ▓██▄   ▒ ▓██░ ▒░▒██  ▀█▄  ▒██░    ▒██░   ▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒▓██  ▀█ ██▒
░██░▓██▒  ▐▌██▒  ▒   ██▒░ ▓██▓ ░ ░██▄▄▄▄██ ▒██░    ▒██░   ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░▓██▒  ▐▌██▒
░██░▒██░   ▓██░▒██████▒▒  ▒██▒ ░  ▓█   ▓██▒░██████▒░██████▒▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░▒██░   ▓██░
░▓  ░ ▒░   ▒ ▒ ▒ ▒▓▒ ▒ ░  ▒ ░░    ▒▒   ▓▒█░░ ▒░▓  ░░ ▒░▓  ░▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ 
 ▒ ░░ ░░   ░ ▒░░ ░▒  ░ ░    ░      ▒   ▒▒ ░░ ░ ▒  ░░ ░ ▒  ░ ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░ ░ ░░   ░ ▒░
 ▒ ░   ░   ░ ░ ░  ░  ░    ░        ░   ▒     ░ ░     ░ ░    ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░   ░ ░ 
 ░           ░       ░                 ░  ░    ░  ░    ░  ░     ░  ░         ░      ░ ░           ░ 
                                                                                                    ";

var service = $"{Environment.CurrentDirectory}\\lib\\DotaDiscordExtension.Service.exe";

var isCreated = ServiceController
    .GetServices()
    .FirstOrDefault(i => i.ServiceName.Equals("DotaDiscordExtension"));

if (isCreated is not null)
{
    WriteLine($"{welcome}\n\n\nThe service is already installed... Enter YES to delete...");
    var res = ReadLine();
    if (res != null && string.Equals(res.ToLower(), "yes"))
    {
        var pr = new ProcessStartInfo()
        {
            FileName = "cmd.exe",
            Arguments = $"/k sc.exe stop DotaDiscordExtension & sc.exe delete DotaDiscordExtension",
            WindowStyle = ProcessWindowStyle.Hidden,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process.Start(pr);
    }

    return;
}

WriteLine($"{welcome}\n\n\n\tPress any button to start installation...");

ReadKey();
Clear();

WriteLine($"{inst}\n\n\nProgress: |██████████████████-------------------------------| 30.0% Complete\n\nSearching for Dota 2 on a computer...");

var config = new SteamConfigure();
var resultSearch = await config.CreateFileAsync();
if (resultSearch == WriteResult.Error)
{
    WriteError("Dota 2 or Steam not found");
    return;
}

Clear();
WriteLine($"{inst}\n\n\nProgress: |██████████████████████████████-----------------------| 50.0% Complete\n\nDotaDiscordExtension.Service installation...");

var fileExist = File.Exists(service);
if (!fileExist)
{
    WriteError("DotaDiscordExtension.Service not found");
    return;
}

var psiOpt = new ProcessStartInfo()
{
    FileName = "cmd.exe",
    Arguments = $"/k sc.exe create DotaDiscordExtension start=auto binpath=\"{service}\" && sc.exe start DotaDiscordExtension",
    WindowStyle = ProcessWindowStyle.Hidden,
    RedirectStandardOutput = true,
    UseShellExecute = false,
    CreateNoWindow = true
};

Process.Start(psiOpt);

WriteLine("Run DotaDiscordExtension.Service...");

Clear();

WriteLine($"{inst}\n\n\nProgress: |█████████████████████████████████████████████████████████████████| 100.0% Complete\n\nSuccessful installation...");

void WriteError(string msg)
{
    BackgroundColor = ConsoleColor.Red;
    WriteLine($"\nError... {msg}...");
    ResetColor();
    ReadKey();
}

ReadKey();