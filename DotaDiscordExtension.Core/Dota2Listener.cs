using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using DotaDiscordExtension.Core.Interfaces;
using DotaDiscordExtension.Core.Models.DotaData;
using Newtonsoft.Json;

namespace DotaDiscordExtension.Core
{
    public class Dota2Listener : IDisposable
    {
        public bool IsRunning { get; private set; } = false;

        private TimeSpan _timer = new(0, 0, 5);

        private readonly HttpListener _httpListener;

        public event Action<DotaInfo> GetDotaInfo;

        public Dota2Listener(string uri)
        {
            _httpListener = new HttpListener();
            _httpListener.Prefixes.Add(uri);
        }

        public async Task Start()
        {
            if (IsRunning)
                return;

            _httpListener.Start();
            IsRunning = true;

            while (IsRunning)
            {
                _httpListener.BeginGetContext(GetContext, _httpListener);

                await Task.Delay(_timer);
            }

            _httpListener.Stop();
        }

        private async void GetContext(IAsyncResult ar)
        {
            try
            {
                var context = _httpListener.EndGetContext(ar);

                var req = context.Request;

                using var inputStream = req.InputStream;
                using var sr = new StreamReader(inputStream);

                var json = await sr.ReadToEndAsync();

                var result = JsonConvert.DeserializeObject<DotaInfo>(json);

                if (result is not null)
                    GetDotaInfo?.Invoke(result);
            }
            catch 
            {
               // ignored
            }
        }

        public void Stop() => IsRunning = false;

        public void Dispose()
        {
            Stop();
            _httpListener.Close();
        }
    }
}