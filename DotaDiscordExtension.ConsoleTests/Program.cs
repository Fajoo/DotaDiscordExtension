using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using DotaDiscordExtension.Core;
using Newtonsoft.Json;

namespace DotaDiscordExtension.ConsoleTests
{
    class Program
    {
        private static HttpListener _http = new HttpListener();

        static async Task Main(string[] args)
        {
            //var test = new DiscordProvider();

            //test.Start();
            _http.Prefixes.Add("http://localhost:4000/");
            _http.Start();

            while (true)
            {
                _http.BeginGetContext(GetContext, _http);

                await Task.Delay(new TimeSpan(0, 0, 5));
            }

            //test.Stop();
        }

        private static void GetContext(IAsyncResult ar)
        {
            Console.Beep();

            var context = _http.EndGetContext(ar);

            var req = context.Request;

            using Stream inputStream = req.InputStream;
            using StreamReader sr = new StreamReader(inputStream);

            var read = sr.ReadToEnd();

            var result = JsonConvert.DeserializeObject<DAL.Rootobject>(read);

            Console.WriteLine(result);
        }
    }
}
